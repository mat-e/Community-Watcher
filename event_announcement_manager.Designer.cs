namespace Community_Watcher
{
    partial class event_announcement_manager
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEventName = new TextBox();
            txtLocation = new TextBox();
            dateEventsManager = new DateTimePicker();
            rtxtSummary = new RichTextBox();
            rtxtBody = new RichTextBox();
            label7 = new Label();
            txtHeading = new TextBox();
            label8 = new Label();
            btnAddEvent = new Button();
            btnAddAnnouncement = new Button();
            btnGoBack = new Button();
            label9 = new Label();
            cboxCategory = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 24);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Events";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 60);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 139);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Location";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 217);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Summary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(437, 24);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 5;
            label6.Text = "Annoucements";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(125, 57);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(143, 23);
            txtEventName.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(125, 136);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(143, 23);
            txtLocation.TabIndex = 7;
            // 
            // dateEventsManager
            // 
            dateEventsManager.Location = new Point(125, 96);
            dateEventsManager.Name = "dateEventsManager";
            dateEventsManager.Size = new Size(143, 23);
            dateEventsManager.TabIndex = 8;
            // 
            // rtxtSummary
            // 
            rtxtSummary.Location = new Point(125, 218);
            rtxtSummary.Name = "rtxtSummary";
            rtxtSummary.Size = new Size(143, 96);
            rtxtSummary.TabIndex = 10;
            rtxtSummary.Text = "";
            // 
            // rtxtBody
            // 
            rtxtBody.Location = new Point(456, 136);
            rtxtBody.Name = "rtxtBody";
            rtxtBody.Size = new Size(143, 96);
            rtxtBody.TabIndex = 11;
            rtxtBody.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(370, 65);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 12;
            label7.Text = "Heading";
            // 
            // txtHeading
            // 
            txtHeading.Location = new Point(456, 65);
            txtHeading.Name = "txtHeading";
            txtHeading.Size = new Size(143, 23);
            txtHeading.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(370, 136);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 14;
            label8.Text = "Body";
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(165, 339);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(75, 23);
            btnAddEvent.TabIndex = 15;
            btnAddEvent.Text = "Add Event";
            btnAddEvent.UseVisualStyleBackColor = true;
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // btnAddAnnouncement
            // 
            btnAddAnnouncement.Location = new Point(456, 281);
            btnAddAnnouncement.Name = "btnAddAnnouncement";
            btnAddAnnouncement.Size = new Size(122, 23);
            btnAddAnnouncement.TabIndex = 16;
            btnAddAnnouncement.Text = "Add Annoucement";
            btnAddAnnouncement.UseVisualStyleBackColor = true;
            btnAddAnnouncement.Click += btnAddAnnouncement_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(501, 339);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(98, 23);
            btnGoBack.TabIndex = 17;
            btnGoBack.Text = "Go Back";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 182);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 18;
            label9.Text = "Category";
            // 
            // cboxCategory
            // 
            cboxCategory.FormattingEnabled = true;
            cboxCategory.Items.AddRange(new object[] { "Community", "Sports", "Utilities" });
            cboxCategory.Location = new Point(125, 179);
            cboxCategory.Name = "cboxCategory";
            cboxCategory.Size = new Size(143, 23);
            cboxCategory.TabIndex = 19;
            // 
            // event_announcement_manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 374);
            Controls.Add(cboxCategory);
            Controls.Add(label9);
            Controls.Add(btnGoBack);
            Controls.Add(btnAddAnnouncement);
            Controls.Add(btnAddEvent);
            Controls.Add(label8);
            Controls.Add(txtHeading);
            Controls.Add(label7);
            Controls.Add(rtxtBody);
            Controls.Add(rtxtSummary);
            Controls.Add(dateEventsManager);
            Controls.Add(txtLocation);
            Controls.Add(txtEventName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "event_announcement_manager";
            Text = "event_announcement_manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEventName;
        private TextBox txtLocation;
        private DateTimePicker dateEventsManager;
        private RichTextBox rtxtSummary;
        private RichTextBox rtxtBody;
        private Label label7;
        private TextBox txtHeading;
        private Label label8;
        private Button btnAddEvent;
        private Button btnAddAnnouncement;
        private Button btnGoBack;
        private Label label9;
        private ComboBox cboxCategory;
    }
}