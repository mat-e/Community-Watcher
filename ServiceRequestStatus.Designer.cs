namespace Community_Watcher
{
    partial class ServiceRequestStatus
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTitle = new Label();
            lblTrackId = new Label();
            txtSearchId = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            dtGridStatus = new DataGridView();
            lblMstTitle = new Label();
            dtGridMST = new DataGridView();
            lblEngineInfo = new Label();
            btnBackToMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGridMST).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(244, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Service Request Status Tracker";
            // 
            // lblTrackId
            // 
            lblTrackId.AutoSize = true;
            lblTrackId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTrackId.Location = new Point(20, 52);
            lblTrackId.Name = "lblTrackId";
            lblTrackId.Size = new Size(130, 15);
            lblTrackId.TabIndex = 1;
            lblTrackId.Text = "Track Reference ID:";
            // 
            // txtSearchId
            // 
            txtSearchId.Location = new Point(155, 49);
            txtSearchId.Name = "txtSearchId";
            txtSearchId.Size = new Size(130, 23);
            txtSearchId.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(295, 48);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search (BST)";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(410, 48);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(85, 25);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // dtGridStatus
            // 
            dtGridStatus.AllowUserToAddRows = false;
            dtGridStatus.AllowUserToDeleteRows = false;
            dtGridStatus.BackgroundColor = Color.White;
            dtGridStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridStatus.Location = new Point(20, 85);
            dtGridStatus.Name = "dtGridStatus";
            dtGridStatus.ReadOnly = true;
            dtGridStatus.RowHeadersVisible = false;
            dtGridStatus.Size = new Size(820, 220);
            dtGridStatus.TabIndex = 5;
            // 
            // lblMstTitle
            // 
            lblMstTitle.AutoSize = true;
            lblMstTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMstTitle.ForeColor = Color.DarkGreen;
            lblMstTitle.Location = new Point(20, 320);
            lblMstTitle.Name = "lblMstTitle";
            lblMstTitle.Size = new Size(393, 17);
            lblMstTitle.TabIndex = 6;
            lblMstTitle.Text = "Depot Service Network (Minimum Spanning Tree - Prim's Alg)";
            // 
            // dtGridMST
            // 
            dtGridMST.AllowUserToAddRows = false;
            dtGridMST.AllowUserToDeleteRows = false;
            dtGridMST.BackgroundColor = Color.White;
            dtGridMST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridMST.Location = new Point(20, 345);
            dtGridMST.Name = "dtGridMST";
            dtGridMST.ReadOnly = true;
            dtGridMST.RowHeadersVisible = false;
            dtGridMST.Size = new Size(420, 125);
            dtGridMST.TabIndex = 7;
            // 
            // lblEngineInfo
            // 
            lblEngineInfo.AutoSize = true;
            lblEngineInfo.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblEngineInfo.ForeColor = Color.DimGray;
            lblEngineInfo.Location = new Point(460, 345);
            lblEngineInfo.Name = "lblEngineInfo";
            lblEngineInfo.Size = new Size(376, 75);
            lblEngineInfo.TabIndex = 8;
            lblEngineInfo.Text = "Data Structure Engine Active:\r\n• BST: Fast O(log n) Reference ID Lookup\r\n• Min-Heap: Priority Queue ordering by urgency\r\n• Undirected Graph + MST: Optimized inter-depot routing network";
            // 
            // btnBackToMainMenu
            // 
            btnBackToMainMenu.Location = new Point(700, 480);
            btnBackToMainMenu.Name = "btnBackToMainMenu";
            btnBackToMainMenu.Size = new Size(140, 30);
            btnBackToMainMenu.TabIndex = 9;
            btnBackToMainMenu.Text = "Back to Main Menu";
            btnBackToMainMenu.UseVisualStyleBackColor = true;
            btnBackToMainMenu.Click += btnBackToMainMenu_Click;
            // 
            // ServiceRequestStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(860, 525);
            Controls.Add(btnBackToMainMenu);
            Controls.Add(lblEngineInfo);
            Controls.Add(dtGridMST);
            Controls.Add(lblMstTitle);
            Controls.Add(dtGridStatus);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchId);
            Controls.Add(lblTrackId);
            Controls.Add(lblTitle);
            Name = "ServiceRequestStatus";
            Text = "Service Request Status";
            Load += ServiceRequestStatus_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGridMST).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTrackId;
        private TextBox txtSearchId;
        private Button btnSearch;
        private Button btnShowAll;
        private DataGridView dtGridStatus;
        private Label lblMstTitle;
        private DataGridView dtGridMST;
        private Label lblEngineInfo;
        private Button btnBackToMainMenu;
    }
}