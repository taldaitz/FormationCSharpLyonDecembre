using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnuaireWinForm
{
    public partial class MainForm : Form
    {
        public List<string> contacts;

        public MainForm()
        {
            InitializeComponent();
            contacts = new List<string>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string contact = String.Format("{0}|{1}|{2}", 
                                            this.nomTextBox.Text,
                                            this.prenomTextBox.Text,
                                            this.phoneTextBox.Text);
            contacts.Add(contact);

            this.nomTextBox.Text = "";
            this.prenomTextBox.Text = "";
            this.phoneTextBox.Text = "";

            printedContactsLabel.Text = contact;

          
        }

        private void SaveContacts(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("toto");
            listBox1.Items.Add("tata");
            listBox1.Items.Add("tutu");
            listBox1.Refresh();
        }
    }
}
