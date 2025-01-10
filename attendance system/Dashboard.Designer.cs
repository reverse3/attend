namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.lblwelcome = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnTakeAttendance = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.listBoxSections = new System.Windows.Forms.ListBox();
            this.btnOpenAddStudentForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Location = new System.Drawing.Point(176, 48);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(57, 13);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "llaallalalala";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(65, 220);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnTakeAttendance
            // 
            this.btnTakeAttendance.Location = new System.Drawing.Point(65, 91);
            this.btnTakeAttendance.Name = "btnTakeAttendance";
            this.btnTakeAttendance.Size = new System.Drawing.Size(94, 22);
            this.btnTakeAttendance.TabIndex = 7;
            this.btnTakeAttendance.Text = "Attendance";
            this.btnTakeAttendance.UseVisualStyleBackColor = true;
            this.btnTakeAttendance.Click += new System.EventHandler(this.btnTakeAttendance_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Location = new System.Drawing.Point(65, 129);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(113, 22);
            this.btnViewAttendance.TabIndex = 8;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(65, 168);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(113, 22);
            this.btnAddSection.TabIndex = 9;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // listBoxSections
            // 
            this.listBoxSections.FormattingEnabled = true;
            this.listBoxSections.Location = new System.Drawing.Point(291, 91);
            this.listBoxSections.Name = "listBoxSections";
            this.listBoxSections.Size = new System.Drawing.Size(267, 108);
            this.listBoxSections.TabIndex = 10;
            // 
            // btnOpenAddStudentForm
            // 
            this.btnOpenAddStudentForm.Location = new System.Drawing.Point(291, 205);
            this.btnOpenAddStudentForm.Name = "btnOpenAddStudentForm";
            this.btnOpenAddStudentForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAddStudentForm.TabIndex = 11;
            this.btnOpenAddStudentForm.Text = "open";
            this.btnOpenAddStudentForm.UseVisualStyleBackColor = true;
            this.btnOpenAddStudentForm.Click += new System.EventHandler(this.btnOpenAddStudentForm_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 327);
            this.Controls.Add(this.btnOpenAddStudentForm);
            this.Controls.Add(this.listBoxSections);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.btnTakeAttendance);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.lblwelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnTakeAttendance;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.ListBox listBoxSections;
        private System.Windows.Forms.Button btnOpenAddStudentForm;
    }
}