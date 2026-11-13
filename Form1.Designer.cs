namespace Community_Watcher
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReportIssues = new Button();
            btnAnnouncements = new Button();
            btnServiceRequest = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnReportIssues
            // 
            btnReportIssues.BackColor = Color.IndianRed;
            btnReportIssues.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportIssues.Location = new Point(12, 109);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(115, 73);
            btnReportIssues.TabIndex = 0;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = false;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // btnAnnouncements
            // 
            btnAnnouncements.BackColor = SystemColors.Highlight;
            btnAnnouncements.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnouncements.Location = new Point(178, 111);
            btnAnnouncements.Name = "btnAnnouncements";
            btnAnnouncements.Size = new Size(183, 71);
            btnAnnouncements.TabIndex = 1;
            btnAnnouncements.Text = "View Events and Announcements";
            btnAnnouncements.UseVisualStyleBackColor = false;
            btnAnnouncements.Click += btnAnnouncements_Click;
            // 
            // btnServiceRequest
            // 
            btnServiceRequest.BackColor = Color.LimeGreen;
            btnServiceRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServiceRequest.Location = new Point(395, 109);
            btnServiceRequest.Name = "btnServiceRequest";
            btnServiceRequest.Size = new Size(115, 71);
            btnServiceRequest.TabIndex = 2;
            btnServiceRequest.Text = "Service Request Status";
            btnServiceRequest.UseVisualStyleBackColor = false;
            btnServiceRequest.Click += btnServiceRequest_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 31);
            label1.Name = "label1";
            label1.Size = new Size(268, 21);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Community Watcher!";
            // 
            // frmMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(522, 311);
            Controls.Add(label1);
            Controls.Add(btnServiceRequest);
            Controls.Add(btnAnnouncements);
            Controls.Add(btnReportIssues);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMainMenu";
            Text = "Cummunity Watcher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReportIssues;
        private Button btnAnnouncements;
        private Button btnServiceRequest;
        private Label label1;
    }
}