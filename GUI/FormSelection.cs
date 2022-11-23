using BusinessLayer;
using Microsoft.IdentityModel.Tokens;

namespace GUI
{
    public partial class FormSelection : Form
    {
        BugsSearch bugSearchTool = new BugsSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        CreatorSearch creatorSearchTool = new BusinessLayer.CreatorSearch();
        public FormSelection()
        {
            InitializeComponent();
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();
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
            comboPriority.SelectedIndex = 0;
            comboSeverity.SelectedIndex = 0;
            txtBugId.Text = "";
            comboCreator.SelectedIndex = 0;
            txtDescription.Text = "";
            txtName.Text = "";
            radSolvedNo.Checked = false;
            radSolvedYes.Checked = false;
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
        }

    }
}