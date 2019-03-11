using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuikAgenda
{
    public partial class Prompt : Form
    {
        public bool canceled = true;
        public string output = "";

        public Prompt(string prompt,string defaultinput)
        {
            InitializeComponent();
            this.Text = prompt;
            this.ShowDialog();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            output = InputBox.Text;
            canceled = false;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                OKButton_Click(sender, e);
            }
        }
    }
}
