using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetContact
{
    class Program
    {
        static void Main(string[] args)
        {

            Ami ami1 = new Ami("Test", "Ami", true, "ami@gmail.com", "0348635657", new DateTime(1985, 05, 12), "Lyon");
            Ami ami2 = new Ami("Test", "Gérard", true, "gégé@gmail.com", "0348635657", new DateTime(1985, 07, 12), "Lyon");

            ContactPro pro1 = new ContactPro("David", "Beckham", "Dawan", "dbeckham@dawan.fr", "06384384398", true, "Formateur");
            ContactPro pro2 = new ContactPro("Lilian", "Thuram", "Dawan", "lthuram@dawan.fr", "06384384398", true, "Manager");

            MembreFamille fam1 = new MembreFamille("Aldaitz", "Guillaume", false, "g@gmail.com", "098098098809", new DateTime(1981, 12, 20), "frère", true, true);
            MembreFamille fam2 = new MembreFamille("Aldaitz", "Patrick", true, "p@gmail.com", "098098098809", new DateTime(1954, 08, 14), "père", true, false);


            List<Contact> contacts = new List<Contact>();
            contacts.Add(ami1);
            contacts.Add(ami2);
            contacts.Add(pro1);
            contacts.Add(pro2);
            contacts.Add(fam1);
            contacts.Add(fam2);

            List<IInvitable> invites = new List<IInvitable>();
            invites.Add(ami1);
            invites.Add(ami2);
            invites.Add(fam1);
            invites.Add(fam2);


            //foreach(Contact contact in contacts)
            //{
            //    Console.WriteLine(contact.sePresenter());
            //}

            foreach(IInvitable invite in invites)
            {
                inviter(invite);
            }


            Console.ReadLine();
        }


        static void inviter(IInvitable invite)
        {
            Console.WriteLine(invite.genererMessageInvitation());
        }
    }
}
