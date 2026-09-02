namespace Community_Watcher
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            frmReportIssue frmReportIssues = new frmReportIssue();
            frmReportIssues.Show();
            this.Hide();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Constuction", "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Constuction",
            "Warning",MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
           
        }

    }
}
