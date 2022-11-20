using BusinessLayer;

namespace GUI
{
    public partial class FormSelection : Form
    {
        BugsSearch bugSearchTool = new BugsSearch();
        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        public FormSelection()
        {
            InitializeComponent();
            dgvBugsList.DataSource = bugSearchTool.RetrieveAllBugs();
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();

        }
    }
}