namespace WindowsFormsApp1
{
    partial class AddSectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSectionName = new System.Windows.Forms.TextBox();
            this.btnSaveSection = new System.Windows.Forms.Button();
            this.listBoxSections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Section Name:";
            // 
            // txtSectionName
            // 
            this.txtSectionName.Location = new System.Drawing.Point(222, 83);
            this.txtSectionName.Name = "txtSectionName";
            this.txtSectionName.Size = new System.Drawing.Size(108, 20);
            this.txtSectionName.TabIndex = 1;
            // 
            // btnSaveSection
            // 
            this.btnSaveSection.Location = new System.Drawing.Point(222, 119);
            this.btnSaveSection.Name = "btnSaveSection";
            this.btnSaveSection.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSection.TabIndex = 2;
            this.btnSaveSection.Text = "Save Section";
            this.btnSaveSection.UseVisualStyleBackColor = true;
            this.btnSaveSection.Click += new System.EventHandler(this.btnSaveSection_Click_1);
            // 
            // listBoxSections
            // 
            this.listBoxSections.FormattingEnabled = true;
            this.listBoxSections.Location = new System.Drawing.Point(104, 187);
            this.listBoxSections.Name = "listBoxSections";
            this.listBoxSections.Size = new System.Drawing.Size(291, 147);
            this.listBoxSections.TabIndex = 3;
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 420);
            this.Controls.Add(this.listBoxSections);
            this.Controls.Add(this.btnSaveSection);
            this.Controls.Add(this.txtSectionName);
            this.Controls.Add(this.label1);
            this.Name = "AddSectionForm";
            this.Text = "AddSectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSectionName;
        private System.Windows.Forms.Button btnSaveSection;
        private System.Windows.Forms.ListBox listBoxSections;
    }
}