using Community_Watcher.Models;

namespace Community_Watcher
{
    partial class frmReportIssue
    {
        private System.ComponentModel.IContainer components = null;
        private static readonly Random _random = new Random();

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

        private void InitializeComponent()
        {
            btnMainMenu = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtLocation = new TextBox();
            cboxCategory = new ComboBox();
            rtxtDescription = new RichTextBox();
            lblFilename = new Label();
            btnSelectFile = new Button();
            btnReportIssue = new Button();
            lstViewRecentIssues = new ListView();
            colCategory = new ColumnHeader();
            colLocation = new ColumnHeader();
            colDescription = new ColumnHeader();
            colTime = new ColumnHeader();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(429, 291);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(126, 28);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(67, 17);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(67, 71);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(67, 121);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(67, 89);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(164, 23);
            txtLocation.TabIndex = 4;
            // 
            // cboxCategory
            // 
            cboxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Items.AddRange(new object[] { "Water & Sanitation", "Electricity", "Roads & Potholes", "Waste Management", "Public Safety", "Parks & Public Spaces", "Traffic & Signage", "Noise Complaints", "Other" });
            cboxCategory.Location = new Point(67, 38);
            cboxCategory.Name = "cboxCategory";
            cboxCategory.Size = new Size(164, 23);
            cboxCategory.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(67, 139);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(164, 72);
            rtxtDescription.TabIndex = 6;
            rtxtDescription.Text = "";
            // 
            // lblFilename
            // 
            lblFilename.AutoSize = true;
            lblFilename.Location = new Point(160, 244);
            lblFilename.Name = "lblFilename";
            lblFilename.Size = new Size(58, 15);
            lblFilename.TabIndex = 7;
            lblFilename.Text = "File name";
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(67, 240);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 8;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnReportIssue
            // 
            btnReportIssue.Location = new Point(282, 294);
            btnReportIssue.Name = "btnReportIssue";
            btnReportIssue.Size = new Size(105, 23);
            btnReportIssue.TabIndex = 9;
            btnReportIssue.Text = "Report Issue";
            btnReportIssue.UseVisualStyleBackColor = true;
            btnReportIssue.Click += btnReportIssue_Click;
            // 
            // lstViewRecentIssues
            // 
            lstViewRecentIssues.Columns.AddRange(new ColumnHeader[] { colCategory, colLocation, colDescription, colTime });
            lstViewRecentIssues.FullRowSelect = true;
            lstViewRecentIssues.GridLines = true;
            lstViewRecentIssues.Location = new Point(249, 38);
            lstViewRecentIssues.Name = "lstViewRecentIssues";
            lstViewRecentIssues.Size = new Size(271, 173);
            lstViewRecentIssues.TabIndex = 10;
            lstViewRecentIssues.UseCompatibleStateImageBehavior = false;
            lstViewRecentIssues.View = View.Details;
            // 
            // colCategory
            // 
            colCategory.Text = "Category";
            colCategory.Width = 75;
            // 
            // colLocation
            // 
            colLocation.Text = "Location";
            colLocation.Width = 65;
            // 
            // colDescription
            // 
            colDescription.Text = "Description";
            colDescription.Width = 80;
            // 
            // colTime
            // 
            colTime.Text = "Time";
            colTime.Width = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(319, 17);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 11;
            label5.Text = "Recent Issues Reported";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Images and Documents|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.pdf;*.doc;*.docx;*.txt|All files|*.*";
            openFileDialog1.Title = "Select a file related to the issue";
            // 
            // frmReportIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(581, 329);
            Controls.Add(label5);
            Controls.Add(lstViewRecentIssues);
            Controls.Add(btnReportIssue);
            Controls.Add(btnSelectFile);
            Controls.Add(lblFilename);
            Controls.Add(rtxtDescription);
            Controls.Add(cboxCategory);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMainMenu);
            Name = "frmReportIssue";
            Text = "Report Issue";
            Load += frmReportIssue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog1.FileName;
                lblFilename.Text = Path.GetFileName(selectedFilePath);
            }
        }

        private void btnReportIssue_Click(object sender, EventArgs e)
        {
            if (cboxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location of the issue.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocation.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtxtDescription.Focus();
                return;
            }

            Issue issue = IssueRepository.AddIssue(
                cboxCategory.SelectedItem.ToString(),
                txtLocation.Text.Trim(),
                rtxtDescription.Text.Trim(),
                selectedFilePath
            );

            ListViewItem item = new ListViewItem(issue.Category);
            item.SubItems.Add(issue.Location);
            item.SubItems.Add(issue.Description);
            item.SubItems.Add(issue.DateReported.ToString("HH:mm"));

            lstViewRecentIssues.Items.Insert(0, item);

            // Assign random status and push to StatusRepository for Task 3 tracking
            RequestStatus randomStatus = GetRandomStatus();
            int priority = GetPriorityByCategory(issue.Category);
            string depot = AssignDepotByLocation(issue.Location);

            StatusRepository.AddRequest(
                issue.Id,
                issue.Category,
                issue.Location,
                issue.Description,
                issue.DateReported,
                randomStatus,
                priority,
                depot
            );

            string statusText = FormatStatus(randomStatus);

            MessageBox.Show(
                string.Format("Thank you! Your report (Reference #{0}) has been submitted successfully.\n\nAssigned Status: {1}", issue.Id, statusText),
                "Report Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
        }

        private RequestStatus GetRandomStatus()
        {
            RequestStatus[] statuses =
            {
                RequestStatus.AssignedToEngineer,
                RequestStatus.InProgress,
                RequestStatus.PendingApproval,
                RequestStatus.Completed
            };

            return statuses[_random.Next(statuses.Length)];
        }

        private string FormatStatus(RequestStatus status)
        {
            return status switch
            {
                RequestStatus.AssignedToEngineer => "Assigned to Engineer",
                RequestStatus.InProgress => "In Progress",
                RequestStatus.PendingApproval => "Pending Approval",
                RequestStatus.Completed => "Completed",
                _ => status.ToString()
            };
        }

        private int GetPriorityByCategory(string category)
        {
            return category switch
            {
                "Water & Sanitation" => 1,
                "Electricity" => 1,
                "Public Safety" => 2,
                "Waste Management" => 2,
                "Traffic & Signage" => 2,
                _ => 3
            };
        }

        private string AssignDepotByLocation(string location)
        {
            string locLower = location.ToLower();

            if (locLower.Contains("mamelodi")) return "Depot Beta";
            if (locLower.Contains("centurion")) return "Depot Gamma";
            if (locLower.Contains("soshanguve")) return "Depot Delta";

            return "Depot Alpha";
        }

        public void ClearForm()
        {
            cboxCategory.SelectedIndex = -1;
            txtLocation.Clear();
            rtxtDescription.Clear();
            lblFilename.Text = "File name";
            selectedFilePath = string.Empty;
        }

        #endregion

        private Button btnMainMenu;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLocation;
        private ComboBox cboxCategory;
        private RichTextBox rtxtDescription;
        private Label lblFilename;
        private Button btnSelectFile;
        private Button btnReportIssue;
        private ListView lstViewRecentIssues;
        private ColumnHeader colCategory;
        private ColumnHeader colLocation;
        private ColumnHeader colDescription;
        private ColumnHeader colTime;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private string selectedFilePath;
    }
}