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
            announcements announcementsForm = new announcements();
            announcementsForm.Show();
            this.Hide();
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            ServiceRequestStatus serviceRequestStatus = new ServiceRequestStatus();
            serviceRequestStatus.Show();
            this.Hide();    

        }

    }
}
