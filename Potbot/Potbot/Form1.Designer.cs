namespace Potbot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Text_console = new System.Windows.Forms.TextBox();
            this.timer_read_pot = new System.Windows.Forms.Timer(this.components);
            this.label_P6 = new System.Windows.Forms.Label();
            this.label_P5 = new System.Windows.Forms.Label();
            this.label_P4 = new System.Windows.Forms.Label();
            this.label_P3 = new System.Windows.Forms.Label();
            this.label_P2 = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.seq_all_in_one = new System.Windows.Forms.Timer(this.components);
            this.groupBox_pot_set = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_P1_hrs = new System.Windows.Forms.CheckBox();
            this.label_P10 = new System.Windows.Forms.Label();
            this.label_P11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button_read_pot = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label_P12 = new System.Windows.Forms.Label();
            this.button_write_pot = new System.Windows.Forms.Button();
            this.button_rest_dft = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label_P9 = new System.Windows.Forms.Label();
            this.label_P8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_P7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkbox_d_log = new System.Windows.Forms.CheckBox();
            this.checkbox_w_log = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBox_loc_fol = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Download_all = new System.Windows.Forms.Button();
            this.button_loc_fol = new System.Windows.Forms.Button();
            this.checkbox_w_vid = new System.Windows.Forms.CheckBox();
            this.checkbox_d_vid = new System.Windows.Forms.CheckBox();
            this.label_P15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label_cam_back = new System.Windows.Forms.Label();
            this.Log_back = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button9 = new System.Windows.Forms.Button();
            this.Save_dafault = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.status_chk = new System.Windows.Forms.Timer(this.components);
            this.text_notification = new System.Windows.Forms.RichTextBox();
            this.status_timeout = new System.Windows.Forms.Timer(this.components);
            this.progressBar_cam = new System.Windows.Forms.ProgressBar();
            this.button_reconn = new System.Windows.Forms.Button();
            this.picBox_flo_dia = new System.Windows.Forms.PictureBox();
            this.but_firmware = new System.Windows.Forms.Button();
            this.save_default_but = new System.Windows.Forms.Button();
            this.l_version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_pot_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loc_fol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_flo_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // Text_console
            // 
            this.Text_console.Location = new System.Drawing.Point(7, 600);
            this.Text_console.Margin = new System.Windows.Forms.Padding(2);
            this.Text_console.Multiline = true;
            this.Text_console.Name = "Text_console";
            this.Text_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_console.Size = new System.Drawing.Size(813, 127);
            this.Text_console.TabIndex = 0;
            // 
            // timer_read_pot
            // 
            this.timer_read_pot.Tick += new System.EventHandler(this.timer_read_pot_Tick);
            // 
            // label_P6
            // 
            this.label_P6.AutoSize = true;
            this.label_P6.Location = new System.Drawing.Point(242, 75);
            this.label_P6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P6.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P6.Name = "label_P6";
            this.label_P6.Size = new System.Drawing.Size(132, 26);
            this.label_P6.TabIndex = 0;
            this.label_P6.Text = "(P6) Pre-deploy Threshold Angle:";
            this.toolTip1.SetToolTip(this.label_P6, resources.GetString("label_P6.ToolTip"));
            // 
            // label_P5
            // 
            this.label_P5.AutoSize = true;
            this.label_P5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_P5.Location = new System.Drawing.Point(242, 15);
            this.label_P5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P5.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P5.Name = "label_P5";
            this.label_P5.Size = new System.Drawing.Size(143, 13);
            this.label_P5.TabIndex = 0;
            this.label_P5.Text = "(P5) Retrieved GPS run time:";
            this.toolTip1.SetToolTip(this.label_P5, "If POTBot has changed state from wet (E4) to dry (E5) it will run the GPS for P5 " +
        "before it moves to state E6.\r\nTime is in seconds.");
            // 
            // label_P4
            // 
            this.label_P4.AutoSize = true;
            this.label_P4.Location = new System.Drawing.Point(4, 208);
            this.label_P4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P4.Name = "label_P4";
            this.label_P4.Size = new System.Drawing.Size(130, 13);
            this.label_P4.TabIndex = 0;
            this.label_P4.Text = "(P4) Retrieval Video Time:";
            this.toolTip1.SetToolTip(this.label_P4, "If POTBot is wet (E3) and angle P3 is breached (E4), it will video for time P4.\r\n" +
        "Time is in seconds.\r\n");
            // 
            // label_P3
            // 
            this.label_P3.AutoSize = true;
            this.label_P3.Location = new System.Drawing.Point(4, 144);
            this.label_P3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(127, 26);
            this.label_P3.TabIndex = 0;
            this.label_P3.Text = "(P3) In Water Orientation Threshold:";
            this.toolTip1.SetToolTip(this.label_P3, "If POTBot is wet (E3) this is the angle (P3) at which it will change state to E4 " +
        "and record video for time P4.\r\nAngle in Degrees (0 is flat, 90 POTBot is standin" +
        "g on its head, camera pointing down).");
            this.label_P3.Click += new System.EventHandler(this.label_P3_Click);
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_P2.Location = new System.Drawing.Point(4, 99);
            this.label_P2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(136, 26);
            this.label_P2.TabIndex = 0;
            this.label_P2.Text = "(P2) In Water Temperature time lag:";
            this.toolTip1.SetToolTip(this.label_P2, "If POTBot is wet (E3) its will wait P2 between subsequent temperature recordings." +
        "\r\nTime is in seconds.");
            this.label_P2.Click += new System.EventHandler(this.label_P2_Click);
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_P1.Location = new System.Drawing.Point(4, 22);
            this.label_P1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(121, 13);
            this.label_P1.TabIndex = 0;
            this.label_P1.Text = "(P1) Deploy Video Time:";
            this.toolTip1.SetToolTip(this.label_P1, "If POTBot becomes wet it will video for P1 and its state will move to E2.\r\nTime i" +
        "s in seconds.");
            // 
            // seq_all_in_one
            // 
            this.seq_all_in_one.Interval = 300;
            this.seq_all_in_one.Tick += new System.EventHandler(this.seq_all_in_one_Tick);
            // 
            // groupBox_pot_set
            // 
            this.groupBox_pot_set.Controls.Add(this.label1);
            this.groupBox_pot_set.Controls.Add(this.chk_P1_hrs);
            this.groupBox_pot_set.Controls.Add(this.label_P10);
            this.groupBox_pot_set.Controls.Add(this.label_P11);
            this.groupBox_pot_set.Controls.Add(this.pictureBox2);
            this.groupBox_pot_set.Controls.Add(this.textBox12);
            this.groupBox_pot_set.Controls.Add(this.textBox11);
            this.groupBox_pot_set.Controls.Add(this.button_read_pot);
            this.groupBox_pot_set.Controls.Add(this.textBox10);
            this.groupBox_pot_set.Controls.Add(this.label_P12);
            this.groupBox_pot_set.Controls.Add(this.button_write_pot);
            this.groupBox_pot_set.Controls.Add(this.button_rest_dft);
            this.groupBox_pot_set.Controls.Add(this.textBox9);
            this.groupBox_pot_set.Controls.Add(this.textBox8);
            this.groupBox_pot_set.Controls.Add(this.label_P9);
            this.groupBox_pot_set.Controls.Add(this.label_P8);
            this.groupBox_pot_set.Controls.Add(this.textBox4);
            this.groupBox_pot_set.Controls.Add(this.textBox7);
            this.groupBox_pot_set.Controls.Add(this.textBox6);
            this.groupBox_pot_set.Controls.Add(this.textBox5);
            this.groupBox_pot_set.Controls.Add(this.textBox3);
            this.groupBox_pot_set.Controls.Add(this.textBox2);
            this.groupBox_pot_set.Controls.Add(this.textBox1);
            this.groupBox_pot_set.Controls.Add(this.label_P7);
            this.groupBox_pot_set.Controls.Add(this.label_P6);
            this.groupBox_pot_set.Controls.Add(this.label_P5);
            this.groupBox_pot_set.Controls.Add(this.label_P1);
            this.groupBox_pot_set.Controls.Add(this.label_P4);
            this.groupBox_pot_set.Controls.Add(this.label_P2);
            this.groupBox_pot_set.Controls.Add(this.label_P3);
            this.groupBox_pot_set.Location = new System.Drawing.Point(7, 63);
            this.groupBox_pot_set.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_pot_set.Name = "groupBox_pot_set";
            this.groupBox_pot_set.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_pot_set.Size = new System.Drawing.Size(489, 310);
            this.groupBox_pot_set.TabIndex = 4;
            this.groupBox_pot_set.TabStop = false;
            this.groupBox_pot_set.Text = "Potbot Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "hrs";
            this.toolTip1.SetToolTip(this.label1, "If POTBot has changed state from wet (E4) to dry (E5) it will run the GPS for P5 " +
        "before it moves to state E6.\r\nTime is in seconds.");
            // 
            // chk_P1_hrs
            // 
            this.chk_P1_hrs.AutoSize = true;
            this.chk_P1_hrs.BackColor = System.Drawing.SystemColors.Control;
            this.chk_P1_hrs.Location = new System.Drawing.Point(209, 25);
            this.chk_P1_hrs.Margin = new System.Windows.Forms.Padding(2);
            this.chk_P1_hrs.Name = "chk_P1_hrs";
            this.chk_P1_hrs.Size = new System.Drawing.Size(15, 14);
            this.chk_P1_hrs.TabIndex = 34;
            this.chk_P1_hrs.UseVisualStyleBackColor = false;
            // 
            // label_P10
            // 
            this.label_P10.AutoSize = true;
            this.label_P10.Location = new System.Drawing.Point(242, 45);
            this.label_P10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P10.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P10.Name = "label_P10";
            this.label_P10.Size = new System.Drawing.Size(146, 26);
            this.label_P10.TabIndex = 32;
            this.label_P10.Text = "(P10) Retrieved GPS logging lag:";
            this.toolTip1.SetToolTip(this.label_P10, "Time between POTBot blinking its state.\r\nTime is in seconds.");
            // 
            // label_P11
            // 
            this.label_P11.AutoSize = true;
            this.label_P11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_P11.Location = new System.Drawing.Point(4, 176);
            this.label_P11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P11.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P11.Name = "label_P11";
            this.label_P11.Size = new System.Drawing.Size(135, 26);
            this.label_P11.TabIndex = 31;
            this.label_P11.Text = "(P11) In Water Video Time (multiple videos):";
            this.toolTip1.SetToolTip(this.label_P11, "If POTBot is wet (E3) and angle P3 is breached (E4), it will video for time P4.\r\n" +
        "Time is in seconds.\r\n");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(873, 38);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 232);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(151, 57);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 20);
            this.textBox12.TabIndex = 2;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(151, 172);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 5;
            // 
            // button_read_pot
            // 
            this.button_read_pot.Location = new System.Drawing.Point(0, 232);
            this.button_read_pot.Margin = new System.Windows.Forms.Padding(2);
            this.button_read_pot.Name = "button_read_pot";
            this.button_read_pot.Size = new System.Drawing.Size(134, 36);
            this.button_read_pot.TabIndex = 27;
            this.button_read_pot.Text = "Read Settings from POTBot";
            this.button_read_pot.UseVisualStyleBackColor = true;
            this.button_read_pot.Click += new System.EventHandler(this.button_read_pot_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(394, 41);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 20);
            this.textBox10.TabIndex = 8;
            // 
            // label_P12
            // 
            this.label_P12.AutoSize = true;
            this.label_P12.Location = new System.Drawing.Point(4, 54);
            this.label_P12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P12.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P12.Name = "label_P12";
            this.label_P12.Size = new System.Drawing.Size(147, 26);
            this.label_P12.TabIndex = 25;
            this.label_P12.Text = "(P12) Deploy Orientation time lag:";
            this.toolTip1.SetToolTip(this.label_P12, "Sleep time between consecutive GPS logs");
            this.label_P12.Click += new System.EventHandler(this.label_P10_Click);
            // 
            // button_write_pot
            // 
            this.button_write_pot.Location = new System.Drawing.Point(154, 232);
            this.button_write_pot.Margin = new System.Windows.Forms.Padding(2);
            this.button_write_pot.Name = "button_write_pot";
            this.button_write_pot.Size = new System.Drawing.Size(134, 36);
            this.button_write_pot.TabIndex = 13;
            this.button_write_pot.Text = "Write Settings to POTBot";
            this.button_write_pot.UseVisualStyleBackColor = true;
            this.button_write_pot.Click += new System.EventHandler(this.button_write_pot_Click);
            // 
            // button_rest_dft
            // 
            this.button_rest_dft.Location = new System.Drawing.Point(328, 232);
            this.button_rest_dft.Margin = new System.Windows.Forms.Padding(2);
            this.button_rest_dft.Name = "button_rest_dft";
            this.button_rest_dft.Size = new System.Drawing.Size(134, 36);
            this.button_rest_dft.TabIndex = 23;
            this.button_rest_dft.Text = "Restore Default Settings";
            this.button_rest_dft.UseVisualStyleBackColor = true;
            this.button_rest_dft.Click += new System.EventHandler(this.button_rest_dft_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(394, 204);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(394, 121);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label_P9
            // 
            this.label_P9.AutoSize = true;
            this.label_P9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_P9.Location = new System.Drawing.Point(242, 208);
            this.label_P9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P9.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P9.Name = "label_P9";
            this.label_P9.Size = new System.Drawing.Size(101, 13);
            this.label_P9.TabIndex = 14;
            this.label_P9.Text = "(P9) LED lag states:";
            this.toolTip1.SetToolTip(this.label_P9, "Time between POTBot blinking its state.\r\nTime is in seconds.");
            this.label_P9.Click += new System.EventHandler(this.label_P9_Click);
            // 
            // label_P8
            // 
            this.label_P8.AutoSize = true;
            this.label_P8.Location = new System.Drawing.Point(242, 118);
            this.label_P8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P8.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P8.Name = "label_P8";
            this.label_P8.Size = new System.Drawing.Size(145, 26);
            this.label_P8.TabIndex = 12;
            this.label_P8.Text = "(P8) Pre-deploy Lag to return to E1:";
            this.toolTip1.SetToolTip(this.label_P8, "When POTbot is in state E6 it monitors for water and angle.  After time P8 it wil" +
        "l return to state E1 and only test for water.  This save power.\r\nTime is in seco" +
        "nds.");
            this.label_P8.Click += new System.EventHandler(this.label_P8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 204);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(394, 164);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(394, 78);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(394, 11);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 140);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 102);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBox1, "Video Time in seconds asd fasf asdf asdf das fsaf asdf sadf das fasd");
            // 
            // label_P7
            // 
            this.label_P7.AutoSize = true;
            this.label_P7.Location = new System.Drawing.Point(242, 161);
            this.label_P7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P7.MaximumSize = new System.Drawing.Size(150, 0);
            this.label_P7.Name = "label_P7";
            this.label_P7.Size = new System.Drawing.Size(149, 26);
            this.label_P7.TabIndex = 1;
            this.label_P7.Text = "(P7) Pre-Deploy GPS run time after E6:";
            this.toolTip1.SetToolTip(this.label_P7, "The GPS run time when POTBot is in state E7.\r\nTime is in seconds.\r\n ");
            this.label_P7.Click += new System.EventHandler(this.label_P7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(625, 327);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Open Camera Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkbox_d_log
            // 
            this.checkbox_d_log.AutoSize = true;
            this.checkbox_d_log.BackColor = System.Drawing.Color.Khaki;
            this.checkbox_d_log.Location = new System.Drawing.Point(14, 101);
            this.checkbox_d_log.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_d_log.Name = "checkbox_d_log";
            this.checkbox_d_log.Size = new System.Drawing.Size(121, 17);
            this.checkbox_d_log.TabIndex = 24;
            this.checkbox_d_log.Text = "Download Data Log";
            this.checkbox_d_log.UseVisualStyleBackColor = false;
            // 
            // checkbox_w_log
            // 
            this.checkbox_w_log.AutoSize = true;
            this.checkbox_w_log.BackColor = System.Drawing.Color.Khaki;
            this.checkbox_w_log.Location = new System.Drawing.Point(165, 101);
            this.checkbox_w_log.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_w_log.Name = "checkbox_w_log";
            this.checkbox_w_log.Size = new System.Drawing.Size(98, 17);
            this.checkbox_w_log.TabIndex = 25;
            this.checkbox_w_log.Text = "Wipe Data Log";
            this.checkbox_w_log.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBox_loc_fol);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Download_all);
            this.groupBox2.Controls.Add(this.button_loc_fol);
            this.groupBox2.Controls.Add(this.checkbox_w_log);
            this.groupBox2.Controls.Add(this.checkbox_d_log);
            this.groupBox2.Controls.Add(this.checkbox_w_vid);
            this.groupBox2.Controls.Add(this.checkbox_d_vid);
            this.groupBox2.Controls.Add(this.label_P15);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label_cam_back);
            this.groupBox2.Controls.Add(this.Log_back);
            this.groupBox2.Location = new System.Drawing.Point(512, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(354, 231);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // picBox_loc_fol
            // 
            this.picBox_loc_fol.Image = global::Potbot.Properties.Resources.icons8_folder_16;
            this.picBox_loc_fol.Location = new System.Drawing.Point(247, 27);
            this.picBox_loc_fol.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_loc_fol.Name = "picBox_loc_fol";
            this.picBox_loc_fol.Size = new System.Drawing.Size(20, 20);
            this.picBox_loc_fol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_loc_fol.TabIndex = 32;
            this.picBox_loc_fol.TabStop = false;
            this.picBox_loc_fol.Click += new System.EventHandler(this.picBox_loc_fol_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Open folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Download_all
            // 
            this.Download_all.Location = new System.Drawing.Point(14, 177);
            this.Download_all.Margin = new System.Windows.Forms.Padding(2);
            this.Download_all.Name = "Download_all";
            this.Download_all.Size = new System.Drawing.Size(147, 31);
            this.Download_all.TabIndex = 29;
            this.Download_all.Text = "DOWNLOAD DATA";
            this.Download_all.UseVisualStyleBackColor = true;
            this.Download_all.Click += new System.EventHandler(this.Download_all_Click);
            // 
            // button_loc_fol
            // 
            this.button_loc_fol.Location = new System.Drawing.Point(92, 24);
            this.button_loc_fol.Margin = new System.Windows.Forms.Padding(2);
            this.button_loc_fol.Name = "button_loc_fol";
            this.button_loc_fol.Size = new System.Drawing.Size(178, 27);
            this.button_loc_fol.TabIndex = 29;
            this.button_loc_fol.Text = "C:/Potbot/";
            this.button_loc_fol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_loc_fol.UseVisualStyleBackColor = true;
            this.button_loc_fol.Click += new System.EventHandler(this.button_loc_fol_Click);
            // 
            // checkbox_w_vid
            // 
            this.checkbox_w_vid.AutoSize = true;
            this.checkbox_w_vid.BackColor = System.Drawing.Color.PaleGreen;
            this.checkbox_w_vid.Location = new System.Drawing.Point(165, 63);
            this.checkbox_w_vid.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_w_vid.Name = "checkbox_w_vid";
            this.checkbox_w_vid.Size = new System.Drawing.Size(90, 17);
            this.checkbox_w_vid.TabIndex = 28;
            this.checkbox_w_vid.Text = "Wipe Camera";
            this.checkbox_w_vid.UseVisualStyleBackColor = false;
            // 
            // checkbox_d_vid
            // 
            this.checkbox_d_vid.AutoSize = true;
            this.checkbox_d_vid.BackColor = System.Drawing.Color.PaleGreen;
            this.checkbox_d_vid.Location = new System.Drawing.Point(14, 63);
            this.checkbox_d_vid.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_d_vid.Name = "checkbox_d_vid";
            this.checkbox_d_vid.Size = new System.Drawing.Size(104, 17);
            this.checkbox_d_vid.TabIndex = 27;
            this.checkbox_d_vid.Text = "Download Video";
            this.checkbox_d_vid.UseVisualStyleBackColor = false;
            // 
            // label_P15
            // 
            this.label_P15.AutoSize = true;
            this.label_P15.Location = new System.Drawing.Point(11, 30);
            this.label_P15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_P15.Name = "label_P15";
            this.label_P15.Size = new System.Drawing.Size(68, 13);
            this.label_P15.TabIndex = 26;
            this.label_P15.Text = "Local Folder:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 177);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "Switch to Camera";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label_cam_back
            // 
            this.label_cam_back.AutoSize = true;
            this.label_cam_back.BackColor = System.Drawing.Color.PaleGreen;
            this.label_cam_back.Location = new System.Drawing.Point(9, 57);
            this.label_cam_back.MinimumSize = new System.Drawing.Size(300, 30);
            this.label_cam_back.Name = "label_cam_back";
            this.label_cam_back.Size = new System.Drawing.Size(300, 30);
            this.label_cam_back.TabIndex = 32;
            // 
            // Log_back
            // 
            this.Log_back.AutoSize = true;
            this.Log_back.BackColor = System.Drawing.Color.Khaki;
            this.Log_back.Location = new System.Drawing.Point(7, 94);
            this.Log_back.MinimumSize = new System.Drawing.Size(300, 30);
            this.Log_back.Name = "Log_back";
            this.Log_back.Size = new System.Drawing.Size(300, 30);
            this.Log_back.TabIndex = 33;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "potbot";
            this.saveFileDialog1.InitialDirectory = "\"c:/potbot/\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(452, 13);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 31);
            this.button9.TabIndex = 14;
            this.button9.Text = "Connect to Camera";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Save_dafault
            // 
            this.Save_dafault.Location = new System.Drawing.Point(487, 307);
            this.Save_dafault.Margin = new System.Windows.Forms.Padding(2);
            this.Save_dafault.Name = "Save_dafault";
            this.Save_dafault.Size = new System.Drawing.Size(134, 36);
            this.Save_dafault.TabIndex = 28;
            this.Save_dafault.Text = "Restore Default Settings";
            this.Save_dafault.UseVisualStyleBackColor = true;
            this.Save_dafault.Visible = false;
            this.Save_dafault.Click += new System.EventHandler(this.Save_dafault_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(266, 22);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 31);
            this.button10.TabIndex = 29;
            this.button10.Text = "Potbot Test";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // status_chk
            // 
            this.status_chk.Enabled = true;
            this.status_chk.Tick += new System.EventHandler(this.status_chk_Tick);
            // 
            // text_notification
            // 
            this.text_notification.Location = new System.Drawing.Point(7, 377);
            this.text_notification.Margin = new System.Windows.Forms.Padding(2);
            this.text_notification.Name = "text_notification";
            this.text_notification.ReadOnly = true;
            this.text_notification.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.text_notification.Size = new System.Drawing.Size(813, 196);
            this.text_notification.TabIndex = 30;
            this.text_notification.Text = "";
            this.text_notification.TextChanged += new System.EventHandler(this.text_notification_TextChanged);
            // 
            // status_timeout
            // 
            this.status_timeout.Interval = 2000;
            this.status_timeout.Tick += new System.EventHandler(this.status_timeout_Tick);
            // 
            // progressBar_cam
            // 
            this.progressBar_cam.Location = new System.Drawing.Point(7, 577);
            this.progressBar_cam.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_cam.Name = "progressBar_cam";
            this.progressBar_cam.Size = new System.Drawing.Size(812, 19);
            this.progressBar_cam.TabIndex = 30;
            // 
            // button_reconn
            // 
            this.button_reconn.Location = new System.Drawing.Point(603, 13);
            this.button_reconn.Margin = new System.Windows.Forms.Padding(2);
            this.button_reconn.Name = "button_reconn";
            this.button_reconn.Size = new System.Drawing.Size(147, 31);
            this.button_reconn.TabIndex = 31;
            this.button_reconn.Text = "Re-connect";
            this.button_reconn.UseVisualStyleBackColor = true;
            this.button_reconn.Visible = false;
            this.button_reconn.Click += new System.EventHandler(this.button_reconn_Click);
            // 
            // picBox_flo_dia
            // 
            this.picBox_flo_dia.Image = global::Potbot.Properties.Resources.Flow_Diagram_PB_II_;
            this.picBox_flo_dia.Location = new System.Drawing.Point(870, 20);
            this.picBox_flo_dia.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_flo_dia.Name = "picBox_flo_dia";
            this.picBox_flo_dia.Size = new System.Drawing.Size(588, 662);
            this.picBox_flo_dia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_flo_dia.TabIndex = 7;
            this.picBox_flo_dia.TabStop = false;
            // 
            // but_firmware
            // 
            this.but_firmware.Location = new System.Drawing.Point(626, 307);
            this.but_firmware.Name = "but_firmware";
            this.but_firmware.Size = new System.Drawing.Size(133, 36);
            this.but_firmware.TabIndex = 32;
            this.but_firmware.Text = "Firmware Upload";
            this.but_firmware.UseVisualStyleBackColor = true;
            this.but_firmware.Click += new System.EventHandler(this.but_firmware_Click);
            // 
            // save_default_but
            // 
            this.save_default_but.Location = new System.Drawing.Point(335, 335);
            this.save_default_but.Margin = new System.Windows.Forms.Padding(2);
            this.save_default_but.Name = "save_default_but";
            this.save_default_but.Size = new System.Drawing.Size(134, 36);
            this.save_default_but.TabIndex = 14;
            this.save_default_but.Text = "Save Default Settings";
            this.save_default_but.UseVisualStyleBackColor = true;
            this.save_default_but.Click += new System.EventHandler(this.save_default_but_Click);
            // 
            // l_version
            // 
            this.l_version.AutoSize = true;
            this.l_version.Location = new System.Drawing.Point(1393, 2);
            this.l_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(37, 13);
            this.l_version.TabIndex = 34;
            this.l_version.Text = "10.0.6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1384, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "v";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 845);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save_default_but);
            this.Controls.Add(this.but_firmware);
            this.Controls.Add(this.button_reconn);
            this.Controls.Add(this.progressBar_cam);
            this.Controls.Add(this.text_notification);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.Save_dafault);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.picBox_flo_dia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_pot_set);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Text_console);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "POTBot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_pot_set.ResumeLayout(false);
            this.groupBox_pot_set.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loc_fol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_flo_dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Text_console;
        private System.Windows.Forms.Timer timer_read_pot;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.Label label_P6;
        private System.Windows.Forms.Label label_P5;
        private System.Windows.Forms.Label label_P4;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Timer seq_all_in_one;
        private System.Windows.Forms.GroupBox groupBox_pot_set;
        private System.Windows.Forms.CheckBox checkbox_w_log;
        private System.Windows.Forms.CheckBox checkbox_d_log;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label_P9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label_P8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_P7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkbox_w_vid;
        private System.Windows.Forms.CheckBox checkbox_d_vid;
        private System.Windows.Forms.Label label_P15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_loc_fol;
        private System.Windows.Forms.PictureBox picBox_flo_dia;
        private System.Windows.Forms.Button button_write_pot;
        private System.Windows.Forms.Button button_rest_dft;
        private System.Windows.Forms.Button button_read_pot;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label_P12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Save_dafault;
        private System.Windows.Forms.Button Download_all;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer status_chk;
        private System.Windows.Forms.RichTextBox text_notification;
        private System.Windows.Forms.Timer status_timeout;
        private System.Windows.Forms.ProgressBar progressBar_cam;
        private System.Windows.Forms.Button button_reconn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox_loc_fol;
        private System.Windows.Forms.Label label_cam_back;
        private System.Windows.Forms.Label Log_back;
        private System.Windows.Forms.Label label_P11;
        private System.Windows.Forms.Label label_P10;
        private System.Windows.Forms.Button but_firmware;
        private System.Windows.Forms.Button save_default_but;
        private System.Windows.Forms.CheckBox chk_P1_hrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Label label2;
    }
}

