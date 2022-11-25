using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
using System.DirectoryServices;

namespace GUI
{
    public partial class FormSelection : Form
    {
        BugsSearch bugSearchTool = new BugsSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        CreatorSearch creatorSearchTool = new CreatorSearch();
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
                searchedId = Int32.Parse(txtBugId.Text);
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
                searchedName = txtName.Text;
            }
            if (!txtDescription.Text.IsNullOrEmpty())
            {
                searchedDesc = txtDescription.Text;
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

        //Open the FormPerson with the creator informations
        private void btnSelect_Click(object sender, EventArgs e)
        {
            int creatorId = 0;
            if (dgvBugsList.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select only one row at the time", "TOO MANY ROWS SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(DataGridViewRow row in dgvBugsList.SelectedRows)
                {
                    creatorId = Int32.Parse(row.Cells["CreatorId"].Value.ToString());
                }
                formPerson creatorInfo = new formPerson(creatorId);
                creatorInfo.Show();
                btnSelect.Enabled=false;
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
            txtBugId.Text = "";
            comboCreator.SelectedIndex = 0;
            txtDescription.Text = "";
            txtName.Text = "";
            radSolvedNo.Checked = false;
            radSolvedYes.Checked = false;
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
            btnSelect.Enabled = false;
            comboCreator.DataSource = creatorSearchTool.RetrieveCreatorIdAndName();
        }

    }
}