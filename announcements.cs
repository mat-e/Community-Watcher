using Community_Watcher.Models;
using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Community_Watcher
{
    public partial class announcements : Form
    {
        public announcements()
        {
            InitializeComponent();

            // Configure ListView columns and full row select
            lstEvents.View = View.Details;
            lstEvents.FullRowSelect = true;
            if (lstEvents.Columns.Count == 0)
            {
                lstEvents.Columns.Add("Event Name", 220);
                lstEvents.Columns.Add("Category", 100);
                lstEvents.Columns.Add("Date", 90);
            }

            // Hook up Form Load event
            this.Load += Announcements_Load;
        }

        private void Announcements_Load(object? sender, EventArgs e)
        {
            DataStore.EnsureLoaded();
            PopulateCategories();
            ResetDateRange();

            // If an event was recently added in Manager, widen date bounds to show it
            if (DataStore.LastAdded != null)
            {
                if (DataStore.LastAdded.Date < dateFrom.Value)
                    dateFrom.Value = DataStore.LastAdded.Date;
                if (DataStore.LastAdded.Date > dateTo.Value)
                    dateTo.Value = DataStore.LastAdded.Date;
            }

            PerformSearch();
        }

        private void PopulateCategories()
        {
            cboxCategories.Items.Clear();
            cboxCategories.Items.Add("All Categories");

            var categories = DataStore.Manager.GetCategories();
            foreach (var category in categories)
            {
                if (!cboxCategories.Items.Contains(category))
                {
                    cboxCategories.Items.Add(category);
                }
            }

            cboxCategories.SelectedIndex = 0;
        }

        private void ResetDateRange()
        {
            dateFrom.Value = DateTime.Today.AddDays(-7);
            dateTo.Value = DateTime.Today.AddDays(30);
        }

        private void PerformSearch()
        {
            string selectedCat = cboxCategories.SelectedItem?.ToString() ?? "All Categories";
            DateTime from = dateFrom.Value.Date;
            DateTime to = dateTo.Value.Date;

            List<Event> results;

            if (selectedCat == "All Categories")
            {
                results = DataStore.Manager.SearchByDateRange(from, to);
            }
            else
            {
                results = DataStore.Manager.SearchByCategoryAndDate(selectedCat, from, to);
            }

            lstEvents.Items.Clear();
            foreach (var ev in results)
            {
                var item = new ListViewItem(ev.Name);
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.Date.ToString("yyyy-MM-dd"));
                item.Tag = ev;
                lstEvents.Items.Add(item);
            }
        }

        private void btnSearch_Click(object? sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            cboxCategories.SelectedIndex = 0;
            ResetDateRange();
            PerformSearch();
        }

        private void lstEvents_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstEvents.SelectedItems.Count > 0)
            {
                if (lstEvents.SelectedItems[0].Tag is Event selectedEvent)
                {
                    DataStore.Manager.RecordView(selectedEvent);
                }
            }
        }

        private void btnMainMenu_Click(object? sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            mainMenuForm.Show();
            this.Hide(); 
        }

        private void btnManager_Click(object? sender, EventArgs e)
        {
            event_announcement_manager event_Announcement_Manager = new event_announcement_manager();
            event_Announcement_Manager.Show();
            this.Hide();
        }
    }
}