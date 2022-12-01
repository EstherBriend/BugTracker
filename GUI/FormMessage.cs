using BusinessLayer;
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
    public partial class formMessage : Form
    {
        MessageSearch messageSearchTool = new MessageSearch();
        PersonSearch personSearchTool = new PersonSearch();
        public formMessage(int messageId)
        {
            InitializeComponent();

            // ---------------- Retrieve Message and Creator Infos -----------------
            string[] messageInfos = messageSearchTool.SearchByMessageId(messageId);
            string[] personInfos = personSearchTool.SearchById(Int32.Parse(messageInfos[2]));

            // ---------------- Fullfill text Box --------------------
            txtId.Text = messageInfos[0];
            txtBugId.Text = messageInfos[1];
            txtCreator.Text = $"{personInfos[0]} {personInfos[1]}";
            txtCreationDate.Text = messageInfos[3];
            txtTitle.Text = messageInfos[4];
            txtText.Text = messageInfos[5];
        }

    }
}
