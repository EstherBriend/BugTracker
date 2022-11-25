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

        public FormAddBugs()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            selectionForm.reset();
            selectionForm.Show();
            this.Close();
        }

        
    }
}
