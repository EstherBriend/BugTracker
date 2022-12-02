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
using System.Xml.Linq;

namespace GUI
{
    public partial class formMessage : Form
    {
        MessageSearch messageSearchTool = new MessageSearch();
        MessageAdd messageAddTool = new MessageAdd();
        PersonSearch personSearchTool = new PersonSearch();

        DateTime todayDate = DateTime.Now;
        bool btnAddHasBeenClicked = false;
        string creatorTxtBoxPlaceHolder = "Please, enter only your id";
        FormBug bugForm;
        public formMessage(int messageOrBugId, bool newMessage, FormBug bugForm)
        {
            this.bugForm = bugForm;

            InitializeComponent();


            // ---------------- Prepare the Form for read only -----------------
            lblMessage.Text = newMessage.ToString();

            if (!newMessage)
            {
                // ---------------- Retrieve Message and Creator Infos -----------------
                string[] messageInfos = messageSearchTool.SearchByMessageId(messageOrBugId);
                string[] personInfos = personSearchTool.SearchById(Int32.Parse(messageInfos[2]));

                // ---------------- Fullfill text Box --------------------
                txtId.Text = messageInfos[0];
                txtBugId.Text = messageInfos[1];
                txtCreator.Text = $"{personInfos[0]} {personInfos[1]}";
                txtCreationDate.Text = messageInfos[3];
                txtTitle.Text = messageInfos[4];
                txtText.Text = messageInfos[5];
            }

            // ---------------- Prepare the Form for adding --------------
            else
            {
                // ---------------- Change title ---------------------
                lblMessage.Text = "Add message";
 
                // ---------------- Hide Id text box and show mandatory fields label ---------------------
                lblId.Visible = false;
                txtId.Visible = false;
                lblInfoMandatoryFields.Visible = true;

                // ---------------- Make add and reset buttons visible --------------
                btnAdd.Visible = true;
                btnReset.Visible = true;

                // ---------------- Make text box editable ---------------
                txtCreator.ReadOnly = false;
                txtTitle.ReadOnly = false;
                txtText.ReadOnly = false;

                //---------------- Fulfill given data --------------------
                txtBugId.Text = messageOrBugId.ToString();
                txtCreationDate.Text = todayDate.ToShortDateString();

                //---------------- Show mandatory fields --------------------
                lblCreator.Text += " *";
                lblTitle.Text += " *";
                lblText.Text += " *";

                //---------------- Place holder to ask only for the id in the Creator text box --
                txtCreator.Text = creatorTxtBoxPlaceHolder;
            }

        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCreator.Text = creatorTxtBoxPlaceHolder;
            txtCreator.BackColor = SystemColors.Window;
            txtTitle.Clear();
            txtTitle.BackColor = SystemColors.Window;
            txtText.Clear();
            txtText.BackColor = SystemColors.Window;
            lblInfoMandatoryFields.ForeColor = Color.Black;
            lblInfoMandatoryFields.Font = new Font(lblInfoMandatoryFields.Font, FontStyle.Regular | FontStyle.Regular);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAddHasBeenClicked = true;

            // ------------------------------------ Verify that the mandatory fields have been fullfield -----------------------------------------
            if (txtCreator.Text.IsNullOrEmpty() ||txtTitle.Text.IsNullOrEmpty()||txtText.Text.IsNullOrEmpty()||txtCreator.Text == creatorTxtBoxPlaceHolder)
            {
                changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();

                if (txtCreator.Text.IsNullOrEmpty() || txtCreator.Text == creatorTxtBoxPlaceHolder)
                {
                    txtCreator.BackColor = Color.LightPink;
                }
                if (txtTitle.Text.IsNullOrEmpty())
                {
                    txtTitle.BackColor = Color.LightPink;
                }
                if (txtText.Text.IsNullOrEmpty())
                {
                    txtText.BackColor = Color.LightPink;
                }
            }
            else
            {
                int creatorIdToAdd = 0;
                // ------------------------------------ Verify that the creator Id is in correct format (only numbers) ---------------------------
                try
                {
                    creatorIdToAdd = Int32.Parse(txtCreator.Text);
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
                        int bugIdToAdd = Int32.Parse(txtBugId.Text);
                        string titleToAdd = txtTitle.Text;
                        string txtToAdd = txtText.Text;
                        messageAddTool.addMessageInDb(bugIdToAdd,todayDate,creatorIdToAdd,titleToAdd, txtToAdd);
                        MessageBox.Show("New message added", "NEW MESSAGE", MessageBoxButtons.OK);

                    }
                }

            }

        }

        // ------------------------------------ Reverse mandatory fields text box color when fulfill ---------------------------



        private void changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill()
        {
            if ((txtCreator.Text.IsNullOrEmpty() || txtTitle.Text.IsNullOrEmpty() || txtText.Text.IsNullOrEmpty()) && btnAddHasBeenClicked)
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


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtTitle.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            txtText.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void txtCreator_MouseClick(object sender, MouseEventArgs e)
        {
            //---------------- Delete place holder when text box click -------
            if (txtCreator.Text == creatorTxtBoxPlaceHolder)
            {
                txtCreator.Clear();
            }

            txtCreator.BackColor = SystemColors.Window;
            changeMandatoryFieldsLabelAndBtnAddDependingOnTheFulfill();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            bugForm.reset();
            bugForm.Show();
            this.Close();
        }
    }
}
