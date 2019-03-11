namespace QuikAgenda
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.AssignmentQueue = new System.Windows.Forms.ListBox();
            this.RefreshQueueButton = new System.Windows.Forms.Button();
            this.GeneralGroupBox = new System.Windows.Forms.GroupBox();
            this.GetMoreInfoButton = new System.Windows.Forms.Button();
            this.EditAssignmentButton = new System.Windows.Forms.Button();
            this.DeleteAssignmentButton = new System.Windows.Forms.Button();
            this.AddAssignmentButton = new System.Windows.Forms.Button();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.FilterByGradeButton = new System.Windows.Forms.Button();
            this.FilterByPeriodButton = new System.Windows.Forms.Button();
            this.FilterOverdueButton = new System.Windows.Forms.Button();
            this.FilterByClassButton = new System.Windows.Forms.Button();
            this.FilterByTeacherButton = new System.Windows.Forms.Button();
            this.FilterNoneButton = new System.Windows.Forms.Button();
            this.FilterDueTodayButton = new System.Windows.Forms.Button();
            this.FilterDueTommorowButtton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.GeneralGroupBox.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssignmentQueue
            // 
            this.AssignmentQueue.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignmentQueue.FormattingEnabled = true;
            this.AssignmentQueue.Location = new System.Drawing.Point(0, 60);
            this.AssignmentQueue.Name = "AssignmentQueue";
            this.AssignmentQueue.Size = new System.Drawing.Size(1263, 537);
            this.AssignmentQueue.TabIndex = 0;
            // 
            // RefreshQueueButton
            // 
            this.RefreshQueueButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshQueueButton.Name = "RefreshQueueButton";
            this.RefreshQueueButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshQueueButton.TabIndex = 1;
            this.RefreshQueueButton.Text = "Refresh";
            this.RefreshQueueButton.UseVisualStyleBackColor = true;
            this.RefreshQueueButton.Click += new System.EventHandler(this.RefreshQueueButton_Click);
            // 
            // GeneralGroupBox
            // 
            this.GeneralGroupBox.Controls.Add(this.GetMoreInfoButton);
            this.GeneralGroupBox.Controls.Add(this.EditAssignmentButton);
            this.GeneralGroupBox.Controls.Add(this.DeleteAssignmentButton);
            this.GeneralGroupBox.Controls.Add(this.AddAssignmentButton);
            this.GeneralGroupBox.Controls.Add(this.RefreshQueueButton);
            this.GeneralGroupBox.Location = new System.Drawing.Point(5, 3);
            this.GeneralGroupBox.Name = "GeneralGroupBox";
            this.GeneralGroupBox.Size = new System.Drawing.Size(530, 51);
            this.GeneralGroupBox.TabIndex = 2;
            this.GeneralGroupBox.TabStop = false;
            this.GeneralGroupBox.Text = "General";
            // 
            // GetMoreInfoButton
            // 
            this.GetMoreInfoButton.Location = new System.Drawing.Point(420, 19);
            this.GetMoreInfoButton.Name = "GetMoreInfoButton";
            this.GetMoreInfoButton.Size = new System.Drawing.Size(105, 23);
            this.GetMoreInfoButton.TabIndex = 5;
            this.GetMoreInfoButton.Text = "GetMoreInfo";
            this.GetMoreInfoButton.UseVisualStyleBackColor = true;
            this.GetMoreInfoButton.Click += new System.EventHandler(this.GetMoreInfoButton_Click);
            // 
            // EditAssignmentButton
            // 
            this.EditAssignmentButton.Location = new System.Drawing.Point(309, 19);
            this.EditAssignmentButton.Name = "EditAssignmentButton";
            this.EditAssignmentButton.Size = new System.Drawing.Size(105, 23);
            this.EditAssignmentButton.TabIndex = 4;
            this.EditAssignmentButton.Text = "EditAssignment";
            this.EditAssignmentButton.UseVisualStyleBackColor = true;
            this.EditAssignmentButton.Click += new System.EventHandler(this.EditAssignmentButton_Click);
            // 
            // DeleteAssignmentButton
            // 
            this.DeleteAssignmentButton.Location = new System.Drawing.Point(198, 19);
            this.DeleteAssignmentButton.Name = "DeleteAssignmentButton";
            this.DeleteAssignmentButton.Size = new System.Drawing.Size(105, 23);
            this.DeleteAssignmentButton.TabIndex = 3;
            this.DeleteAssignmentButton.Text = "DelAssignment";
            this.DeleteAssignmentButton.UseVisualStyleBackColor = true;
            this.DeleteAssignmentButton.Click += new System.EventHandler(this.DeleteAssignmentButton_Click);
            // 
            // AddAssignmentButton
            // 
            this.AddAssignmentButton.Location = new System.Drawing.Point(87, 19);
            this.AddAssignmentButton.Name = "AddAssignmentButton";
            this.AddAssignmentButton.Size = new System.Drawing.Size(105, 23);
            this.AddAssignmentButton.TabIndex = 2;
            this.AddAssignmentButton.Text = "AddAssignment";
            this.AddAssignmentButton.UseVisualStyleBackColor = true;
            this.AddAssignmentButton.Click += new System.EventHandler(this.AddAssignmentButton_Click);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.FilterByGradeButton);
            this.FilterGroupBox.Controls.Add(this.FilterByPeriodButton);
            this.FilterGroupBox.Controls.Add(this.FilterOverdueButton);
            this.FilterGroupBox.Controls.Add(this.FilterByClassButton);
            this.FilterGroupBox.Controls.Add(this.FilterByTeacherButton);
            this.FilterGroupBox.Controls.Add(this.FilterNoneButton);
            this.FilterGroupBox.Controls.Add(this.FilterDueTodayButton);
            this.FilterGroupBox.Controls.Add(this.FilterDueTommorowButtton);
            this.FilterGroupBox.Location = new System.Drawing.Point(541, 3);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(658, 51);
            this.FilterGroupBox.TabIndex = 3;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            // 
            // FilterByGradeButton
            // 
            this.FilterByGradeButton.Location = new System.Drawing.Point(578, 19);
            this.FilterByGradeButton.Name = "FilterByGradeButton";
            this.FilterByGradeButton.Size = new System.Drawing.Size(75, 23);
            this.FilterByGradeButton.TabIndex = 7;
            this.FilterByGradeButton.Text = "ByGrade";
            this.FilterByGradeButton.UseVisualStyleBackColor = true;
            this.FilterByGradeButton.Click += new System.EventHandler(this.FilterByGradeButton_Click);
            // 
            // FilterByPeriodButton
            // 
            this.FilterByPeriodButton.Location = new System.Drawing.Point(497, 19);
            this.FilterByPeriodButton.Name = "FilterByPeriodButton";
            this.FilterByPeriodButton.Size = new System.Drawing.Size(75, 23);
            this.FilterByPeriodButton.TabIndex = 6;
            this.FilterByPeriodButton.Text = "ByPeriod";
            this.FilterByPeriodButton.UseVisualStyleBackColor = true;
            this.FilterByPeriodButton.Click += new System.EventHandler(this.FilterByPeriodButton_Click);
            // 
            // FilterOverdueButton
            // 
            this.FilterOverdueButton.Location = new System.Drawing.Point(254, 19);
            this.FilterOverdueButton.Name = "FilterOverdueButton";
            this.FilterOverdueButton.Size = new System.Drawing.Size(75, 23);
            this.FilterOverdueButton.TabIndex = 5;
            this.FilterOverdueButton.Text = "Overdue";
            this.FilterOverdueButton.UseVisualStyleBackColor = true;
            this.FilterOverdueButton.Click += new System.EventHandler(this.FilterOverdueButton_Click);
            // 
            // FilterByClassButton
            // 
            this.FilterByClassButton.Location = new System.Drawing.Point(416, 19);
            this.FilterByClassButton.Name = "FilterByClassButton";
            this.FilterByClassButton.Size = new System.Drawing.Size(75, 23);
            this.FilterByClassButton.TabIndex = 4;
            this.FilterByClassButton.Text = "ByClass";
            this.FilterByClassButton.UseVisualStyleBackColor = true;
            this.FilterByClassButton.Click += new System.EventHandler(this.FilterByClassButton_Click);
            // 
            // FilterByTeacherButton
            // 
            this.FilterByTeacherButton.Location = new System.Drawing.Point(335, 19);
            this.FilterByTeacherButton.Name = "FilterByTeacherButton";
            this.FilterByTeacherButton.Size = new System.Drawing.Size(75, 23);
            this.FilterByTeacherButton.TabIndex = 3;
            this.FilterByTeacherButton.Text = "ByTeacher";
            this.FilterByTeacherButton.UseVisualStyleBackColor = true;
            this.FilterByTeacherButton.Click += new System.EventHandler(this.FilterByTeacherButton_Click);
            // 
            // FilterNoneButton
            // 
            this.FilterNoneButton.Location = new System.Drawing.Point(6, 19);
            this.FilterNoneButton.Name = "FilterNoneButton";
            this.FilterNoneButton.Size = new System.Drawing.Size(75, 23);
            this.FilterNoneButton.TabIndex = 2;
            this.FilterNoneButton.Text = "ClearFilters";
            this.FilterNoneButton.UseVisualStyleBackColor = true;
            this.FilterNoneButton.Click += new System.EventHandler(this.FilterNoneButton_Click);
            // 
            // FilterDueTodayButton
            // 
            this.FilterDueTodayButton.Location = new System.Drawing.Point(173, 19);
            this.FilterDueTodayButton.Name = "FilterDueTodayButton";
            this.FilterDueTodayButton.Size = new System.Drawing.Size(75, 23);
            this.FilterDueTodayButton.TabIndex = 1;
            this.FilterDueTodayButton.Text = "DueToday";
            this.FilterDueTodayButton.UseVisualStyleBackColor = true;
            this.FilterDueTodayButton.Click += new System.EventHandler(this.FilterDueTodayButton_Click);
            // 
            // FilterDueTommorowButtton
            // 
            this.FilterDueTommorowButtton.Location = new System.Drawing.Point(87, 19);
            this.FilterDueTommorowButtton.Name = "FilterDueTommorowButtton";
            this.FilterDueTommorowButtton.Size = new System.Drawing.Size(80, 23);
            this.FilterDueTommorowButtton.TabIndex = 0;
            this.FilterDueTommorowButtton.Text = "DueNextDay";
            this.FilterDueTommorowButtton.UseVisualStyleBackColor = true;
            this.FilterDueTommorowButtton.Click += new System.EventHandler(this.FilterDueTommorowButtton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(1206, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(46, 50);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 598);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.GeneralGroupBox);
            this.Controls.Add(this.AssignmentQueue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "QuikAgenda";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.GeneralGroupBox.ResumeLayout(false);
            this.FilterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AssignmentQueue;
        private System.Windows.Forms.Button RefreshQueueButton;
        private System.Windows.Forms.GroupBox GeneralGroupBox;
        private System.Windows.Forms.Button AddAssignmentButton;
        private System.Windows.Forms.Button DeleteAssignmentButton;
        private System.Windows.Forms.Button EditAssignmentButton;
        private System.Windows.Forms.Button GetMoreInfoButton;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.Button FilterDueTommorowButtton;
        private System.Windows.Forms.Button FilterDueTodayButton;
        private System.Windows.Forms.Button FilterNoneButton;
        private System.Windows.Forms.Button FilterByTeacherButton;
        private System.Windows.Forms.Button FilterByClassButton;
        private System.Windows.Forms.Button FilterOverdueButton;
        private System.Windows.Forms.Button FilterByPeriodButton;
        private System.Windows.Forms.Button FilterByGradeButton;
        private System.Windows.Forms.Button AboutButton;
    }
}

