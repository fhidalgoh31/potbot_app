namespace PotbotTest
{
    partial class Potbot_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Potbot_Form));
            this.tb_console = new System.Windows.Forms.TextBox();
            this.tb_pbid = new System.Windows.Forms.TextBox();
            this.lb_pbid = new System.Windows.Forms.Label();
            this.lb_gps_info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_gps_fail = new System.Windows.Forms.RadioButton();
            this.radio_gps_ok = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.but_connect = new System.Windows.Forms.Button();
            this.lab_detected = new System.Windows.Forms.Label();
            this.tim_time_out = new System.Windows.Forms.Timer(this.components);
            this.progbar_timeout = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wet_swiw_test_but = new System.Windows.Forms.Button();
            this.radio_wsiw_fail = new System.Windows.Forms.RadioButton();
            this.radio_wsiw_ok = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wet_swia_test_but = new System.Windows.Forms.Button();
            this.radio_wsia_fail = new System.Windows.Forms.RadioButton();
            this.radio_wsia_ok = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cam_test_but = new System.Windows.Forms.Button();
            this.radio_cam_fail = new System.Windows.Forms.RadioButton();
            this.radio_cam_ok = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.temp_test_but = new System.Windows.Forms.Button();
            this.radio_temp_fail = new System.Windows.Forms.RadioButton();
            this.radio_temp_ok = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comp_test_but = new System.Windows.Forms.Button();
            this.radio_comp_fail = new System.Windows.Forms.RadioButton();
            this.radio_comp_ok = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.olog_test_but = new System.Windows.Forms.Button();
            this.radio_olog_fail = new System.Windows.Forms.RadioButton();
            this.radio_olog_ok = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.camf_test_but = new System.Windows.Forms.Button();
            this.radio_camf_fail = new System.Windows.Forms.RadioButton();
            this.radio_camf_ok = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.auto_check = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_console
            // 
            this.tb_console.Location = new System.Drawing.Point(9, 743);
            this.tb_console.Margin = new System.Windows.Forms.Padding(2);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.Size = new System.Drawing.Size(686, 81);
            this.tb_console.TabIndex = 0;
            // 
            // tb_pbid
            // 
            this.tb_pbid.Location = new System.Drawing.Point(98, 3);
            this.tb_pbid.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pbid.Name = "tb_pbid";
            this.tb_pbid.Size = new System.Drawing.Size(117, 20);
            this.tb_pbid.TabIndex = 1;
            // 
            // lb_pbid
            // 
            this.lb_pbid.AutoSize = true;
            this.lb_pbid.Location = new System.Drawing.Point(7, 6);
            this.lb_pbid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_pbid.Name = "lb_pbid";
            this.lb_pbid.Size = new System.Drawing.Size(52, 13);
            this.lb_pbid.TabIndex = 2;
            this.lb_pbid.Text = "Potbot ID";
            // 
            // lb_gps_info
            // 
            this.lb_gps_info.Location = new System.Drawing.Point(343, 9);
            this.lb_gps_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_gps_info.Name = "lb_gps_info";
            this.lb_gps_info.Size = new System.Drawing.Size(326, 58);
            this.lb_gps_info.TabIndex = 5;
            this.lb_gps_info.Text = "Power up the board with the battery (NO USB CONNECTION). If LEDs flash:\r\n3 times " +
    "GPS COM is fine\r\n5 times, COM or Power Up are wrong";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_gps_fail);
            this.groupBox1.Controls.Add(this.radio_gps_ok);
            this.groupBox1.Controls.Add(this.lb_gps_info);
            this.groupBox1.Location = new System.Drawing.Point(9, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(686, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS";
            // 
            // radio_gps_fail
            // 
            this.radio_gps_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_gps_fail.AutoCheck = false;
            this.radio_gps_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_gps_fail.Location = new System.Drawing.Point(247, 17);
            this.radio_gps_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_gps_fail.Name = "radio_gps_fail";
            this.radio_gps_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_gps_fail.TabIndex = 11;
            this.radio_gps_fail.TabStop = true;
            this.radio_gps_fail.Text = "Fail";
            this.radio_gps_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_gps_fail.UseVisualStyleBackColor = true;
            this.radio_gps_fail.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radio_gps_ok
            // 
            this.radio_gps_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_gps_ok.AutoCheck = false;
            this.radio_gps_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_gps_ok.Location = new System.Drawing.Point(122, 17);
            this.radio_gps_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_gps_ok.Name = "radio_gps_ok";
            this.radio_gps_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_gps_ok.TabIndex = 10;
            this.radio_gps_ok.TabStop = true;
            this.radio_gps_ok.Text = "OK";
            this.radio_gps_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_gps_ok.UseVisualStyleBackColor = true;
            this.radio_gps_ok.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 93);
            this.label1.TabIndex = 12;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // but_connect
            // 
            this.but_connect.Location = new System.Drawing.Point(9, 193);
            this.but_connect.Margin = new System.Windows.Forms.Padding(2);
            this.but_connect.Name = "but_connect";
            this.but_connect.Size = new System.Drawing.Size(98, 32);
            this.but_connect.TabIndex = 13;
            this.but_connect.Text = "Detect POTBot";
            this.but_connect.UseVisualStyleBackColor = true;
            this.but_connect.Click += new System.EventHandler(this.but_connect_Click);
            // 
            // lab_detected
            // 
            this.lab_detected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detected.Location = new System.Drawing.Point(125, 200);
            this.lab_detected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_detected.Name = "lab_detected";
            this.lab_detected.Size = new System.Drawing.Size(553, 24);
            this.lab_detected.TabIndex = 12;
            this.lab_detected.Text = "Power up the board with the battery. If LEDs flash 3 times GPS COM is fine, if th" +
    "ey flash 5 times, COM or Power Up are wrong";
            // 
            // tim_time_out
            // 
            this.tim_time_out.Tick += new System.EventHandler(this.time_out_Tick);
            // 
            // progbar_timeout
            // 
            this.progbar_timeout.Location = new System.Drawing.Point(9, 828);
            this.progbar_timeout.Margin = new System.Windows.Forms.Padding(2);
            this.progbar_timeout.Name = "progbar_timeout";
            this.progbar_timeout.Size = new System.Drawing.Size(686, 32);
            this.progbar_timeout.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progbar_timeout.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.wet_swiw_test_but);
            this.groupBox4.Controls.Add(this.radio_wsiw_fail);
            this.groupBox4.Controls.Add(this.radio_wsiw_ok);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(9, 231);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(686, 69);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WetSwitch shorted (in water)";
            this.groupBox4.Visible = false;
            // 
            // wet_swiw_test_but
            // 
            this.wet_swiw_test_but.Location = new System.Drawing.Point(339, 20);
            this.wet_swiw_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.wet_swiw_test_but.Name = "wet_swiw_test_but";
            this.wet_swiw_test_but.Size = new System.Drawing.Size(75, 41);
            this.wet_swiw_test_but.TabIndex = 22;
            this.wet_swiw_test_but.Text = "Test";
            this.wet_swiw_test_but.UseVisualStyleBackColor = true;
            this.wet_swiw_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_wsiw_fail
            // 
            this.radio_wsiw_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_wsiw_fail.AutoCheck = false;
            this.radio_wsiw_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_wsiw_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_wsiw_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_wsiw_fail.Name = "radio_wsiw_fail";
            this.radio_wsiw_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_wsiw_fail.TabIndex = 35;
            this.radio_wsiw_fail.TabStop = true;
            this.radio_wsiw_fail.Text = "Fail";
            this.radio_wsiw_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_wsiw_fail.UseVisualStyleBackColor = true;
            // 
            // radio_wsiw_ok
            // 
            this.radio_wsiw_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_wsiw_ok.AutoCheck = false;
            this.radio_wsiw_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_wsiw_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_wsiw_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_wsiw_ok.Name = "radio_wsiw_ok";
            this.radio_wsiw_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_wsiw_ok.TabIndex = 34;
            this.radio_wsiw_ok.TabStop = true;
            this.radio_wsiw_ok.Text = "OK";
            this.radio_wsiw_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_wsiw_ok.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Press \"Test\", wait for OK or Fail indicator";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wet_swia_test_but);
            this.groupBox3.Controls.Add(this.radio_wsia_fail);
            this.groupBox3.Controls.Add(this.radio_wsia_ok);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(9, 307);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(686, 69);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "WetSwitch shorted (in air)";
            this.groupBox3.Visible = false;
            // 
            // wet_swia_test_but
            // 
            this.wet_swia_test_but.Location = new System.Drawing.Point(339, 20);
            this.wet_swia_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.wet_swia_test_but.Name = "wet_swia_test_but";
            this.wet_swia_test_but.Size = new System.Drawing.Size(75, 41);
            this.wet_swia_test_but.TabIndex = 21;
            this.wet_swia_test_but.Text = "Test";
            this.wet_swia_test_but.UseVisualStyleBackColor = true;
            this.wet_swia_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_wsia_fail
            // 
            this.radio_wsia_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_wsia_fail.AutoCheck = false;
            this.radio_wsia_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_wsia_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_wsia_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_wsia_fail.Name = "radio_wsia_fail";
            this.radio_wsia_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_wsia_fail.TabIndex = 33;
            this.radio_wsia_fail.TabStop = true;
            this.radio_wsia_fail.Text = "Fail";
            this.radio_wsia_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_wsia_fail.UseVisualStyleBackColor = true;
            // 
            // radio_wsia_ok
            // 
            this.radio_wsia_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_wsia_ok.AutoCheck = false;
            this.radio_wsia_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_wsia_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_wsia_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_wsia_ok.Name = "radio_wsia_ok";
            this.radio_wsia_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_wsia_ok.TabIndex = 32;
            this.radio_wsia_ok.TabStop = true;
            this.radio_wsia_ok.Text = "OK";
            this.radio_wsia_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_wsia_ok.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "Disconnect shorted jumper from WET_SW\r\nPress \"Test\", wait for OK or Fail indicato" +
    "r\r\nAUTOMATIC TESTS FROM HERE";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cam_test_but);
            this.groupBox2.Controls.Add(this.radio_cam_fail);
            this.groupBox2.Controls.Add(this.radio_cam_ok);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 597);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(686, 69);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera";
            this.groupBox2.Visible = false;
            // 
            // cam_test_but
            // 
            this.cam_test_but.Location = new System.Drawing.Point(339, 20);
            this.cam_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.cam_test_but.Name = "cam_test_but";
            this.cam_test_but.Size = new System.Drawing.Size(75, 41);
            this.cam_test_but.TabIndex = 20;
            this.cam_test_but.Text = "Test";
            this.cam_test_but.UseVisualStyleBackColor = true;
            this.cam_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_cam_fail
            // 
            this.radio_cam_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_cam_fail.AutoCheck = false;
            this.radio_cam_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_cam_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_cam_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cam_fail.Name = "radio_cam_fail";
            this.radio_cam_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_cam_fail.TabIndex = 31;
            this.radio_cam_fail.TabStop = true;
            this.radio_cam_fail.Text = "Fail";
            this.radio_cam_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_cam_fail.UseVisualStyleBackColor = true;
            this.radio_cam_fail.Click += new System.EventHandler(this.cam_radioButton);
            // 
            // radio_cam_ok
            // 
            this.radio_cam_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_cam_ok.AutoCheck = false;
            this.radio_cam_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_cam_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_cam_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_cam_ok.Name = "radio_cam_ok";
            this.radio_cam_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_cam_ok.TabIndex = 30;
            this.radio_cam_ok.TabStop = true;
            this.radio_cam_ok.Text = "OK";
            this.radio_cam_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_cam_ok.UseVisualStyleBackColor = true;
            this.radio_cam_ok.Click += new System.EventHandler(this.cam_radioButton);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Press \"Test\", the camera should turn on (blinking LEDs on Camera) for about 5 sec" +
    "onds. \r\nClick OK or Fail after the Camera goes Off";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.temp_test_but);
            this.groupBox5.Controls.Add(this.radio_temp_fail);
            this.groupBox5.Controls.Add(this.radio_temp_ok);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(10, 380);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(686, 69);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Temperature";
            this.groupBox5.Visible = false;
            // 
            // temp_test_but
            // 
            this.temp_test_but.Location = new System.Drawing.Point(339, 20);
            this.temp_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.temp_test_but.Name = "temp_test_but";
            this.temp_test_but.Size = new System.Drawing.Size(75, 41);
            this.temp_test_but.TabIndex = 23;
            this.temp_test_but.Text = "Test";
            this.temp_test_but.UseVisualStyleBackColor = true;
            this.temp_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_temp_fail
            // 
            this.radio_temp_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_temp_fail.AutoCheck = false;
            this.radio_temp_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_temp_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_temp_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_temp_fail.Name = "radio_temp_fail";
            this.radio_temp_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_temp_fail.TabIndex = 37;
            this.radio_temp_fail.TabStop = true;
            this.radio_temp_fail.Text = "Fail";
            this.radio_temp_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_temp_fail.UseVisualStyleBackColor = true;
            // 
            // radio_temp_ok
            // 
            this.radio_temp_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_temp_ok.AutoCheck = false;
            this.radio_temp_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_temp_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_temp_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_temp_ok.Name = "radio_temp_ok";
            this.radio_temp_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_temp_ok.TabIndex = 36;
            this.radio_temp_ok.TabStop = true;
            this.radio_temp_ok.Text = "OK";
            this.radio_temp_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_temp_ok.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Press \"Test\", wait for OK or Fail indicator";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comp_test_but);
            this.groupBox6.Controls.Add(this.radio_comp_fail);
            this.groupBox6.Controls.Add(this.radio_comp_ok);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(9, 453);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(686, 69);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compass";
            this.groupBox6.Visible = false;
            // 
            // comp_test_but
            // 
            this.comp_test_but.Location = new System.Drawing.Point(339, 20);
            this.comp_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.comp_test_but.Name = "comp_test_but";
            this.comp_test_but.Size = new System.Drawing.Size(75, 41);
            this.comp_test_but.TabIndex = 24;
            this.comp_test_but.Text = "Test";
            this.comp_test_but.UseVisualStyleBackColor = true;
            this.comp_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_comp_fail
            // 
            this.radio_comp_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_comp_fail.AutoCheck = false;
            this.radio_comp_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_comp_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_comp_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_comp_fail.Name = "radio_comp_fail";
            this.radio_comp_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_comp_fail.TabIndex = 39;
            this.radio_comp_fail.TabStop = true;
            this.radio_comp_fail.Text = "Fail";
            this.radio_comp_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_comp_fail.UseVisualStyleBackColor = true;
            // 
            // radio_comp_ok
            // 
            this.radio_comp_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_comp_ok.AutoCheck = false;
            this.radio_comp_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_comp_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_comp_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_comp_ok.Name = "radio_comp_ok";
            this.radio_comp_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_comp_ok.TabIndex = 38;
            this.radio_comp_ok.TabStop = true;
            this.radio_comp_ok.Text = "OK";
            this.radio_comp_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_comp_ok.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Press \"Test\", wait for OK or Fail indicator";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.olog_test_but);
            this.groupBox7.Controls.Add(this.radio_olog_fail);
            this.groupBox7.Controls.Add(this.radio_olog_ok);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(9, 526);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(686, 69);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Openlog";
            this.groupBox7.Visible = false;
            // 
            // olog_test_but
            // 
            this.olog_test_but.Location = new System.Drawing.Point(339, 20);
            this.olog_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.olog_test_but.Name = "olog_test_but";
            this.olog_test_but.Size = new System.Drawing.Size(75, 41);
            this.olog_test_but.TabIndex = 25;
            this.olog_test_but.Text = "Test";
            this.olog_test_but.UseVisualStyleBackColor = true;
            this.olog_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_olog_fail
            // 
            this.radio_olog_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_olog_fail.AutoCheck = false;
            this.radio_olog_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_olog_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_olog_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_olog_fail.Name = "radio_olog_fail";
            this.radio_olog_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_olog_fail.TabIndex = 41;
            this.radio_olog_fail.TabStop = true;
            this.radio_olog_fail.Text = "Fail";
            this.radio_olog_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_olog_fail.UseVisualStyleBackColor = true;
            // 
            // radio_olog_ok
            // 
            this.radio_olog_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_olog_ok.AutoCheck = false;
            this.radio_olog_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_olog_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_olog_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_olog_ok.Name = "radio_olog_ok";
            this.radio_olog_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_olog_ok.TabIndex = 40;
            this.radio_olog_ok.TabStop = true;
            this.radio_olog_ok.Text = "OK";
            this.radio_olog_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_olog_ok.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Press \"Test\", wait for OK or Fail indicator";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.camf_test_but);
            this.groupBox8.Controls.Add(this.radio_camf_fail);
            this.groupBox8.Controls.Add(this.radio_camf_ok);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(9, 670);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(686, 69);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Camera files";
            this.groupBox8.Visible = false;
            // 
            // camf_test_but
            // 
            this.camf_test_but.Location = new System.Drawing.Point(339, 20);
            this.camf_test_but.Margin = new System.Windows.Forms.Padding(2);
            this.camf_test_but.Name = "camf_test_but";
            this.camf_test_but.Size = new System.Drawing.Size(75, 41);
            this.camf_test_but.TabIndex = 26;
            this.camf_test_but.Text = "Test";
            this.camf_test_but.UseVisualStyleBackColor = true;
            this.camf_test_but.Click += new System.EventHandler(this.test_but_Click);
            // 
            // radio_camf_fail
            // 
            this.radio_camf_fail.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_camf_fail.AutoCheck = false;
            this.radio_camf_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radio_camf_fail.Location = new System.Drawing.Point(577, 20);
            this.radio_camf_fail.Margin = new System.Windows.Forms.Padding(2);
            this.radio_camf_fail.Name = "radio_camf_fail";
            this.radio_camf_fail.Size = new System.Drawing.Size(75, 41);
            this.radio_camf_fail.TabIndex = 43;
            this.radio_camf_fail.TabStop = true;
            this.radio_camf_fail.Text = "Fail";
            this.radio_camf_fail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_camf_fail.UseVisualStyleBackColor = true;
            // 
            // radio_camf_ok
            // 
            this.radio_camf_ok.Appearance = System.Windows.Forms.Appearance.Button;
            this.radio_camf_ok.AutoCheck = false;
            this.radio_camf_ok.ForeColor = System.Drawing.Color.Green;
            this.radio_camf_ok.Location = new System.Drawing.Point(452, 20);
            this.radio_camf_ok.Margin = new System.Windows.Forms.Padding(2);
            this.radio_camf_ok.Name = "radio_camf_ok";
            this.radio_camf_ok.Size = new System.Drawing.Size(75, 41);
            this.radio_camf_ok.TabIndex = 42;
            this.radio_camf_ok.TabStop = true;
            this.radio_camf_ok.Text = "OK";
            this.radio_camf_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_camf_ok.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Press \"Test\", wait for OK or Fail indicator\r\nIt will search for the DCIM folder i" +
    "n the USB";
            // 
            // auto_check
            // 
            this.auto_check.Enabled = true;
            this.auto_check.Tick += new System.EventHandler(this.auto_check_Tick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(-4, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(711, 302);
            this.label9.TabIndex = 21;
            this.label9.Visible = false;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Potbot_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 857);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progbar_timeout);
            this.Controls.Add(this.lab_detected);
            this.Controls.Add(this.but_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_pbid);
            this.Controls.Add(this.tb_pbid);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Potbot_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Potbot_test_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_console;
        private System.Windows.Forms.TextBox tb_pbid;
        private System.Windows.Forms.Label lb_pbid;
        private System.Windows.Forms.Label lb_gps_info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_gps_fail;
        private System.Windows.Forms.RadioButton radio_gps_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_connect;
        private System.Windows.Forms.Label lab_detected;
        private System.Windows.Forms.Timer tim_time_out;
        private System.Windows.Forms.ProgressBar progbar_timeout;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button wet_swiw_test_but;
        private System.Windows.Forms.RadioButton radio_wsiw_fail;
        private System.Windows.Forms.RadioButton radio_wsiw_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button wet_swia_test_but;
        private System.Windows.Forms.RadioButton radio_wsia_fail;
        private System.Windows.Forms.RadioButton radio_wsia_ok;
        private System.Windows.Forms.Label label3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cam_test_but;
        private System.Windows.Forms.RadioButton radio_cam_fail;
        private System.Windows.Forms.RadioButton radio_cam_ok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button temp_test_but;
        private System.Windows.Forms.RadioButton radio_temp_fail;
        private System.Windows.Forms.RadioButton radio_temp_ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button camf_test_but;
        private System.Windows.Forms.RadioButton radio_camf_fail;
        private System.Windows.Forms.RadioButton radio_camf_ok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button olog_test_but;
        private System.Windows.Forms.RadioButton radio_olog_fail;
        private System.Windows.Forms.RadioButton radio_olog_ok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button comp_test_but;
        private System.Windows.Forms.RadioButton radio_comp_fail;
        private System.Windows.Forms.RadioButton radio_comp_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer auto_check;
        private System.Windows.Forms.Label label9;
    }
}

