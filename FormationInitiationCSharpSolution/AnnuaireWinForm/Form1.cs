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

namespace AnnuaireWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshListContact();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string nomContact = textBoxNom.Text;
            string prenomContact = textBoxPrenom.Text;
            string emailContact = textBoxEmail.Text;

            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxEmail.Text = "";

            //saveContact(new string[] { nomContact, prenomContact, emailContact });
            saveContact(nomContact, prenomContact, emailContact);

            refreshListContact();

        }


        List<string[]> getContacts()
        {
            List<string[]> contacts = new List<string[]>();

            try
            {
                using (StreamReader reader = new StreamReader("contacts.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] contact = reader.ReadLine().Split(';');
                        contacts.Add(contact);
                    }
                }
            } 
            catch(FileNotFoundException e) {}

            return contacts;
        }

        
        void saveContacts(List<string[]> contacts)
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt", false))
            {
                foreach (string[] contact in contacts)
                {
                    writer.WriteLine(String.Join(";", contact));
                }
            }

        }

        /// <summary>
        /// Sauvegarde un contact dans un fichier
        /// </summary>
        /// <param name="contacts">Tableau avec dans l'ordre : nom, prenom, email</param>
        void saveContact(string[] contact)
        {
            using (StreamWriter writer = new StreamWriter("contacts.txt", true))
            {
                writer.WriteLine(String.Join(";", contact));
            }

        }
        /// <summary>
        /// Sauvegarde un contact dans un fichier
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="email"></param>
        void saveContact(string nom, string prenom, string email)
        {
            saveContact(new string[] { nom, prenom, email });
        }


        void refreshListContact()
        {
            List<string[]> contacts = getContacts();
            listViewContacts.Items.Clear();
            foreach (string[] contact in contacts)
            {
                listViewContacts.Items.Add(new ListViewItem(contact));
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            List<string[]> contacts = new List<string[]>();

            foreach (ListViewItem item in listViewContacts.SelectedItems)
            {
                listViewContacts.Items.Remove(item);
            }


            foreach(ListViewItem item in listViewContacts.Items)
            {
                contacts.Add(new string[] { item.SubItems[0].Text,
                                            item.SubItems[1].Text,
                                            item.SubItems[2].Text
                                           });
            }

            saveContacts(contacts);

        }
    }
}
