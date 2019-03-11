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
    public partial class AddAssignment : Form
    {
        public Assignment output = null;

        public AddAssignment()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        public AddAssignment(Assignment defaultvalue)
        {
            InitializeComponent();
            this.AssignmentNameInput.Text = defaultvalue.Name;
            this.InfoInput.Text = defaultvalue.Info;
            this.TeacherInput.Text = defaultvalue.Teacher;
            this.ClassInput.Text = defaultvalue.Class;
            this.DateDueInput.Value = defaultvalue.duedate;
            foreach(string period in defaultvalue.Periods)
            {
                if (period != "")
                {
                    this.PeriodInput.Text = period + ",";
                }
            }
            this.ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(InfoInput.Text.Contains(','))
            {
                MessageBox.Show("You cannot put a comma in the text", "Quik Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            output = new Assignment(AssignmentNameInput.Text, InfoInput.Text, TeacherInput.Text, ClassInput.Text, DateDueInput.Value, PeriodInput.Text.Split(','));
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
