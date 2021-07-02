using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using ExtensionMethods;
using System.IO;
namespace PotbotTest
{

    // ------------------------Detect USB devices

    

    public partial class Potbot_Form : Form
    {
        public TimeOut my_timeout = new TimeOut();
        public test my_tests = new test();

        // ------------------------ Begin  Get USB devices--------------------------
        string[] getUsbDisks()
        {
            int i = 0; 
            string[] lista;
            //SetText("fetching logical disks...");
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

                SetText("error: " + e.ToString());

                return null;
            }

        }


        // ------------------------ Begin  Detect Serial Port Begin --------------------------
        public System.IO.Ports.SerialPort sport;

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

        static ManagementObject[] FindComPorts2()
        {
            List<ManagementObject> objects = new List<ManagementObject>();

            foreach (ManagementObject obj in FindPorts())
            {
                try
                {
                    if (obj["Caption"].ToString().Contains("(COM"))
                    {
                        string comName = ParseCOMName(obj);
                        if (comName != null)
                            objects.Add(obj);
                    }
                }
                catch (Exception e)
                {

                }
            }
            return objects.ToArray();
        }

        static ManagementObject[] FindComPorts()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
                List<ManagementObject> objects = new List<ManagementObject>();
                List<ManagementObject> obj_ports = new List<ManagementObject>();
                foreach (ManagementObject obj in searcher.Get())
                {
                    objects.Add(obj);
                }

                foreach (ManagementObject obj in objects)
                {
                    if (obj["Caption"].ToString().Contains("(COM"))
                    {
                        string comName = ParseCOMName(obj);
                        if (comName != null)
                            obj_ports.Add(obj);
                    }
                }
                return obj_ports.ToArray();
            }
            catch (Exception e)
            {
                //Text_console.AppendText(e + Environment.NewLine);
                return new ManagementObject[] { };
            }
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
            //sport.ReadTimeout = 100000;
            //System.Text.Encoding.GetEncoding(1252);
            try
            {
                sport.Open();
                tb_console.AppendText("[" + dtn + "] " + "Connected" + Environment.NewLine);
                sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived);
                //timer2.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temp_rx;
            try
            {
                temp_rx = sport.ReadLine();
                SetText(temp_rx + "\n");
                my_tests.check_str(temp_rx);
            }
            catch (Exception ee)
            {
                //Text_console.AppendText(e + Environment.NewLine);
            }
        }
        // ----------------------------End serial port methods ---------
        public Potbot_Form()
        {
            InitializeComponent();
        }

        private void Potbot_test_Load(object sender, EventArgs e)
        {
            this.progbar_timeout.Maximum = TimeOut._TIME_OUT * 1000 / tim_time_out.Interval;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MyExtensions.Ask_radio(sender, radio_gps_ok, radio_gps_fail);
        }
        private void wet_swiw_radioButton(object sender, EventArgs e)
        {
            MyExtensions.Ask_radio(sender, radio_wsiw_ok, radio_wsiw_fail);
        }

        private void cam_radioButton(object sender, EventArgs e)
        {
            MyExtensions.Ask_radio(sender, radio_cam_ok, radio_cam_fail);
        }
        private void radio_wsia_ok_Click(object sender, EventArgs e)
        {
            MyExtensions.Ask_radio(sender, radio_wsia_ok, radio_wsia_fail);
        }
        private async void but_connect_Click(object sender, EventArgs e)
        {
            lab_detected.Text = "Detecting...";
            Cursor.Current = Cursors.WaitCursor;
            tb_console.AppendText("Potbot port:" + Environment.NewLine);
            ManagementObject[] com_ports_detected;
            string potbot_port = null;
            com_ports_detected = FindComPorts2();
            List<string> ports_possible_names = new List<string> { "Arduino Uno", "USB-SERIAL CH340", "USB Serial Port" };
            foreach (ManagementObject obj in com_ports_detected)
            {
                try
                {
                    if (ports_possible_names.Any(w => obj["Description"].ToString().ToLower().Contains(w.ToLower())))
                    {
                        string comName = ParseCOMName(obj);
                        if (comName != null)
                        {
                            potbot_port = comName;
                            break;
                        }
                    }
                }
                catch (Exception ee)
                {
                    //Text_console.AppendText(e + Environment.NewLine);
                }
            }
            if (potbot_port != null)
            {
                SetText(potbot_port + Environment.NewLine);
                serialport_connect(potbot_port, 115200, Parity.None, 8, StopBits.One);
                lab_detected.Text = "POTBot detected in " + potbot_port;
                lab_detected.ForeColor = Color.Green;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                groupBox7.Visible = true;
                groupBox8.Visible = true;
                label9.Visible = true;
                but_connect.Enabled = false;
                cam_test_but.Focus();
                test_but_Click(cam_test_but, e);
                //groupBox2.Location= new System.Drawing.Point(12,282);
            }
            else
            {
                tb_console.AppendText("Potbot not found! Press reset on Potbot or Disconnect and Connect it again..." + Environment.NewLine);
                lab_detected.Text = "POTBot not detected, reconnect POTBot and try again ";
                lab_detected.ForeColor = Color.Red;
            }
            Cursor.Current = Cursors.Default;

        }

        // write in console from any thread
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tb_console.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tb_console.AppendText(text);
            }
        }
        private void time_out_Tick(object sender, EventArgs e)
        {
            int timeout_fraction = my_tests.timeout * 1000 / tim_time_out.Interval;
            if (my_tests.test_timeout.t_tout > timeout_fraction)            // timeout
            {
                my_tests.test_timeout.status = TimeOut.t_status.timed_out;
                tim_time_out.Enabled = false;
                SetText("\ntest Timeout\n");
                my_tests.test_timeout.Reset(tim_time_out, progbar_timeout);
                //MyExtensions.Ask_radio(my_tests.RadioButton_Fail, my_tests.RadioButton_OK, my_tests.RadioButton_Fail);
                my_tests.RadioButton_OK.Checked = false;
                my_tests.RadioButton_Fail.Checked = true;
            }
            else                                                           // normal loop
            {
                progbar_timeout.Value = timeout_fraction - my_tests.test_timeout.t_tout;
                my_tests.test_timeout.t_tout++;
                switch (my_tests.status)
                {
                    case test.test_states.fin_OK:
                        SetText("\ntest OK!\n");
                        my_tests.test_timeout.Reset(tim_time_out, progbar_timeout);
                        //MyExtensions.Ask_radio(my_tests.RadioButton_OK, my_tests.RadioButton_OK, my_tests.RadioButton_Fail);
                        my_tests.RadioButton_OK.Checked = true;
                        my_tests.RadioButton_Fail.Checked = false;
                        // openlog case, return to potbot send >
                        if (my_tests.device==test.my_test_devices.openlog_read)
                            sport.Write(((char)26).ToString());
                        break;
                    case test.test_states.fin_fail:
                        SetText("\ntest Fail!\n");
                        my_tests.test_timeout.Reset(tim_time_out, progbar_timeout);
                        //MyExtensions.Ask_radio(my_tests.RadioButton_Fail, my_tests.RadioButton_OK, my_tests.RadioButton_Fail);
                        my_tests.RadioButton_OK.Checked = false;
                        my_tests.RadioButton_Fail.Checked = true;
                        break;
                    case test.test_states.in_process:
                        // Solo para archivos USB
                        if (my_tests.device == test.my_test_devices.camera_files)
                        {
                            string[] usb_list = getUsbDisks();
                            string usb_string;
                            foreach (String s in usb_list)
                            {
                                String sourceDir = s + "/DCIM/";
                                if (Directory.Exists(sourceDir))
                                    my_tests.status = test.test_states.fin_OK;
                            }
                        }
                       break;

                }
            }

        }

        private void test_but_Click(object sender, EventArgs e)
        {
            Button button= (Button)sender;
            if (button.Name.ToString().Contains("swiw"))
            {
                my_tests.set_device(test.my_test_devices.wet_sw_closed);
                my_tests.RadioButton_OK = radio_wsiw_ok;
                my_tests.RadioButton_Fail = radio_wsiw_fail;
            }
            else if (button.Name.ToString().Contains("cam_test_but"))
            {
                my_tests.set_device(test.my_test_devices.camera);
                my_tests.RadioButton_OK = radio_cam_ok;
                my_tests.RadioButton_Fail = radio_gps_fail;
                timer1.Enabled = true;                      //Special case timer for 5 secs on
            }
            else if (button.Name.ToString().Contains("swia"))
            {
                my_tests.set_device(test.my_test_devices.wet_sw_open);
                my_tests.RadioButton_OK = radio_wsia_ok;
                my_tests.RadioButton_Fail = radio_wsia_fail;
            }
            else if (button.Name.ToString().Contains("temp_test_but"))
            {
                my_tests.set_device(test.my_test_devices.temperature);
                my_tests.RadioButton_OK = radio_temp_ok;
                my_tests.RadioButton_Fail = radio_temp_fail;
            }
            else if (button.Name.ToString().Contains("comp"))
            {
                my_tests.set_device(test.my_test_devices.imu);
                my_tests.RadioButton_OK = radio_comp_ok;
                my_tests.RadioButton_Fail = radio_comp_fail;
            }
            else if (button.Name.ToString().Contains("olog"))
            {
                my_tests.set_device(test.my_test_devices.openlog_read);
                my_tests.RadioButton_OK = radio_olog_ok;
                my_tests.RadioButton_Fail = radio_olog_fail;
            }
            else if (button.Name.ToString().Contains("camf_test_but"))
            {
                my_tests.set_device(test.my_test_devices.camera_files);
                my_tests.RadioButton_OK = radio_camf_ok;
                my_tests.RadioButton_Fail = radio_camf_fail;
                // Específico para archivos USB
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
                try
                {
                    sport.Close();
                }
                catch (UnauthorizedAccessException ex)
                {
                    SetText("Uart exception: " + ex + "\n");
                }
                progbar_timeout.Maximum = my_tests.timeout * 1000 / tim_time_out.Interval;
                my_tests.begin(tim_time_out);
                return;
            }

            progbar_timeout.Maximum = my_tests.timeout* 1000 / tim_time_out.Interval;
            my_tests.begin(tim_time_out);
            sport.Write(my_tests.ser_tx);
        }

        public class TimeOut
        {
            public TimeOut()
            {

            }
            public const int _TIME_OUT = 3;
            public int t_tout = 0;
            public enum t_status
            {
                off, // 
                counting,
                timed_out
            };
            public t_status status;

            public int Initialize(System.Windows.Forms.Timer tim_time_out)
            {
                t_tout = 0;
                status = t_status.counting;
                tim_time_out.Enabled = true;
                return 1;
            }
            public void Reset(System.Windows.Forms.Timer tim_time_out, System.Windows.Forms.ProgressBar progressBar)
            {
                t_tout = 0;
                status = t_status.off;
                tim_time_out.Enabled = false;
                progressBar.Value = 0;
            }
        }

        public class test
        {
            public string ser_tx;
            public string ser_rx_ok;
            public string ser_rx_fail;
            public int num_str;
            public bool usr_chk;
            public RadioButton RadioButton_OK;
            public RadioButton RadioButton_Fail;
            public int timeout;

            public enum test_states
            {
                idle, // 
                in_process,
                t_out,
                fin_OK,
                fin_fail
            };
            public test_states status;
            public enum my_test_devices
            {
                camera,
                wet_sw_open,
                wet_sw_closed,
                gps,
                openlog_read,
                openlog_write,
                imu,
                temperature,
                camera_files
            };

            public my_test_devices device;
            public String info;
            public TimeOut test_timeout = new TimeOut();
            public test()
            {
            }
            // texto en minusculas
            public void set_device(my_test_devices my_device)
            {
                device = my_device;
                ser_rx_ok = "";
                ser_rx_fail = "";
                num_str = 0;
                usr_chk = false;
                timeout = 10;
                switch (device)
                {
                    case my_test_devices.camera:
                        ser_tx = "c";
                        usr_chk = true;
                        break;

                    case my_test_devices.wet_sw_open:
                        ser_tx = "h";
                        ser_rx_ok = "air";
                        ser_rx_fail = "water";
                        num_str = 1;
                        break;

                    case my_test_devices.wet_sw_closed:
                        ser_tx = "h";
                        ser_rx_ok = "water";
                        ser_rx_fail = "air";
                        num_str = 1;
                        break;

                    case my_test_devices.temperature:
                        ser_tx = "t";
                        ser_rx_ok = "temp:";
                        ser_rx_fail = "error temperature";
                        num_str = 1;
                        break;

                    case my_test_devices.imu:
                        ser_tx = "l";
                        ser_rx_ok = "roll:";
                        ser_rx_fail = "error imu";
                        num_str = 3;
                        break;

                    case my_test_devices.openlog_read:
                        ser_tx = "o";
                        ser_rx_ok = ">";
                        ser_rx_fail = "error openlog";
                        num_str = 1;
                        break;
                }
            }
            public my_test_devices get_device()
            {
                return this.device;
            }
            public void begin(System.Windows.Forms.Timer tim_time_out)
            {
                test_timeout.Initialize(tim_time_out);   // Initialize timeout
                status = test_states.in_process;
            }

            public void check_str(string ser_str)
            {
                if (this.status == test_states.in_process && !this.usr_chk)
                {
                    if (ser_str.ToLower().Contains(ser_rx_ok))
                        status = test_states.fin_OK;
                    else if (ser_str.ToLower().Contains(ser_rx_fail))
                        status = test_states.fin_fail;
                }
                //switch (this.device)
                //{
                //    case my_test_devices.wet_sw_closed:
                //        if (ser_str.Contains("water"))
                //        {
                //            status = test_states.fin_OK;
                //        }

                //        else if (ser_str.ToLower().Contains("in"))
                //            status = test_states.fin_fail;
                //        break;
                //    case my_test_devices.wet_sw_open:
                //        if (ser_str.Contains("air"))
                //            status = test_states.fin_OK;
                //        else if (ser_str.ToLower().Contains("in"))
                //            status = test_states.fin_fail;
                //        break;

                //    default:
                //        break;

                //}
            }
        }

        private void wet_swia_test_but_Click(object sender, EventArgs e)
        {
            my_tests.set_device(test.my_test_devices.wet_sw_open);
            my_tests.begin(tim_time_out);
            sport.Write("h");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (my_tests.get_device()==test.my_test_devices.camera)
                sport.Write("C");
            timer1.Enabled = false;
        }

        int seq = 4;
        private void auto_check_Tick(object sender, EventArgs e)
        {
  
            if (my_tests.status!=test.test_states.in_process)
                switch (seq)
                {
                    case 4:
                        if (radio_wsia_ok.Checked || radio_wsia_fail.Checked)
                        { test_but_Click(temp_test_but, e); seq++; }
                        break;
                    case 5:
                        if (radio_temp_ok.Checked || radio_temp_fail.Checked)
                        { test_but_Click(comp_test_but, e); seq++; }
                        break;
                    case 6:
                        if (radio_comp_ok.Checked || radio_comp_fail.Checked)
                        { test_but_Click(olog_test_but, e); seq++; }
                        break;
                    //case 7:
                    //    if (radio_olog_ok.Checked || radio_olog_fail.Checked)
                    //    { test_but_Click(camf_test_but, e); seq++; }
                    //    break;
                }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}



namespace ExtensionMethods
{
 

    public static class MyExtensions
    {
        public static int Ask_radio(object sender, RadioButton ok, RadioButton fail)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
                return 1;
            else
                if (ok.Checked || fail.Checked)
            {
                string message = "Do you want to manually change it?";
                string caption = "POTBot Test";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    radio.Checked = true;
                    if (radio.Name == ok.Name)
                        fail.Checked = false;
                    else
                        ok.Checked = false;
                }
            }
            else
                radio.Checked = !radio.Checked;

            return 1;
        }
    }
}