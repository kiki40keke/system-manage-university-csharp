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
    public partial class FenEnregistrementEtudiant : Form
    {
        Service sa = new Service();
        public Interface.InterfaceService ser;
        public Interface.IEtudiants Etu;
        private bool veri = false;
        public FenEnregistrementEtudiant()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
            Etu = (Interface.IEtudiants)Activator.GetObject(typeof(Interface.IEtudiants), "tcp://localhost:1069/objetEtudiant");
        }


        private void txtnumref_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
        private void FenEnregistrementEtudiant_Load(object sender, EventArgs e)
        {
                  remplircombooptions();
                cbxvacation.SelectedIndex = 0;
                cmbSexe.SelectedIndex = 0;
            try { cbxoptioncours.SelectedIndex = 0; }catch (Exception h) {}
        }

        void remplircombooptions()
        {
            ArrayList Al = new ArrayList();
            Al = ser.remplirComboOptions();
            cbxoptioncours.Items.Clear();
            foreach (var item in Al)
            {
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
                cbxoptioncours.Items.Add(item);
            }
        }

        void renitialiser() {
            txtNom.Clear();
            txtPrenom.Clear();
            txtNif.Clear();
            txtadresse.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPhoneRespon.Clear();
            txtref.Clear();
            cbxvacation.SelectedIndex = 0;
            cmbSexe.SelectedIndex = 0;
            try { cbxoptioncours.SelectedIndex = 0; }
            catch (Exception h) { }
        
        }

       
        private void btninscrire_Click(object sender, EventArgs e)
        {
             String Nom = txtNom.Text.Trim().Replace("'", "''");
            String Prenom = txtPrenom.Text.Trim().Replace("'", "''");
            String Sexe = cmbSexe.SelectedItem.ToString();
            String dateNaiss = txtDate.Text;
            String Nif = txtNif.Text.Trim();
            String Adresse = txtadresse.Text.Trim().Replace("'", "''");
            String Email = txtEmail.Text.Trim();
            String Phone = txtPhone.Text.Trim();

            String PhoneResponsable = txtPhoneRespon.Text.Trim().Replace("'", "''");
            String NomResponsable = txtref.Text.Trim();
            String Vacation = cbxvacation.SelectedItem.ToString();
            String NomOption = cbxoptioncours.SelectedItem.ToString().Replace("'", "''");
            verifier();
            //
            if(veri==false){
                MessageBox.Show("Valider les format");
            }
 

            else if (veri == true)
            {
                string message = "Voulez vous vraiment enregistrer cet etudiant";
                string title = "Inscripion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string messag = Etu.EnregistrerEtudiant(Nom, Prenom, Sexe, dateNaiss, Nif, Adresse, Email, Phone, NomResponsable, PhoneResponsable, Vacation, NomOption);
                    MessageBox.Show(messag, "Inscription", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renitialiser();
                }
                else
                {
                    // Do something  
                }  

              
            }


        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtref_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }
        void verifier()
        {
            veri = true;
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();
            txtNom_Validating(sender, e);
            txtPrenom_Validating(sender, e);
            txtNif_Validating(sender, e);
            txtref_Validating(sender, e);
            txtPhone_Validating(sender, e);
            txtPhoneRespon_Validating(sender, e);
            txtEmail_Validating(sender, e);
            txtadresse_Validating(sender, e);
        }

        private void txtNom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text.Trim())) {
                errorProvider1.SetError(txtNom, "Entrez un Nom");
                veri = false;
            }
            else if (txtNom.TextLength < 2)
            {
                errorProvider1.SetError(txtNom, "Minimum 2 caracteres");
                veri = false;
            }
            else {
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

        private void txtNif_Validating(object sender, CancelEventArgs e)
        {
            String Nif = txtNif.Text.Trim();
            if (Nif.Length < 13)
            {
                errorProvider1.SetError(txtNif, "Entrez 10 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtNif, "");
               
            }
        }

        private void txtref_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtref.Text.Trim()))
            {
                errorProvider1.SetError(txtref, "Entrez le nom du reference");
                veri = false;
            }
            else if (txtref.TextLength < 2)
            {
                errorProvider1.SetError(txtref, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtref, "");
                
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
            else if (sa.verifyEmail(txtEmail.Text)==false)
            {
                errorProvider1.SetError(txtEmail, "Cet Email n'est pas valide");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
                
            }
        }

        private void txtadresse_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtadresse.Text.Trim()))
            {
                errorProvider1.SetError(txtadresse, "Entrez le nom du reference");
                veri = false;
            }
            else if (txtadresse.TextLength < 4)
            {
                errorProvider1.SetError(txtadresse, "l'adresse doit contenir Minimum 4 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtadresse, "");
               
            }
        }


    }
}
