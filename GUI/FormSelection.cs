using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
using System.DirectoryServices;

namespace GUI
{
    public partial class FormSelection : Form
    {
        BugsSearch bugSearchTool = new BugsSearch();
        CreatorSearch creatorSearchTool = new CreatorSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        
        public FormSelection()
        {
            InitializeComponent();
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
            //dgvBugsList.Columns["creator"].Visible = false;
            comboPriority.DataSource = prioritySearchTool.RetrievAllPrioritiesPlusAny();
            comboSeverity.DataSource = severitySearchTool.RetrievAllSeveritiesPlusAny();
            comboCreator.DataSource = creatorSearchTool.RetrieveCreatorIdAndName();
            btnSelect.Enabled = false;
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int searchedId = -1;
            string searchedName = "";
            string searchedDesc = "";
            int searchedCreatorId = -1;
            int searchedPriority = -1;
            int searchedSeverity = -1;
            string isSolved = "";
            DateTime searchedCreationDate = DateTime.Now.AddYears(-1);
            DateTime searchedModificationDate = DateTime.Now.AddYears(-1);

            if (!txtBugId.Text.IsNullOrEmpty())
            {
                try
                {
                    searchedId = Int32.Parse(txtBugId.Text);
                }
                catch
                {
                    searchedId = -1;
                    MessageBox.Show("Sorry, Bug Id can only be numbers!\nThis element has been taken out of your search criterias.", "ERROR BUG ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if(comboCreator.SelectedIndex != 0)
            {
                string[] splittedCreatorComboBox = comboCreator.SelectedValue.ToString().Split(" ");
                searchedCreatorId = Int32.Parse(splittedCreatorComboBox[0]);
            }
            if(searchedCreationDate != DateTime.Now)
            {
                searchedCreationDate = timeCreationDate.Value;
            }
            if(searchedModificationDate!= DateTime.Now)
            {
                searchedModificationDate = timeModificationDate.Value;
            }
            if(comboPriority.SelectedIndex != 0)
            {
                searchedPriority = comboPriority.SelectedIndex;
            }
            if(comboSeverity.SelectedIndex != 0)
            {
                searchedSeverity = comboSeverity.SelectedIndex;
            }
            if (!txtName.Text.IsNullOrEmpty())
            {
                searchedName = txtName.Text.ToLower();
            }
            if (!txtDescription.Text.IsNullOrEmpty())
            {
                searchedDesc = txtDescription.Text.ToLower();
            }
            if (radSolvedYes.Checked)
            {
                isSolved = "true";
            }
            if (radSolvedNo.Checked)
            {
                isSolved = "false";
            }

            dgvBugsList.DataSource = bugSearchTool.SearchBugs(searchedId, searchedCreatorId,searchedCreationDate, searchedModificationDate, searchedName, searchedDesc,searchedPriority, searchedSeverity, isSolved);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        //Open the FormPerson with the creator informations and the form Bug
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int creatorId = -1;
            int bugId = -1;
            if (dgvBugsList.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select only one row at the time", "TOO MANY ROWS SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(DataGridViewRow row in dgvBugsList.SelectedRows)
                {
                    creatorId = Int32.Parse(row.Cells["CreatorId"].Value.ToString());
                    bugId = Int32.Parse(row.Cells["id"].Value.ToString());
                }

                FormBug bugInfo = new FormBug(bugId, this);
                bugInfo.Show();

            }
        }

        private void dgvBugsList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSelect.Enabled = true;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddBugs newFormAddBugs = new FormAddBugs();
            newFormAddBugs.selectionForm = this;
            newFormAddBugs.Show();
            this.Hide();
        }

        public void reset()
        {
            comboPriority.SelectedIndex = 0;
            comboSeverity.SelectedIndex = 0;
            txtBugId.Clear();
            comboCreator.SelectedIndex = 0;
            txtDescription.Clear();
            txtName.Clear();
            radSolvedNo.Checked = false;
            radSolvedYes.Checked = false;
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
            btnSelect.Enabled = false;
            comboCreator.DataSource = creatorSearchTool.RetrieveCreatorIdAndName();
            timeModificationDate.Value = DateTime.Now;
            timeCreationDate.Value = DateTime.Now;
        }

    }
}