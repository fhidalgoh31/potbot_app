using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Potbot
{
    public partial class Form3 : Form
    {
        static string hex_file;
        public Form3()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;

        public Form3(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button_loc_fol_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Properties.Settings.Default.hex_file;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Properties.Settings.Default.hex_file = openFileDialog1.FileName;
            hex_file = Properties.Settings.Default.hex_file;
            button_loc_fol.Text = hex_file;
           
            // Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal.

        }

        private void picBox_loc_fol_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            port_label.Text += Form1.potbot_port;
            button_loc_fol.Text = Properties.Settings.Default.hex_file;
            hex_file= Properties.Settings.Default.hex_file;
        }

        private void but_upload_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            cmd.StandardInput.WriteLine(Path.GetDirectoryName(hex_file) + "/avrdude -C" + Path.GetDirectoryName(hex_file) + "/avrdude.conf -v -patmega328p -carduino -P" + Form1.potbot_port + " -b57600 -D -Uflash:w:" + hex_file + ":i");
            //cmd.StandardInput.WriteLine("avrdude -Cavrdude.conf -v -patmega328p -carduino -PCOM7 -b57600 -D -Uflash:w:c:/GitHub/Potbot/Pot_code_build/Pot_code.ino.with_bootloader.hex:i");
            //cmd.StandardInput.WriteLine("avrdude");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            //cmd.WaitForExit();
            while(!cmd.HasExited)
                Text_console.AppendText(cmd.StandardOutput.ReadToEnd());

            //var proc1 = new ProcessStartInfo();
            //string anyCommand;
            //proc1.UseShellExecute = true;

            //proc1.WorkingDirectory = @"C:\Windows\System32";

            //proc1.FileName = @"C:\Windows\System32\cmd.exe";
            //proc1.Verb = "runas";
            //proc1.Arguments = "/cC:/Users/fhida/AppData/Local/Arduino15/packages/arduino/tools/avrdude/6.3.0-arduino14/bin/avrdude -CC:/Users/fhida/AppData/Local/Arduino15/packages/arduino/tools/avrdude/6.3.0-arduino14/etc/avrdude.conf -v -patmega328p -carduino -PCOM12 -b57600 -D -Uflash:w:c:/GitHub/Potbot/Pot_code_build/Pot_code.ino.with_bootloader.hex:i";
            //proc1.WindowStyle = ProcessWindowStyle.Normal;
            //Process.Start(proc1);

            // For the example.
            // Use ProcessStartInfo class.
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = true;
            //startInfo.UseShellExecute = false;
            //startInfo.FileName = "avrdude";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.Arguments = "-Cavrdude.conf -v -patmega328p -carduino -PCOM7 -b57600 -D -Uflash:w:c:/GitHub/Potbot/Pot_code_build/Pot_code.ino.with_bootloader.hex:i";
            //try
            //{
            //    // Start the process with the info we specified.
            //    // Call WaitForExit and then the using-statement will close.
            //    using (Process exeProcess = Process.Start(startInfo))
            //    {
            //        exeProcess.WaitForExit();
            //    }
            //}
            //catch
            //{
            //    // Log error.
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.mainForm.Text_console.AppendText("Form 2 button clicked" + Environment.NewLine);
        //}
    }
}
