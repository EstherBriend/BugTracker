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
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class FormBug : Form
    {
        BugsAdd bugAddTool = new BugsAdd();
        BugsSearch bugSearchTool = new BugsSearch();
        LogsAdd logsAddTool = new LogsAdd();
        LogSearch logSearchTool = new LogSearch();
        MessageSearch messageSearchTool = new MessageSearch();
        PersonSearch personSearchTool = new PersonSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();

        List<string> bugInfo;
        string[] personInfo;
        DateTime todayDate = DateTime.Now;
        private int bugId;
        string solvedImageSrc = "C:\\Users\\esbri\\Documents\\01 - AEC\\03 - Troisieme semestre\\05 - Multi-tier applications\\03 - Devoirs_Examens\\Final_lab\\2130546_FinalProject\\Images\\checkMarckSmall.png";
        string unsolvedImageSrc = "C:\\Users\\esbri\\Documents\\01 - AEC\\03 - Troisieme semestre\\05 - Multi-tier applications\\03 - Devoirs_Examens\\Final_lab\\2130546_FinalProject\\Images\\crossSmall.png";

        FormSelection selectionForm; 

        public FormBug(int bugId, FormSelection form)
        {
            InitializeComponent();
            //Assigning bug id parameter and form selection value
            this.bugId = bugId;
            this.selectionForm = form;

            // ---------------- Initialize Combo Box ------------------------------
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();

            // ---------------- Retrieve Bug Infos and creator Infos -----------------
            bugInfo = bugSearchTool.SearchBugsById(bugId);
            personInfo = personSearchTool.SearchById(Int32.Parse(bugInfo[2]));

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
                imgValidation.Image = Image.FromFile(solvedImageSrc);
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

            // ---------------- Make save and cancel button unavailable before Edit ------------------
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.ReadOnly = false;
            txtDescription.ReadOnly = false;
            comboPriority.Enabled = true;
            comboSeverity.Enabled = true;
            radSolvedYes.Enabled = true;
            radSolvedNo.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            lblName.Text = "Name *";
            lblInfoMandatoryField.Visible = true;
            btnEdit.Enabled = false;
            btnAddBug.Enabled = false;
            txtName.BackColor = SystemColors.Window;
        }

        private void BackToReadOnly()
        {
            txtName.ReadOnly = true;
            txtDescription.ReadOnly = true;
            comboPriority.Enabled = false;
            comboSeverity.Enabled = false;
            radSolvedYes.Enabled = false;
            radSolvedNo.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            btnAddBug.Enabled = true;
            txtName.BackColor = SystemColors.Menu;
            lblName.Text = "Name";
            if (radSolvedYes.Checked)
            {
                imgValidation.Image = Image.FromFile(solvedImageSrc);
            }
            else
            {
                imgValidation.Image = Image.FromFile(unsolvedImageSrc);
            }

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
            bugInfo = bugSearchTool.SearchBugsById(bugId);
            BackToReadOnly();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //-------- Back to the original value --------------------
            txtName.Text = bugInfo[0];
            txtDescription.Text = bugInfo[1];
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
            if (bugInfo.Count == 8)
            {
                txtLastEditDate.Text = bugInfo[7];
            }
            else
            {
                txtLastEditDate.Text = "No edit made since creation";
            }

            //---------- Back to read only ----------------------------
            BackToReadOnly();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //----------- Verify mandatory fiels is not empty ---------------------
            if (txtName.Text.IsNullOrEmpty())
            {
                txtName.BackColor = Color.LightPink;
                btnSave.Enabled = false;
                lblInfoMandatoryField.ForeColor = Color.Red;
                lblInfoMandatoryField.Font = new Font(lblInfoMandatoryField.Font, FontStyle.Bold | FontStyle.Italic);
            }
            // ------------------------------------ Send the form informations to the Business layer ------------------------------------
            else
            {
                //----------- Verify solved status ---------------------
                bool solved = false;
                if (radSolvedYes.Checked)
                {
                    solved = true;
                }
                // Add new bug
                bugAddTool.updateBug(Int32.Parse(txtBugId.Text), txtName.Text, txtDescription.Text, comboPriority.SelectedIndex + 1, comboSeverity.SelectedIndex + 1, solved);
                MessageBox.Show("bug updated!", "BUG UPDATED", MessageBoxButtons.OK);
                
                //Add new log
                logsAddTool.addBugUpdateLog(bugId);
                reset();

                // Change last edit date and reset form 
                txtLastEditDate.Text = DateTime.Now.ToShortDateString();
                reset();

                //reset selection form
                selectionForm.reset();
                
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = SystemColors.Window;
            btnSave.Enabled = true;
            lblInfoMandatoryField.ForeColor = Color.Black;
            lblInfoMandatoryField.Font = new Font(lblInfoMandatoryField.Font, FontStyle.Italic);
        }

        private void btnCreatorInfos_Click(object sender, EventArgs e)
        {
            formPerson creatorInfo = new formPerson(Int32.Parse(bugInfo[2]));
            creatorInfo.Show();
        }

        private void btnAddBug_Click(object sender, EventArgs e)
        {
            FormAddBugs newFormAddBugs = new FormAddBugs();
            newFormAddBugs.selectionForm = this.selectionForm;
            newFormAddBugs.Show();
            this.Close();
        }
    }
}
