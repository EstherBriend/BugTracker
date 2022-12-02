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
        LogSearch logSearchTool = new LogSearch();
        MessageSearch messageSearchTool = new MessageSearch();
        PersonSearch personSearchTool = new PersonSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();

        private int bugId;
        public FormBug(int bugId)
        {
            InitializeComponent();
            //Assigning bug id parameter value
            this.bugId = bugId;

            // ---------------- Initialize Combo Box ------------------------------
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();

            // ---------------- Retrieve Bug Infos and creator Infos -----------------
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
            // ---------------- Retrieve messages associated with the bug --------------
            dgvMessages.DataSource = messageSearchTool.SearchByBugId(bugId);
            //Modify column's header text
            dgvMessages.Columns[5].HeaderText = "creatorId";
                //Hide some of the columns
            dgvMessages.Columns[1].Visible = false;
            dgvMessages.Columns[3].Visible = false;
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
            formMessage addMessage = new formMessage(this.bugId, true, this);
            addMessage.Show();
            this.Hide();
        }

        // ---------------- Open a read only message form when a row of the grid view is selected ------------------
        private void dgvMessages_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int messageId = -1;
            if (dgvMessages.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select only one row at the time", "TOO MANY ROWS SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvMessages.SelectedRows)
                {
                    messageId = Int32.Parse(row.Cells["id"].Value.ToString());
                }
                formMessage messageInfo = new formMessage(messageId, false,this);
                messageInfo.Show();
   
            }

        }

        public void reset()
        {
            dgvMessages.DataSource = messageSearchTool.SearchByBugId(bugId);
            richTxtLogs.Text = logSearchTool.SearchLogByBugId(bugId);

        }

    }
}
