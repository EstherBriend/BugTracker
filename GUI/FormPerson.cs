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
    public partial class formPerson : Form
    {
        PersonSearch personSearchTool = new PersonSearch();
        public formPerson(int personId)
        {
            InitializeComponent();
            string [] personInfo = personSearchTool.SearchById(personId);
            txtId.Text = personId.ToString();
            txtFirstName.Text = personInfo[0];
            txtLastName.Text = personInfo[1];
            txtAddress.Text = personInfo[2];
            txtEmail.Text = personInfo[3];
            txtDateOfBirth.Text = personInfo[4];
            txtJobTitle.Text = personInfo[5];
            txtYearOfExperience.Text = personInfo[6];
            txtSalary.Text = personInfo[7];
            txtHiredDate.Text = personInfo[8];
   

        }


        private void lblYearsExp_Click(object sender, EventArgs e)
        {

        }
    }
}
