using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
namespace Potbot
{
    public partial class Form1 : Form
    {
        public static string potbot_port;
        String[] text_values = new String[Constants.N_PARS + 1];

        public static System.IO.Ports.SerialPort sport;
        string backupDir;       // folder for downloading video and data
        int all_in_state = 0;  // state for the process of downloading data from Potbot
        string text_console_tmp;
        int ol_flag = 0;    // 0: not received, 1: received, 2: error !>
        int pot_flag = 0;    // 0: not received, 1: received, 2: error !>
        int imu_logger = 0;
        int ticks_timed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        enum my_status
        {
            p_read, // 
            p_read_ok,
            p_write,
            p_write_ok,
            p_dvideo,
            p_dvideo_ok,
            p_wcamera,
            p_wcamera_ok,
            p_dlog,
            p_dlog_ok,
            p_wlog,
            p_wlog_ok,
            p_idle,
            p_ologcom,
            p_ologcom_ok,
            p_olog_error,
            p_pot_prompt,
            p_olog_prompt
        };

        enum my_messages
        {
            OK,
            error,
            warning,
            general
        };
        my_status interface_status;
        my_status old_interface_status;
        // ------------------------Detect USB devices

        string[] getUsbDisks()
        {
            int i = 0;
            string[] lista;
            Console.WriteLine("fetching logical disks...");
            try
            {
                ManagementObjectCollection drives = new ManagementObjectSearcher(
                "SELECT Caption, DeviceID FROM Win32_DiskDrive WHERE InterfaceType='USB'").Get();

                lista = new string[drives.Count];
                // browse all USB WMI physical disks
                foreach (ManagementObject drive in drives)
                {

                    // browse all USB WMI physical disks
                    foreach (ManagementObject partition in new ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='"
                    + drive["DeviceID"]
                    + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                    {
                        // browse all USB WMI physical disks
                        foreach (ManagementObject disk in new ManagementObjectSearcher(
                        "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='"
                        + partition["DeviceID"]
                        + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                        {
                            lista[i] = disk["CAPTION"].ToString();
                            i++;
                        }
                    }
                }
                return lista;
            }
            catch (Exception e)
            {

                Console.WriteLine("error: " + e.ToString());

                return null;
            }

        }
        // ------------------------ Begin  Detect Serial Port Begin --------------------------
        static string[] FindAllPorts()
        {
            List<string> ports = new List<string>();

            foreach (ManagementObject obj in FindPorts())
            {
                try
                {
                    if (obj["Caption"].ToString().Contains("(COM"))
                    {
                        string comName = ParseCOMName(obj);
                        if (comName != null)
                            ports.Add(comName);
                    }
                }
                catch (Exception e)
                {
                    //Text_console.AppendText(e + Environment.NewLine);
                }
            }
            return ports.ToArray();
        }

        static string FindPortByDescription(string description)
        {
            foreach (ManagementObject obj in FindPorts())
            {
                try
                {
                    if (obj["Description"].ToString().ToLower().Equals(description.ToLower()))
                    {
                        string comName = ParseCOMName(obj);
                        if (comName != null)
                            return comName;
                    }
                }
                catch (Exception e)
                {
                    //Text_console.AppendText(e + Environment.NewLine);
                }
            }
            return null;
        }

        static ManagementObject[] FindPorts()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
                List<ManagementObject> objects = new List<ManagementObject>();

                foreach (ManagementObject obj in searcher.Get())
                {
                    objects.Add(obj);
                }
                return objects.ToArray();
            }
            catch (Exception e)
            {
                //Text_console.AppendText(e + Environment.NewLine);
                return new ManagementObject[] { };
            }
        }

        static string ParseCOMName(ManagementObject obj)
        {
            string name = obj["Name"].ToString();
            int startIndex = name.LastIndexOf("(");
            int endIndex = name.LastIndexOf(")");

            if (startIndex != -1 && endIndex != -1)
            {
                name = name.Substring(startIndex + 1, endIndex - startIndex - 1);
                return name;
            }
            return null;
        }
        // ------------------------ End Detect Serial Port End --------------------------
        public void serialport_connect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();

            sport = new System.IO.Ports.SerialPort(port, baudrate, parity, databits, stopbits);
            //sport.ReadTimeout = 500;
            //sport.ReadBufferSize = 30;
            //System.Text.Encoding.GetEncoding(1252);
            try
            {
                sport.Open();
                Text_console.AppendText("[" + dtn + "] " + "Connected" + Environment.NewLine);
                sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp_rx;
            try
            {
                temp_rx = sport.ReadLine();
                if (interface_status== my_status.p_dlog)
                {
                    temp_rx = Regex.Replace(temp_rx, @".+\*|", "");
                }
                SetText(temp_rx + "\n");

                if (interface_status== my_status.p_ologcom || interface_status == my_status.p_olog_error)
                    if (temp_rx.Contains("!>"))
                    { interface_status = my_status.p_olog_error; SetText("OPENLOG ERROR PROMPT RECEIVED" + Environment.NewLine); }
                    else if (temp_rx.Contains("OL CMD_MODE") || temp_rx.Contains(">"))
                    { interface_status = my_status.p_ologcom_ok; SetText("OPENLOG PROMPT RX ologcom" + Environment.NewLine); }
                if (interface_status == my_status.p_dlog)
                    if (temp_rx.Contains(">"))
                    {
                        interface_status = my_status.p_dlog_ok; SetText("OPENLOG PROMPT RX dlog" + Environment.NewLine);
                        sport.DiscardInBuffer();
                    }
                //else if (temp_rx.Contains("!>"))
                //{    interface_status=my_status.p_olog_error; SetText("OPENLOG ERROR PROMPT RECEIVED" + Environment.NewLine); } 
                //else if (temp_rx.Contains(">"))
                //{
                //    interface_status = my_status.p_olog_prompt; SetText("OPENLOG PROMPT RECEIVED" + Environment.NewLine);
                //}
                //else if (temp_rx.Contains("~"))
                //{ interface_status=my_status.p_pot_prompt; SetText("POTBOT PROMPT RECEIVED" + Environment.NewLine); }

                //else if (temp_rx.Contains("Yaw"))
                //{ imu_logger = 1; SetText("IMU LOGGING" + "/n"); }

                if (interface_status == my_status.p_write)
                    if (temp_rx.Contains("Load from PC OK"))  // 0, parameters received
                        interface_status = my_status.p_write_ok;
                if (interface_status == my_status.p_read)
                    if (temp_rx.Contains("x0,"))  // 0, parameters received
                    {
                        var values = temp_rx.Split(',');
                        SetText("SPLIT IS: " + values.Length.ToString() + Environment.NewLine);
                        if (values.Length == Constants.N_PARS + 2)          //parameters received correctly
                        {
                            interface_status = my_status.p_read_ok;
                            text_values = temp_rx.Split(',');
                            text_values[3] = (float.Parse(text_values[3]) - 1000).ToString("0");
                            text_values[6] = (float.Parse(text_values[6]) - 1000).ToString("0");
                            for (int i = 1; i < text_values.Length - 1; i++)
                                SetText("Parameter " + i.ToString() + " : " + text_values[i].ToString() + Environment.NewLine);
                        }

                    }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Uart exception: " + ex);
            }
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Text_console.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text_console.AppendText(text);
            }
        }

        delegate void SetText_notiCallback(string text, my_messages noti_color = my_messages.general);
        private void SetText_noti(string text, my_messages noti_color = my_messages.general)
        {
            if (noti_color == my_messages.OK)
                text_notification.SelectionColor = Color.Green;
            else if (noti_color == my_messages.error)
                text_notification.SelectionColor = Color.Red;
            else if (noti_color == my_messages.warning)
                text_notification.SelectionColor = Color.Yellow;
            else
                text_notification.SelectionColor = Color.Black;
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.text_notification.InvokeRequired)
            {
                SetText_notiCallback d = new SetText_notiCallback(SetText_noti);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.text_notification.AppendText(text);
            }
            text_notification.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backupDir = Properties.Settings.Default.pot_folder ;
            checkbox_d_log.Checked = Properties.Settings.Default.log_d;
            checkbox_w_log.Checked = Properties.Settings.Default.log_w;
            checkbox_d_vid.Checked = Properties.Settings.Default.vid_d;
            checkbox_w_vid.Checked = Properties.Settings.Default.vid_w;

            button_loc_fol.Text = backupDir + "/";
            Text_console.AppendText("Potbot port:" + Environment.NewLine);
            potbot_port= FindPortByDescription("USB-SERIAL CH340");
            if (potbot_port != null)
            {
                Text_console.AppendText(potbot_port + Environment.NewLine);
                serialport_connect(potbot_port, 115200, Parity.None, 8, StopBits.One);
            }
            else
            {
                potbot_port = FindPortByDescription("USB Serial Port");
                if (potbot_port != null)
                {
                    Text_console.AppendText(potbot_port + Environment.NewLine);
                    serialport_connect(potbot_port, 115200, Parity.None, 8, StopBits.One);
                }
                else
                {
                    Text_console.AppendText("Potbot not found! Press reset on Potbot or Disconnect and Connect it again..." + Environment.NewLine);
                    SetText_noti("Potbot not found! Please close the App, disconnect and connect the Potbot again..." + Environment.NewLine, my_messages.error);
                    return;
                }
            }
            button_read_pot_Click(sender, e);
            //text_notification.AppendText("Potbot found in " + potbot_port + Environment.NewLine);
            SetText_noti("Potbot found in " + potbot_port + Environment.NewLine, my_messages.OK);
        }

        private void timer_read_pot_Tick(object sender, EventArgs e)
        {
            SetText("Update values \t Update values \t Update values \n");
            TextBox[] TextBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };
            for (int i = 0; i < TextBoxes.Length; i++)
            {
                if (!String.IsNullOrEmpty(text_values[i + 1]))
                    if(i==2 || i== 5)
                        TextBoxes[i].Text = (float.Parse(text_values[i + 1])).ToString("0.0");
                    else
                    TextBoxes[i].Text = (float.Parse(text_values[i + 1]) / 60).ToString("0.0");
                else
                    TextBoxes[i].Text = text_values[i + 1];
                SetText(text_values[i] + "\n");
            }
            int number;
            int.TryParse(text_values[13], out number);
            chk_P1_hrs.Checked = Convert.ToBoolean(number);
            timer_read_pot.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data_sent = "o";
            try
            {
                sport.Write(data_sent);
            }
            catch (UnauthorizedAccessException ex)
            {
                SetText("Uart exception: " + ex + "\n");
            }
            write_console(data_sent);

        }

        private void write_console(string text)
        {
            DateTime dt = DateTime.Now;
            String dtn = dt.ToShortTimeString();
            Text_console.AppendText("[" + dtn + "] " + "Sent: " + text + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sport.Write(((char)26).ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                SetText("Uart exception: " + ex + "\n");
            }
            for (int i = 0; i < 99999; i++)
            { }
            string data_sent = "m";
            sport.Write(data_sent);
            write_console(data_sent);
            sport.Close();
            this.Close();
        }

        private void label_P9_Click(object sender, EventArgs e)
        {

        }

        private void button_rest_dft_Click(object sender, EventArgs e)
        {
            SetText_noti("Restore Default Parameters \n");
            textBox1.Text = Properties.Settings.Default.P1;
            textBox2.Text = Properties.Settings.Default.P2;
            textBox3.Text = Properties.Settings.Default.P3;
            textBox4.Text = Properties.Settings.Default.P4;
            textBox5.Text = Properties.Settings.Default.P5;
            textBox6.Text = Properties.Settings.Default.P6;
            textBox7.Text = Properties.Settings.Default.P7;
            textBox8.Text = Properties.Settings.Default.P8;
            textBox9.Text = Properties.Settings.Default.P9;
            textBox10.Text = Properties.Settings.Default.P10;
            textBox11.Text = Properties.Settings.Default.P11;
            textBox12.Text = Properties.Settings.Default.P12;
            checkbox_d_log.Checked= Properties.Settings.Default.log_d;
            checkbox_w_log.Checked = Properties.Settings.Default.log_w;
            checkbox_d_vid.Checked = Properties.Settings.Default.vid_d;
            checkbox_w_vid.Checked = Properties.Settings.Default.vid_w;
            SetText_noti("Parameters loaded. Click \"Write Settings to POTBot\" \n",my_messages.OK);
        }

        private void label_P3_Click(object sender, EventArgs e)
        {

        }

        private void button_read_pot_Click(object sender, EventArgs e)
        {
            string data_sent = "r";
            sport.Write(data_sent);
            timer_read_pot.Enabled = true;
            SetText_noti("Reading parameters from Potbot" + Environment.NewLine);
            interface_status = my_status.p_read;
            status_chk.Enabled = true;
        }

        private void button_write_pot_Click(object sender, EventArgs e)
        {
            sport.Write("u");
            //string parameters=String.Join("0,",tb1.Text,',',tb2.Text, ',', tb3.Text, ',', tb4.Text, ',', tb5.Text, ',', tb6.Text, ',', tb7.Text, ',', tb8.Text, tb9.Text,',',tb10.Text, ',', checkBox1.CheckState.ToString());
            string parameters = "00," +
                                ((uint)(float.Parse(textBox1.Text) * 60)).ToString()+ "," +
                                ((uint)(float.Parse(textBox2.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox3.Text) + 1000)).ToString() + "," +
                                ((uint)(float.Parse(textBox4.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox5.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox6.Text) + 1000)).ToString() + "," +
                                ((uint)(float.Parse(textBox7.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox8.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox9.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox10.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox11.Text) * 60)).ToString() + "," +
                                ((uint)(float.Parse(textBox12.Text) * 60)).ToString() + "," +
                                Convert.ToInt16(chk_P1_hrs.Checked) + ",";
            //string parameters = "00," + textBox1.Text + "\n" + textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n" + textBox5.Text +
            //                    "\n" + textBox6.Text + "\n" + textBox7.Text + "\n" + textBox8.Text + "\n" + textBox9.Text + "\n" + textBox10.Text + "\n" + textBox11.Text + "\n" + textBox12.Text + "\n";
            Text_console.AppendText("To Send port:" + parameters + Environment.NewLine);
            foreach (char c in parameters)
            {
                uint a = 0;
                while (a < 10000000)
                    a++;
                sport.Write(c.ToString());
            }
            sport.Write(((char)13).ToString());
            SetText_noti("Writing parameters to Potbot" + Environment.NewLine);
            interface_status = my_status.p_write;
            status_chk.Enabled = true;
        }

        private void button_loc_fol_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            SetText(Path.GetDirectoryName(name));
            Properties.Settings.Default.pot_folder = Path.GetDirectoryName(name);
            backupDir = Properties.Settings.Default.pot_folder + "/";
            button_loc_fol.Text = backupDir;
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string[] usb_list = getUsbDisks();
            string usb_string;
            foreach (String s in usb_list)
            {
                String sourceDir = s + "/DCIM/";
                if (Directory.Exists(sourceDir))
                {

                    SetText("Potbot detected in: " + sourceDir + "\n");
                    string[] vidList = Directory.GetFiles(sourceDir, "*.*");
                    // Copy video files.
                    foreach (string f in vidList)
                    {
                        // Remove path from the file name.
                        string fName = f.Substring(sourceDir.Length);

                        if (!Directory.Exists(backupDir))
                            System.IO.Directory.CreateDirectory(backupDir);

                        // Use the Path.Combine method to safely append the file name to the path.
                        // Will overwrite if the destination file already exists.
                        try
                        {
                            File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                        }
                        catch (IOException copyError)
                        {
                            SetText(copyError.Message + "\n");
                        }
                    }


                }
                else
                {
                    SetText("Potbot not found in " + sourceDir + "\n");
                }

            }

        }

        private void seq_all_in_one_Tick(object sender, EventArgs e)
        {
            string data_sent;
            switch (all_in_state)
            {
                case 0:                 // switch to openlog if download or wipe checked
                    if (checkbox_d_log.Checked || checkbox_w_log.Checked)
                    {
                        interface_status = my_status.p_ologcom;
                        data_sent = "o";
                        sport.Write(((char)13).ToString());
                        for (int i = 0; i < 99999; i++)
                        { i = i; }
                        sport.Write(data_sent);
                        write_console(data_sent);
                        if (checkbox_d_log.Checked)
                        {
                            all_in_state++;
                            SetText_noti("Download POTBot Log\n");
                        }
                        else
                        {
                            all_in_state = 8;
                            SetText_noti("Camera\n");
                        }
                    }
                    else
                    {
                        all_in_state = 7;
                    }
                    ticks_timed = 0;
                    break;

                case 1:                 // wait for openlog mode
                    if (interface_status == my_status.p_ologcom_ok)
                    {
                        all_in_state++;
                        SetText_noti("Connected to logger\n", my_messages.OK);
                    }
                    else                              //test if already in ol
                    {
                        sport.Write(((char)13).ToString());
                        for (int i = 0; i < 99999; i++)
                        { i = i; }
                        if (ticks_timed > 5)
                        {
                            seq_all_in_one.Enabled = false;
                            interface_status = my_status.p_olog_error;
                        }
                    }
                    break;

                case 2:                     // request to read openlog
                    sport.Write(((char)13).ToString());
                    for (int i = 0; i < 99999; i++)
                    { i = i; }
                    foreach (char c in (string)"read seqlog00.txt")
                    {
                        int a = 0;
                        while (a < 9999999)
                            a++;
                        sport.Write(c.ToString());
                    }
                    //ol_flag = 0;   // 0: not received, 1: received, 2: error !>
                    sport.Write(((char)13).ToString());
                    for (int i = 0; i < 99999; i++)
                    { i = i; }
                    ticks_timed = 0;
                    SetText("read seqlog00.txt");
                    SetText_noti("Reading from logger\n");
                    Text_console.Text = String.Empty;
                    all_in_state++;
                    sport.DiscardInBuffer();
                    //text_console_tmp = Text_console.Text;
                    break;
                case 3:                     // read all?
                    if (interface_status == my_status.p_dlog_ok)
                    {
                        all_in_state++;
                    }
                    interface_status = my_status.p_dlog;
                    SetText_noti(".");
                    sport.Write(((char)13).ToString());
                    break;
                case 4:                             // write file
                    File.WriteAllText(backupDir + DateTime.Now.ToString("MM_dd_yyyy_HH_mm") +"_log.txt", Text_console.Text);
                    SetText_noti("\nPOTBot log downloaded correctly\n", my_messages.OK);
                    sport.Write(((char)13).ToString());
                    all_in_state++;
                    break;

                case 5:                     // wipe openlog
                    if (checkbox_w_log.Checked)
                    {
                        SetText_noti("Wipe Log\n");
                        interface_status = my_status.p_ologcom;
                        sport.Write(((char)13).ToString());
                            foreach (char c in (string)"rm seqlog00.txt")
                            {
                                int a = 0;
                                while (a < 999999)
                                    a++;
                                sport.Write(c.ToString());
                                //write_console(c.ToString());
                            }
                            sport.Write(((char)13).ToString());
                        all_in_state++;
                    }
                    else
                    {
                        all_in_state = 7;
                    }
                    break;

                case 6:
                    if (interface_status == my_status.p_ologcom_ok)   // wait from rm prompt
                    {
                        SetText_noti("POTBot log wiped correctly\n", my_messages.OK);
                        all_in_state++;
                    }
                    else
                        all_in_state = 5;
                    break;

                case 7:                                     // switch to camera
                    if (checkbox_d_vid.Checked || checkbox_w_vid.Checked)                      //check camera check box
                    {
                        try
                        {
                            SetText_noti("Switch to camera");
                            sport.Write(((char)26).ToString());
                            for (int i = 0; i < 99999; i++)
                            { i = i; }
                            sport.Write(((char)26).ToString());
                            for (int i = 0; i < 99999; i++)
                            { i = i; }
                            data_sent = "m";
                            sport.Write(data_sent);
                            write_console(data_sent);
                            all_in_state++;
                            sport.Close();
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            SetText("Uart exception: " + ex + "\n");
                        }
                    }
                    else
                    {
                        seq_all_in_one.Enabled = false;
                        SetText_noti("Download process finished\n");
                    }
                    break;

                case 8:                                     // check videos folder
                    string[] usb_list = getUsbDisks();
                    string usb_string;
                    SetText_noti(".");
                    foreach (String s in usb_list)
                    {
                        String sourceDir = s + "/DCIM/100HDDVR/";
                        if (Directory.Exists(sourceDir))
                        {
                            SetText_noti("\nConnected to Camera\n", my_messages.OK);
                            SetText("Potbot Videos detected in: " + sourceDir + "\n");
                            string[] vidList = Directory.GetFiles(sourceDir, "*.*");
                            int f_count=0;
                            int f_found = vidList.Length;
                            SetText_noti(f_found + " videos detected in " + sourceDir + "\n", my_messages.OK);
                            if (checkbox_d_vid.Checked)
                            {
                                // Copy video files.
                                foreach (string f in vidList)
                                {
                                    // Remove path from the file name.
                                    string fName = f.Substring(sourceDir.Length);

                                    if (!Directory.Exists(backupDir))
                                        System.IO.Directory.CreateDirectory(backupDir);

                                    // Use the Path.Combine method to safely append the file name to the path.
                                    // Will overwrite if the destination file already exists.
                                    try
                                    {
                                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                                        f_count++;
                                        progressBar_cam.Value = f_count * 100 / f_found;
                                    }
                                    catch (IOException copyError)
                                    {
                                        SetText(copyError.Message + "\n");
                                        SetText_noti("Error copying\n", my_messages.error);
                                    }
                                    
                                }
                                SetText_noti("Potbot Videos Copied: " + vidList.Count() + "\n",my_messages.OK);
                            }
                            if (checkbox_w_vid.Checked)              // wipe camera files
                            {
                                f_count = 0;
                                SetText_noti("Deleting files\n");
                                foreach (string f in vidList)
                                {
                                    // Remove path from the file name.
                                    string fName = f.Substring(sourceDir.Length);

                                    try
                                    {
                                        File.Delete(Path.Combine(sourceDir, fName));
                                        f_count++;
                                        progressBar_cam.Value = f_count * 100 / f_found;
                                    }
                                    catch (IOException copyError)
                                    {
                                        SetText(copyError.Message + "\n");

                                    }

                                }
                                SetText_noti("Potbot Videos Deleted: " + vidList.Count() + "\n",my_messages.OK);
                            }
                            seq_all_in_one.Enabled = false;
                            SetText_noti("Download process finished\n");
                        }
                        else
                        {
                            SetText("Potbot Video files not found" + sourceDir + "\n");
                            SetText_noti("No files found in camera", my_messages.error);
                            if (ticks_timed > 2)
                            {
                                SetText("Potbot Video files not found" + sourceDir + "\n");
                                all_in_state++;
                            }
                        }

                    }
                    break;
                default:
                    break;
            }
            ticks_timed++;
        }

        private void Save_dafault_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default["SomeProperty"] = "Some Value";
            //Properties.Settings.Default.Save(); // Saves settings in application configuration file
        }

        private void Download_all_Click(object sender, EventArgs e)
        {
            SetText_noti("Starting Download and Wipe process\n");
            status_chk.Enabled = true;
            seq_all_in_one.Enabled = true;
            all_in_state = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        private void label_P7_Click(object sender, EventArgs e)
        {

        }

        private void label_P8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void status_chk_Tick(object sender, EventArgs e)
        {
            status_timeout.Enabled = true;
            if (interface_status == my_status.p_write_ok)
            { SetText_noti("Parameters written correctly" + Environment.NewLine, my_messages.OK); goto status_chk_ok; }

            if (interface_status == my_status.p_read_ok)
            { SetText_noti("Parameters read correctly" + Environment.NewLine, my_messages.OK); goto status_chk_ok; }
            return;

        status_chk_ok:
            status_chk.Enabled = false;
            interface_status = my_status.p_idle;
            status_timeout.Enabled = false;
        }
        static class Constants
        {
            public const int N_PARS = 13;

        }

        private void status_timeout_Tick(object sender, EventArgs e)
        {
            if (interface_status == my_status.p_write)
                SetText_noti("Error writing to Potbot" + Environment.NewLine, my_messages.error);

            if (interface_status == my_status.p_read)
            {
                SetText_noti("Error reading from Potbot" + Environment.NewLine, my_messages.error);
                SetText_noti("Please press reset button on POTBot, wait until LEDs on POTBot are off and  click on \"Read settings from POTBot\"...\n", my_messages.error);
            }
            status_timeout.Enabled = false;
            status_chk.Enabled = false;
            //interface_status = my_status.p_idle;
        }

        private void button_reconn_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)    // open explorer in backup dir
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.UseShellExecute = true;

            process.StartInfo.FileName = @"explorer";

            process.StartInfo.Arguments = @""+backupDir;
            process.Start();
        }

        private void picBox_loc_fol_Click(object sender, EventArgs e)
        {
            button_loc_fol_Click(sender, e);
        }

        private void label_P10_Click(object sender, EventArgs e)
        {

        }

        private void label_P2_Click(object sender, EventArgs e)
        {

        }

        private void but_firmware_Click(object sender, EventArgs e)
        {
            if (sport.IsOpen)
                sport.Close();
            Form3 frm_fir = new Form3(this);
            frm_fir.Show();
        }

        private void save_default_but_Click(object sender, EventArgs e)
        {
            SetText_noti("Saving Default Parameters \n");
            Properties.Settings.Default.P1 = textBox1.Text;
            Properties.Settings.Default.P2 = textBox2.Text;
            Properties.Settings.Default.P3 = textBox3.Text;
            Properties.Settings.Default.P4 = textBox4.Text;
            Properties.Settings.Default.P5 = textBox5.Text;
            Properties.Settings.Default.P6 = textBox6.Text;
            Properties.Settings.Default.P7 = textBox7.Text;
            Properties.Settings.Default.P8 = textBox8.Text;
            Properties.Settings.Default.P9 = textBox9.Text;
            Properties.Settings.Default.P10 = textBox10.Text;
            Properties.Settings.Default.P11 = textBox11.Text;
            Properties.Settings.Default.P12 = textBox12.Text;
            Properties.Settings.Default.log_d = checkbox_d_log.Checked;
            Properties.Settings.Default.log_w = checkbox_w_log.Checked;
            Properties.Settings.Default.vid_d = checkbox_d_vid.Checked;
            Properties.Settings.Default.vid_w = checkbox_w_vid.Checked;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            SetText_noti("Parameters Saved!\n", my_messages.OK);
        }

        private void but_test_Click(object sender, EventArgs e)
        {
            Form2 frm_test = new Form2(this);
            frm_test.Show();
        }

        private void text_notification_TextChanged(object sender, EventArgs e)
        {

        }
    }
    //public static class MyExtensions
    //{
    //    public static bool IsTextEmpty(this TextBox txtBox)
    //    {
    //        return string.IsNullOrEmpty(txtBox.Text);
    //    }
    //}
}
