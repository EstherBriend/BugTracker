using BusinessLayer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormAddBugs : Form
    {
        public FormSelection selectionForm { get; set; }

        PrioritySearch prioritySearchTool = new PrioritySearch();
        SeveritySearch severitySearchTool = new SeveritySearch();
        PersonSearch personSearchTool = new PersonSearch();
        BugsAdd bugsAddTool = new BugsAdd();

        bool btnAddHasBeenClicked = false;

        public FormAddBugs()
        {
            InitializeComponent();
            comboPriority.DataSource = prioritySearchTool.RetrieveAllPriorityName();
            comboPriority.SelectedIndex = -1;
            comboSeverity.DataSource = severitySearchTool.RetrieveAllSeverityName();
            comboSeverity.SelectedIndex = -1;

            lblInfoMandatoryFields.ForeColor = Color.Black;
            lblInfoMandatoryFields.Font = new Font(lblInfoMandatoryFields.Font, FontStyle.Italic);
        }

        // ------------------------------------ Reset the selection form to includes eventually added bugs and show it, then, close the add Form ---------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            selectionForm.reset();
            selectionForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddHasBeenClicked = true;

            // ------------------------------------ Verify that the mandatory fields have been fullfield -----------------------------------------
            if (txtCreatorId.Text.IsNullOrEmpty() || txtName.Text.IsNullOrEmpty() || comboSeverity.SelectedIndex == -1 || comboPriority.SelectedIndex == -1)
            {
                changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
                if (txtCreatorId.Text.IsNullOrEmpty())
                {
                    txtCreatorId.BackColor = Color.LightPink;
                }
                if (txtName.Text.IsNullOrEmpty())
                {
                    txtName.BackColor = Color.LightPink;
                }
                if (comboSeverity.SelectedIndex == -1)
                {
                    comboSeverity.BackColor = Color.LightPink;
                }
                if (comboPriority.SelectedIndex == -1)
                {
                    comboPriority.BackColor = Color.LightPink;
                }
            }
            else
            {
                int creatorIdToAdd = 0;
                // ------------------------------------ Verify that the creator Id is in correct format (only numbers) ---------------------------
                try
                {
                    creatorIdToAdd = Int32.Parse(txtCreatorId.Text);
                }
                catch
                {
                    MessageBox.Show("The ID you enter is invalid.\nPlease, enter an ID composed of only numbers.", "INVALID ID", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                // ------------------------------------ Verify that the creator Id exist in the database -------------------------------------
                if (creatorIdToAdd != 0)
                {
                    if (personSearchTool.SearchById(creatorIdToAdd) == null)
                    {
                        MessageBox.Show("The ID you enter does not exist. Please, enter a new Id.", "ID NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // ------------------------------------ Send the form informations to the Business layer ------------------------------------
                    else
                    {
                        string nameToAdd = txtName.Text;
                        string descToAdd = txtDescription.Text;
                        int priorityIdToAdd = comboPriority.SelectedIndex + 1;
                        int severityIdToAdd = comboSeverity.SelectedIndex + 1;
                        bugsAddTool.addBugInDb(creatorIdToAdd, nameToAdd, descToAdd, priorityIdToAdd, severityIdToAdd);
                        MessageBox.Show("New bug added", "NEW BUG", MessageBoxButtons.OK);

                    }
                }

            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCreatorId.Text = "";
            txtCreatorId.BackColor = SystemColors.Window;
            txtName.Text = "";
            txtName.BackColor = SystemColors.Window;
            comboPriority.SelectedIndex = -1;
            comboPriority.BackColor = SystemColors.Window;
            comboSeverity.SelectedIndex = -1;
            comboSeverity.BackColor = SystemColors.Window;
            txtDescription.Text = "";
        }

        // ------------------------------------ Reverse mandatory fields text box color when fulfill ---------------------------
        private void txtCreatorId_TextChanged(object sender, EventArgs e)
        {
            txtCreatorId.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void comboPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPriority.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void comboSeverity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSeverity.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill()
        {
            if ((txtCreatorId.Text.IsNullOrEmpty() || txtName.Text.IsNullOrEmpty() || comboSeverity.SelectedIndex == -1 || comboPriority.SelectedIndex == -1) && btnAddHasBeenClicked)
            {
                lblInfoMandatoryFields.ForeColor = Color.Red;
                lblInfoMandatoryFields.Font = new Font(lblInfoMandatoryFields.Font, FontStyle.Bold | FontStyle.Italic);
                btnAdd.Enabled = false;
            }
            else
            {
                lblInfoMandatoryFields.ForeColor = Color.Black;
                lblInfoMandatoryFields.Font = new Font(lblInfoMandatoryFields.Font, FontStyle.Italic);
                btnAdd.Enabled = true;
            }
        }
    }
}
