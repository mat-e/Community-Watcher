using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Community_Watcher.DataStructures;
using Community_Watcher.Models;

namespace Community_Watcher
{
    public partial class ServiceRequestStatus : Form
    {
        public ServiceRequestStatus()
        {
            InitializeComponent();
        }

        private void ServiceRequestStatus_Load(object sender, EventArgs e)
        {
            SetupStatusGrid();
            SetupMstGrid();
            LoadAllRequests();
            LoadMstNetwork();
        }

        private void SetupStatusGrid()
        {
            dtGridStatus.Columns.Clear();
            dtGridStatus.AutoGenerateColumns = false;
            dtGridStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridStatus.MultiSelect = false;
            dtGridStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID #", DataPropertyName = "Id", FillWeight = 45 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "Category", FillWeight = 110 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Location", DataPropertyName = "Location", FillWeight = 100 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "StatusDisplay", FillWeight = 115 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Priority", DataPropertyName = "PriorityLabel", FillWeight = 85 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Assigned Depot", DataPropertyName = "AssignedDepot", FillWeight = 100 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Date Logged", DataPropertyName = "DateFormatted", FillWeight = 85 });
            dtGridStatus.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Description", DataPropertyName = "Description", FillWeight = 150 });
        }

        private void SetupMstGrid()
        {
            dtGridMST.Columns.Clear();
            dtGridMST.AutoGenerateColumns = false;
            dtGridMST.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridMST.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtGridMST.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Depot A", DataPropertyName = "Source", FillWeight = 120 });
            dtGridMST.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Depot B", DataPropertyName = "Destination", FillWeight = 120 });
            dtGridMST.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Distance", DataPropertyName = "DistanceDisplay", FillWeight = 90 });
        }

        private void LoadAllRequests()
        {
            dtGridStatus.DataSource = null;
            dtGridStatus.DataSource = StatusRepository.PriorityHeap.ToSortedList();
        }

        private void LoadMstNetwork()
        {
            List<Edge> mstEdges = StatusRepository.ServiceGraph.GetMinimumSpanningTree();
            var displayEdges = mstEdges.Select(e => new
            {
                e.Source,
                e.Destination,
                DistanceDisplay = $"{e.Weight} km"
            }).ToList();

            dtGridMST.DataSource = null;
            dtGridMST.DataSource = displayEdges;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text.Trim().Replace("#", ""), out int searchId))
            {
                ServiceRequest? result = StatusRepository.ServiceTree.Search(searchId);
                if (result != null)
                {
                    dtGridStatus.DataSource = null;
                    dtGridStatus.DataSource = new List<ServiceRequest> { result };
                }
                else
                {
                    MessageBox.Show($"Service Request #{searchId} was not found in the Binary Search Tree index.",
                        "Request Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Reference ID.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearchId.Clear();
            LoadAllRequests();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenuForm = new frmMainMenu();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}