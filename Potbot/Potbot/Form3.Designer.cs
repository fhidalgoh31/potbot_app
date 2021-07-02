using System;
namespace Potbot
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picBox_loc_fol = new System.Windows.Forms.PictureBox();
            this.button_loc_fol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.but_upload = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Text_console = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loc_fol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Hex File to upload";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // picBox_loc_fol
            // 
            this.picBox_loc_fol.Image = global::Potbot.Properties.Resources.icons8_folder_16;
            this.picBox_loc_fol.Location = new System.Drawing.Point(720, 54);
            this.picBox_loc_fol.Margin = new System.Windows.Forms.Padding(2);
            this.picBox_loc_fol.Name = "picBox_loc_fol";
            this.picBox_loc_fol.Size = new System.Drawing.Size(20, 20);
            this.picBox_loc_fol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_loc_fol.TabIndex = 34;
            this.picBox_loc_fol.TabStop = false;
            this.picBox_loc_fol.Click += new System.EventHandler(this.picBox_loc_fol_Click);
            // 
            // button_loc_fol
            // 
            this.button_loc_fol.Location = new System.Drawing.Point(175, 51);
            this.button_loc_fol.Margin = new System.Windows.Forms.Padding(2);
            this.button_loc_fol.Name = "button_loc_fol";
            this.button_loc_fol.Size = new System.Drawing.Size(566, 27);
            this.button_loc_fol.TabIndex = 33;
            this.button_loc_fol.Text = "C:/Potbot/";
            this.button_loc_fol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_loc_fol.UseVisualStyleBackColor = true;
            this.button_loc_fol.Click += new System.EventHandler(this.button_loc_fol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Potbot found in:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // but_upload
            // 
            this.but_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_upload.Location = new System.Drawing.Point(438, 145);
            this.but_upload.Margin = new System.Windows.Forms.Padding(2);
            this.but_upload.Name = "but_upload";
            this.but_upload.Size = new System.Drawing.Size(236, 48);
            this.but_upload.TabIndex = 36;
            this.but_upload.Text = "Upload Firmware";
            this.but_upload.UseVisualStyleBackColor = true;
            this.but_upload.Click += new System.EventHandler(this.but_upload_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Text_console
            // 
            this.Text_console.Location = new System.Drawing.Point(105, 232);
            this.Text_console.Margin = new System.Windows.Forms.Padding(2);
            this.Text_console.Multiline = true;
            this.Text_console.Name = "Text_console";
            this.Text_console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_console.Size = new System.Drawing.Size(555, 127);
            this.Text_console.TabIndex = 38;
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.ForeColor = System.Drawing.Color.Green;
            this.port_label.Location = new System.Drawing.Point(102, 96);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(10, 13);
            this.port_label.TabIndex = 39;
            this.port_label.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.MaximumSize = new System.Drawing.Size(500, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 65);
            this.label3.TabIndex = 40;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Console:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 386);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.Text_console);
            this.Controls.Add(this.but_upload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBox_loc_fol);
            this.Controls.Add(this.button_loc_fol);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Firmware Upload";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_loc_fol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBox_loc_fol;
        private System.Windows.Forms.Button button_loc_fol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button but_upload;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox Text_console;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}