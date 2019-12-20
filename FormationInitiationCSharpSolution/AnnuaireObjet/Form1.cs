using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetContact;

namespace AnnuaireObjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxType.SelectedItem = "Contact";

            List<Contact> contacts = AnnuaireManager.getAllContacts();
            foreach (Contact contact in contacts)
            {
                if (contact == null)
                    continue;

                listView1.Items.Add(new ListViewItem(new string[] { contact.nom,
                    contact.prenom,
                    contact.email,
                    contact.telephone,
                    contact.GetType().Name
                }));
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string email = textBoxEmail.Text;
            string telephone = textBoxPhone.Text;
            bool isTelPrefered = checkBoxTelPrefered.Checked;

            string type = comboBoxType.SelectedItem.ToString();

            DateTime dateNaissance = dateTimePickerNaissance.Value;
            string ville = textBoxVille.Text;

            string societe = textBoxSociete.Text;
            string poste = textBoxPoste.Text;

            Contact contact;

            switch(type)
            {
                case "Ami":
                    contact = new Ami(nom, prenom, isTelPrefered, email, telephone, dateNaissance, ville);
                    contact.save();
                    break;

                case "ContactPro":
                    contact = new ContactPro(prenom, nom, societe, email, telephone, isTelPrefered, poste);
                    contact.save();
                    break;

                case "Famille":
                    contact = new MembreFamille(nom, prenom, isTelPrefered, email, telephone, dateNaissance, "parent", true, true);
                    contact.save();
                    break;
            }


            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            checkBoxTelPrefered.Checked = true;
            
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedItem.ToString() == "ContactPro")
            {
                labelSociete.Visible = true;
                labelPoste.Visible = true;
                textBoxSociete.Visible = true;
                textBoxPoste.Visible = true;
            }  else
            {
                labelSociete.Visible = false;
                labelPoste.Visible = false;
                textBoxSociete.Visible = false;
                textBoxPoste.Visible = false;
            }
        }
    }
}
