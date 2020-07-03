using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Annuaire;

namespace AnnuaireWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            refreshContacts();
        }

        private void ButtonNewContact_Click(object sender, EventArgs e)
        {
            string nom = textBoxNom.Text;
            string prenom = textBoxPrenom.Text;
            string tel = textBoxTel.Text;
            string email = textBoxEmail.Text;

            Annuaire.Annuaire annuaire = new Annuaire.Annuaire();
            annuaire.sauvegarderContact(nom, prenom, tel, email);

            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxTel.Text = "";
            textBoxEmail.Text = "";

            refreshContacts();

        }

        void refreshContacts()
        {
            Annuaire.Annuaire annuaire = new Annuaire.Annuaire();

            List<string[]> contacts = annuaire.lireContacts();
            StringBuilder sb = new StringBuilder();

            foreach(string[] contact in contacts)
            {

                sb.AppendFormat("-----------------------\n");
                sb.AppendFormat("Nom: {0}\n", contact[0]);
                sb.AppendFormat("Prénom: {0}\n", contact[1]);
                sb.AppendFormat("Téléphone: {0}\n", contact[2]);
                sb.AppendFormat("Email: {0}\n", contact[3]);
                sb.AppendFormat("-----------------------\n");
            }

            labelListContact.Text = sb.ToString();
        }
    }
}
