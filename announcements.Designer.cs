namespace Community_Watcher
{
    partial class announcements
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
            cboxCategories = new ComboBox();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            btnSearch = new Button();
            btnClear = new Button();
            lstEvents = new ListView();
            btnMainMenu = new Button();
            btnManager = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cboxCategories
            // 
            cboxCategories.FormattingEnabled = true;
            cboxCategories.Items.AddRange(new object[] { "All Categories", "Community", "Sports", "Utilities" });
            cboxCategories.Location = new Point(46, 29);
            cboxCategories.Name = "cboxCategories";
            cboxCategories.Size = new Size(121, 23);
            cboxCategories.TabIndex = 0;
            // 
            // dateFrom
            // 
            dateFrom.Location = new Point(209, 29);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(192, 23);
            dateFrom.TabIndex = 1;
            // 
            // dateTo
            // 
            dateTo.Location = new Point(449, 26);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(191, 23);
            dateTo.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(209, 80);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(326, 80);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lstEvents
            // 
            lstEvents.Location = new Point(116, 130);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(405, 208);
            lstEvents.TabIndex = 5;
            lstEvents.UseCompatibleStateImageBehavior = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(537, 354);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(103, 23);
            btnMainMenu.TabIndex = 6;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnManager
            // 
            btnManager.Location = new Point(537, 315);
            btnManager.Name = "btnManager";
            btnManager.Size = new Size(103, 23);
            btnManager.TabIndex = 7;
            btnManager.Text = "Go To Manager";
            btnManager.UseVisualStyleBackColor = true;
            btnManager.Click += btnManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 8;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 8);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 9;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(488, 8);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 10;
            label3.Text = "To";
            // 
            // announcements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 389);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnManager);
            Controls.Add(btnMainMenu);
            Controls.Add(lstEvents);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(dateTo);
            Controls.Add(dateFrom);
            Controls.Add(cboxCategories);
            Name = "announcements";
            Text = "announcements";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboxCategories;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Button btnSearch;
        private Button btnClear;
        private ListView lstEvents;
        private Button btnMainMenu;
        private Button btnManager;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}