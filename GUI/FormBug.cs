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

namespace GUI
{
    public partial class FormBug : Form
    {
        BugsSearch bugDataManager = new BusinessLayer.BugsSearch();
        public FormBug()
        {
            InitializeComponent();
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
