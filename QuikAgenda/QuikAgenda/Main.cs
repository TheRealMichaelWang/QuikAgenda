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
    public partial class Main : Form
    {
        Agenda agenda;

        public Main()
        {
            InitializeComponent();
            agenda = new Agenda();
            try
            {
                RefreshQueueButton_Click(null, null);
            }
            catch
            {
                MessageBox.Show("It looks like we are having touble connecting to the internet. An internet connection is required to send and share the entire school agenda. Click OK to continue closing the app.", "Quik Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshQueueButton_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                MessageBox.Show("This may take a little while", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            AssignmentQueue.Items.Clear();
            agenda.LoadData();
            foreach (Assignment assignment in agenda.assignments)
            {
                AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
            }
        }

        private void AddAssignmentButton_Click(object sender, EventArgs e)
        {
            AddAssignment addAssignment = new AddAssignment();
            MessageBox.Show("This may take a little while","QuikAgenda",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(addAssignment.output!=null)
            {
                if(!agenda.AddAssignment(addAssignment.output))
                {
                    MessageBox.Show("That assignment already exists.", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshQueueButton_Click(null, null);
            }
        }

        private void DeleteAssignmentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may take a little while", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!string.IsNullOrEmpty((string)AssignmentQueue.SelectedItem))
            {
                if(!agenda.DelAssignment((string)AssignmentQueue.SelectedItem))
                {
                    MessageBox.Show("That assignment no longer exists. It may have been deleted.", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshQueueButton_Click(null, null);
            }
        }

        private void EditAssignmentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may take a little while", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!string.IsNullOrEmpty((string)AssignmentQueue.SelectedItem))
            {
                if(!agenda.EditAssignment((string)AssignmentQueue.SelectedItem))
                {
                    MessageBox.Show("That assignment no longer exists or the operation has been canceled. It may have been deleted.", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshQueueButton_Click(null, null);
            }
        }

        private void GetMoreInfoButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((string)AssignmentQueue.SelectedItem))
            {
                Assignment ass = agenda.GetAssignment((string)AssignmentQueue.SelectedItem);
                if(ass!=null)
                {
                    MessageBox.Show(ass.ToTxtLongDisplayString(),"Quik Agenda",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    RefreshQueueButton_Click(null, null);
                }
                else
                {
                    MessageBox.Show("That assignment no longer exists. It may have been deleted.", "QuikAgenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FilterDueTommorowButtton_Click(object sender, EventArgs e)
        {
            AssignmentQueue.Items.Clear();
            foreach(Assignment assignment in agenda.assignments)
            {
                if (assignment.duedate.Date - DateTime.Now.Date < new TimeSpan(2,0,0,0) && assignment.duedate.Date - DateTime.Now.Date >= new TimeSpan(1, 0, 0, 0))
                {
                    AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                }
            }
        }

        private void FilterDueTodayButton_Click(object sender, EventArgs e)
        {
            AssignmentQueue.Items.Clear();
            foreach (Assignment assignment in agenda.assignments)
            {
                if (assignment.duedate.Date == DateTime.Now.Date)
                {
                    AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                }
            }
        }

        private void FilterOverdueButton_Click(object sender, EventArgs e)
        {
            AssignmentQueue.Items.Clear();
            foreach (Assignment assignment in agenda.assignments)
            {
                if (assignment.duedate.Date - DateTime.Now.Date < new TimeSpan(0, 0, 0))
                {
                    AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                }
            }
        }

        private void FilterByTeacherButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("What teacher do you want to filter?","QuikAngeda");
            if(prompt.canceled == false)
            {
                AssignmentQueue.Items.Clear();
                foreach (Assignment assignment in agenda.assignments)
                {
                    if(assignment.Teacher.ToLower() == prompt.output.ToLower())
                    {
                        AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                    }
                }
            }
        }

        private void FilterByClassButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("What class do you want to filter?", "QuikAgenda");
            if (prompt.canceled == false)
            {
                AssignmentQueue.Items.Clear();
                foreach (Assignment assignment in agenda.assignments)
                {
                    if (assignment.Class.ToLower() == prompt.output.ToLower())
                    {
                        AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                    }
                }
            }
        }

        private void FilterNoneButton_Click(object sender, EventArgs e)
        {
            AssignmentQueue.Items.Clear();
            foreach(Assignment assignment in agenda.assignments)
            {
                AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
            }
        }

        private void FilterByPeriodButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("What period do you want to filter.", "QuikAgenda");
            if (prompt.canceled == false)
            {
                AssignmentQueue.Items.Clear();
                foreach (Assignment assignment in agenda.assignments)
                {
                    if(assignment.Periods.Contains(prompt.output))
                    {
                        AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                    }
                }
            }
        }

        private void FilterByGradeButton_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("What grade do you want to filter.", "QuikAgenda");
            if (prompt.canceled == false)
            {
                AssignmentQueue.Items.Clear();
                foreach (Assignment assignment in agenda.assignments)
                {
                    if (assignment.Periods.Contains("All "+prompt.output+"th grade periods"))
                    {
                        AssignmentQueue.Items.Add(assignment.ToTxtShortDisplayString());
                    }
                }
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            AssignmentQueue.Width = this.Width-17;
            AssignmentQueue.Height = this.Height - 77;
            AboutButton.Location = new Point(this.Width - AboutButton.Width - 17, AboutButton.Location.Y);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
        }
    }
}