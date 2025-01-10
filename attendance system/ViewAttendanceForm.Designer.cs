namespace WindowsFormsApp1
{
    partial class ViewAttendanceForm
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
            this.listBoxAttendance = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAttendance
            // 
            this.listBoxAttendance.FormattingEnabled = true;
            this.listBoxAttendance.Location = new System.Drawing.Point(102, 36);
            this.listBoxAttendance.Name = "listBoxAttendance";
            this.listBoxAttendance.Size = new System.Drawing.Size(341, 238);
            this.listBoxAttendance.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(102, 289);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Attendance";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ViewAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 374);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listBoxAttendance);
            this.Name = "ViewAttendanceForm";
            this.Text = "ViewAttendanceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAttendance;
        private System.Windows.Forms.Button btnRefresh;
    }
}