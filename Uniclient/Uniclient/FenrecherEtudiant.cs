using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Collections;
using Services;

namespace Uniclient
{
    public partial class FenrecherEtudiant : Form
    {
        public Interface.IEtudiants Etu;
        Service sa = new Service();
        bool veri = false;
        public FenrecherEtudiant()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            // inte = inter;
    
            Etu = (Interface.IEtudiants)Activator.GetObject(typeof(Interface.IEtudiants), "tcp://localhost:1069/objetEtudiant");
        }

        public void veriflettre(KeyPressEventArgs e)
        {
            //  string lettre = "abcdefg";
            char tiret = '-';
            char apos = '\'';

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (tiret == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (apos == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CodeEt = txtCodeEt.Text.Trim();
            if (CodeEt == "")
            {
                MessageBox.Show("Entrez Votre Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList fiche = new ArrayList();
                fiche = Etu.FicheEtudiant(CodeEt);
                string id_prof2 = (string)fiche[0];
                if (id_prof2 != null)
                {
                    txtCodeEtud.Text = (string)fiche[0];
                    txtNom.Text = (string)fiche[1];
                    txtPrenom.Text = (string)fiche[2];
                    cmbSexe.Text = (string)fiche[3];
                    txtDate.Text = (string)fiche[4];
                    txtNif.Text = (string)fiche[5];
                    txtAdresse.Text = (string)fiche[6];
                    txtEmail.Text = (string)fiche[7];
                    txtPhone.Text = (string)fiche[8];
                    txtNomRespon.Text = (string)fiche[9];
                    txtPhoneRespon.Text = (string)fiche[10];
                    txtVacation.Text = (string)fiche[11];
                    txtCodOpt.Text = (string)fiche[12];
                    txtpromo.Text = (string)fiche[13];
                    txtniv.Text = (string)fiche[14];
                    pansaisie.Visible = true;
                }
                else { MessageBox.Show("Votre code est Incorect ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); renitialise(); pansaisie.Visible = false; }
            }
        }

        void renitialise() {
            txtCodeEtud.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            cmbSexe.Clear();
            txtDate.Clear();
            txtNif.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtNomRespon.Clear();
            txtPhoneRespon.Clear();
            txtVacation.Clear();
            txtCodOpt.Clear();
            txtpromo.Clear();
            txtniv.Clear(); 
        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String CodeEtud = txtCodeEtud.Text.Trim().Replace("'", "''");
            if (CodeEtud == "")
            {
                MessageBox.Show("Effectuer D'abord un Recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                String Nom = txtNom.Text.Trim().Replace("'", "''");
                String Prenom = txtPrenom.Text.Trim().Replace("'", "''");

                String Adresse = txtAdresse.Text.Trim().Replace("'", "''");
                String Email = txtEmail.Text.Trim().Replace("'", "''");
                String Phone = txtPhone.Text.Trim().Replace("'", "''");
                String NomResponsable = txtNomRespon.Text.Trim().Replace("'", "''");
                String PhoneResponsable = txtPhoneRespon.Text.Trim().Replace("'", "''");

            verif();
            if (veri == false) {
                MessageBox.Show("Valider les formats");
            }
            else
            {
                string message = "Voulez vous vraiment Modifier cet Etudiant";
                string title = "Etudiant";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string messa = Etu.ModifierEtudiant(CodeEtud, Nom, Prenom, Adresse, Email, Phone, NomResponsable, PhoneResponsable);
                    MessageBox.Show(messa, "Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renitialise();
                }
                else
                {
                    // Do something  
                }

            }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String CodeEtud = txtCodeEtud.Text.Trim();
            if (CodeEtud == "")
            {
                MessageBox.Show("Effectuer D'abord un Recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = "Voulez vous vraiment Reinscrire cet Etudiant";
                string title = "Etudiant";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    String niveau = txtniv.Text.Trim();
                    string mes = Etu.ReinscrireEtud(niveau, CodeEtud);
                    MessageBox.Show(mes, "Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renitialise(); 
                }
                else
                {
                    // Do something  
                }  
     
            }

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FenrecherEtudiant_Load(object sender, EventArgs e)
        {

        }

        public void veriflettre2(KeyPressEventArgs e)
        {
            //  string lettre = "abcdefg";
            char tiret = '-';


            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (tiret == (e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtCodeEt_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text.Trim()))
            {
                errorProvider1.SetError(txtNom, "Entrez un Nom");
                veri = false;
            }
            else if (txtNom.TextLength < 2)
            {
                errorProvider1.SetError(txtNom, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtNom, "");

            }
        }

        private void txtPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
            {
                errorProvider1.SetError(txtPrenom, "Entrez un prenom");
                veri = false;
            }
            else if (txtPrenom.TextLength < 2)
            {
                errorProvider1.SetError(txtPrenom, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtPrenom, "");

            }
        }

        private void txtNomRespon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomRespon.Text.Trim()))
            {
                errorProvider1.SetError(txtNomRespon, "Entrez le nom du reference");
                veri = false;
            }
            else if (txtNomRespon.TextLength < 2)
            {
                errorProvider1.SetError(txtNomRespon, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtNomRespon, "");

            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            String Phone = txtPhone.Text.Trim();
            if (Phone.Length < 13)
            {
                errorProvider1.SetError(txtPhone, "Entrez 10 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");

            }
        }

        private void txtPhoneRespon_Validating(object sender, CancelEventArgs e)
        {
            String PhoneResponsable = txtPhoneRespon.Text.Trim();
            if (PhoneResponsable.Length < 14)
            {
                errorProvider1.SetError(txtPhoneRespon, "Entrez 10 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtPhoneRespon, "");

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Entrez un email");
                veri = false;
            }
            else if (sa.verifyEmail(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Cet Email n'est pas valide");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");

            }
        }

        private void txtAdresse_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresse.Text.Trim()))
            {
                errorProvider1.SetError(txtAdresse, "Entrez le nom du reference");
                veri = false;
            }
            else if (txtAdresse.TextLength < 4)
            {
                errorProvider1.SetError(txtAdresse, "l'adresse doit contenir Minimum 4 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtAdresse, "");

            }
        }

        void verif() {
            veri = true;
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();
            txtNom_Validating(sender, e);
            txtPrenom_Validating(sender, e);
            txtNomRespon_Validating(sender, e);
            txtPhone_Validating(sender, e);
            txtPhoneRespon_Validating(sender, e);
            txtEmail_Validating(sender, e);
            txtAdresse_Validating(sender, e);
        
        }
    }
}
