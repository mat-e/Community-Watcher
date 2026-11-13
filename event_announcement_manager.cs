using Community_Watcher.Models;
using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community_Watcher
{
    public partial class event_announcement_manager : Form
    {
        public event_announcement_manager()
        {
            InitializeComponent();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            announcements announcementsForm = new announcements();
            announcementsForm.Show();
            this.Hide();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string name = txtEventName.Text.Trim();
            string category = cboxCategory.Text.Trim();
            string location = txtLocation.Text.Trim();
            string summary = rtxtSummary.Text.Trim();

            if (name.Length == 0)
            {
                ShowError("Enter an event name.", txtEventName);
                return;
            }

            if (category.Length == 0)
            {
                ShowError("Choose or type a category.", cboxCategory);
                return;
            }

            if (location.Length == 0)
            {
                ShowError("Enter a location.", txtLocation);
                return;
            }

            if (summary.Length == 0)
                summary = "No summary provided.";

            Event created = new Event
            {
                Id = DataStore.Manager.GetNextId(),
                Type = "Event",
                Name = name,
                Category = category,
                Date = dateEventsManager.Value.Date,
                Location = location,
                Description = summary,
                Priority = 3
            };

            DataStore.Manager.AddEvent(created);
            DataStore.LastAdded = created;

            if (!cboxCategory.Items.Contains(category))
                cboxCategory.Items.Add(category);

            txtEventName.Clear();
            txtLocation.Clear();
            rtxtSummary.Clear();
            cboxCategory.Text = string.Empty;
            dateEventsManager.Value = DateTime.Today;

            MessageBox.Show("Event added: " + name, "Event saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            string heading = txtHeading.Text.Trim();
            string body = rtxtBody.Text.Trim();

            if (heading.Length == 0)
            {
                ShowError("Enter a heading.", txtHeading);
                return;
            }

            if (body.Length == 0)
            {
                ShowError("Enter the announcement text.", rtxtBody);
                return;
            }

            Event created = new Event
            {
                Id = DataStore.Manager.GetNextId(),
                Type = "Announcement",
                Name = heading,
                Category = "Announcement",
                Date = DateTime.Today,
                Location = "Municipality",
                Description = body,
                Priority = 2
            };

            DataStore.Manager.AddEvent(created);
            DataStore.LastAdded = created;

            txtHeading.Clear();
             rtxtBody.Clear();

            MessageBox.Show("Announcement added: " + heading, "Announcement saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
