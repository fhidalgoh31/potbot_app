using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potbot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;

        public Form2(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mainForm.Text_console.AppendText("Form 2 button clicked" + Environment.NewLine);
            string data_sent = "l";
            try
            {
                Form1.sport.Write(data_sent);
            }
            catch (UnauthorizedAccessException ex)
            {
                //SetText("Uart exception: " + ex + "\n");
            }

        }
    }

}
