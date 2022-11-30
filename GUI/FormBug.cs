using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccess;

namespace GUI
{
    public partial class FormBug : Form
    {
        BugsSearch bugSearchTool = new BusinessLayer.BugsSearch();
        PersonSearch personSearchTool = new PersonSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        MessageSearch messageSearchTool = new MessageSearch();
        LogSearch logSearchTool = new LogSearch();
        public FormBug(int bugId)
        {
            InitializeComponent();

            // ---------------- Initialize Combo Box ------------------------------
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();

            // ---------------- Retrieve Bug Info and creator Info -----------------
            List<string> bugInfo = bugSearchTool.SearchBugsById(bugId);
            string[] personInfo = personSearchTool.SearchById(Int32.Parse(bugInfo[2]));

            // ---------------- Fullfill text Box and Combo box --------------------
            txtBugId.Text = bugId.ToString();
            txtName.Text = bugInfo[0];
            txtDescription.Text = bugInfo[1];
            txtCreator.Text = $"{personInfo[0]} {personInfo[1]}";
            txtCreationDate.Text = bugInfo[5];
            if(bugInfo.Count == 8)
            {
                txtLastEditDate.Text = bugInfo[7];
            }
            else
            {
                txtLastEditDate.Text = "No edit made since creation";
            }
            comboPriority.SelectedIndex = Int32.Parse(bugInfo[3]) - 1;
            comboSeverity.SelectedIndex = Int32.Parse(bugInfo[4]) - 1;
            if (bugInfo[6] == "false")
            {
                radSolvedNo.Checked = true;
            }
            else
            {
                radSolvedYes.Checked = true;
            }
            // ---------------- Retrieve messages associated with the bug ------------------
            dgvMessages.DataSource = messageSearchTool.SearchByBugId(bugId);

            // ---------------- Retrieve log associated with the bug ------------------
            richTxtLogs.Text = logSearchTool.SearchLogByBugId(bugId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtDescription.ReadOnly = false;
            comboPriority.Enabled = true;
            comboSeverity.Enabled = true;
            radSolvedYes.Enabled = true;
            radSolvedNo.Enabled = true;
        }

        private void BackToReadOnly()
        {
            txtName.ReadOnly = true;
            txtDescription.ReadOnly = true;
            comboPriority.Enabled = false;
            comboSeverity.Enabled = false;
            radSolvedYes.Enabled = false;
            radSolvedNo.Enabled = false;

        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {

        }

    }
}
