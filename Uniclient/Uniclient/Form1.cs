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
    public partial class Form1 : Form
    {
        public Interface.InterfaceProfesseur inte;
        Service sa = new Service();
        bool veri = false;
        public Form1()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            // inte = inter;
            inte = (Interface.InterfaceProfesseur)Activator.GetObject(typeof(Interface.InterfaceProfesseur), "tcp://localhost:1069/objetProfesseur");
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
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxprofession.SelectedIndex = 0;
            cbxEtat.SelectedIndex = 0;
            cbxsexeprof.SelectedIndex = 0;
            panSaisi.Visible = true;
            lblcodeprof.Visible = false;
            txtcodeprof.Visible = false;
            btnrechercherprof.Visible = false;
            btnmodifprof.Visible = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veri = true;

     
            

            string Matricule_prof = txtmatriculeprof.Text.Trim();


            string Sexe_prof = cbxsexeprof.SelectedItem.ToString();




            string DateNaissance_prof = jDtnaissance.Text;

            string NumrefProf = txtnumref.Text.Trim();
            string professionprof = cbxprofession.SelectedItem.ToString();
            string Nom_prof = txtnomprof.Text.Trim().Replace("'", "''");
            string Prenom_prof = txtprenomprof.Text;
            string Tel_prof = txttelprof.Text.Trim().Replace("'", "''");
            string Email_prof = txtemailprof.Text.Trim().Replace("'", "''");
            string Adresse_prof = txtadresseprof.Text.Trim().Replace("'", "''");
            string Etat_prof = cbxEtat.SelectedItem.ToString();
                verif();
                if (veri == false) { MessageBox.Show("format invalide"); }
                else
                {
                    string message = "Voulez vous vraiment Embaucher cet professeur";
                    string title = "Proffesseur";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string msg = inte.EnregistrerProfesseur(Matricule_prof, Nom_prof, Prenom_prof, Sexe_prof, Tel_prof, Email_prof, Adresse_prof, NumrefProf, DateNaissance_prof, professionprof, Etat_prof);
                        MessageBox.Show(msg, "Proffesseur", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        renitialiser();
                    }
                    else
                    {
                        // Do something  
                    }

                }
        }

        private void btnrechercherprof_Click(object sender, EventArgs e)
        {
            string id_prof = txtcodeprof.Text;
            if (id_prof == "")
            {
                MessageBox.Show("entrer un code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                renitialiser();

            }
            else
            {
                ArrayList fiche = new ArrayList();
                fiche = inte.FicheProfesseur(id_prof);
                string id_prof2 = (string)fiche[0];
                //  string bled = "wyw";
                if (id_prof2 != null)
                {
                    txtmodif.Text = (string)fiche[0];
                    txtmatriculeprof.Text = (string)fiche[1];
                    txtnomprof.Text = (string)fiche[2];
                    txtprenomprof.Text = (string)fiche[3];
                    cbxsexeprof.SelectedItem = (string)fiche[4];
                    txttelprof.Text = (string)fiche[5];
                    txtemailprof.Text = (string)fiche[6];
                    txtadresseprof.Text = (string)fiche[7];
                    txtnumref.Text = (string)fiche[8];
                    jDtnaissance.Text = (string)fiche[9];
                    cbxprofession.SelectedItem = (string)fiche[10];
                    cbxEtat.SelectedItem = (string)fiche[11];
                    panSaisi.Visible = true;
                    btnmodifprof.Visible = true;

                    // MessageBox.Show("li bon");
                }

                else
                {
                    MessageBox.Show("Votre Code est Incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); panSaisi.Visible = false;
                renitialiser();
                }
            }
        }

        void renitialiser() {
            txtmatriculeprof.Clear();
            txtnomprof.Clear();
            txtprenomprof.Clear();
            txttelprof.Clear();
            txtemailprof.Clear();
            txtadresseprof.Clear();
            txtnumref.Clear();
            cbxprofession.SelectedIndex = 0;

            cbxsexeprof.SelectedIndex = 0;
            cbxEtat.SelectedIndex = 0;
            jDtnaissance.Text = "1995/01/01";
            txtmodif.Clear();
        
        }
        private void btnmodifprof_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmodif.Text.Trim()))
            {
                MessageBox.Show("Effectuez d'abord une recherche");
            }
            else
            {
                string Nom_prof = txtnomprof.Text;
                string Prenom_prof = txtprenomprof.Text;
                string Tel_prof = txttelprof.Text;
                string Email_prof = txtemailprof.Text;
                string Adresse_prof = txtadresseprof.Text;
                string Etat_prof = cbxEtat.SelectedItem.ToString();
                string Id_prof = txtmodif.Text;
                verif();

                if (veri == false)
                {
                    MessageBox.Show("Valider les format");
                }

                else
                {
                    string message = "Voulez vous vraiment Modifier cet professeur";
                    string title = "Proffesseur";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string msg = inte.ModifierProfesseur(Nom_prof, Prenom_prof, Tel_prof, Email_prof, Adresse_prof, Etat_prof, Id_prof);
                        MessageBox.Show(msg, "Proffesseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        renitialiser();
                    }
                    else
                    {
                        // Do something  
                    }

                }
            }
        }

        private void rdbEnreg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEnreg.Checked == true)
            {
                rdbseach.Checked = false;
                renitialiser();
                txtmatriculeprof.Enabled = true;
                txtnumref.Enabled = true;
                lblcodeprof.Visible = false;
                txtcodeprof.Visible = false;
                btnrechercherprof.Visible = false;
                btnmodifprof.Visible = false;
                btnenregprof.Visible = true;
                panSaisi.Visible = true;
                rdbEnreg.Checked = true;
                
            }
            else
            {
                renitialiser();
                lblcodeprof.Visible = true;
                txtcodeprof.Visible = true;
                btnrechercherprof.Visible = true;
                btnmodifprof.Visible = true;
                rdbseach.Checked = true;
                btnenregprof.Visible = false;
                txtmatriculeprof.Enabled = false;
                txtnumref.Enabled = false;
                panSaisi.Visible = false;

            }

                  

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblcodeprof_Click(object sender, EventArgs e)
        {

        }

        private void rdbseach_CheckedChanged(object sender, EventArgs e)
        {



            if (rdbseach.Checked == true)
            {
                rdbseach.Checked = true;
                 renitialiser();
                lblcodeprof.Visible = true;
                txtcodeprof.Visible = true;
                btnrechercherprof.Visible = true;
                btnmodifprof.Visible = true;
                rdbEnreg.Checked = false;
                btnenregprof.Visible = false;
                txtmatriculeprof.Enabled = false;
                txtnumref.Enabled = false;
                panSaisi.Visible = false;
             
            }
            else
            {
                rdbEnreg.Checked = true;
                renitialiser();
                txtmatriculeprof.Enabled = true;
                txtnumref.Enabled = true;
                lblcodeprof.Visible = false;
                txtcodeprof.Visible = false;
                btnrechercherprof.Visible = false;
                btnmodifprof.Visible = false;
                btnenregprof.Visible = true;
                panSaisi.Visible = true;
                rdbEnreg.Checked = true;
               
            }
            

        }

        private void txtnomprof_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtprenomprof_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtprofession_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtcodeprof_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        void verif() {
            veri = true;
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();
            txtnomprof_Validating(sender, e);
            txtprenomprof_Validating(sender, e);
            txtadresseprof_Validating(sender, e);
            txtmatriculeprof_Validating(sender, e);
            txttelprof_Validating(sender, e);
            txtnumref_Validating(sender, e);
            txtemailprof_Validating(sender, e);
            
        }

        private void txtnomprof_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnomprof.Text.Trim()))
            {
                errorProvider1.SetError(txtnomprof, "Entrez un Nom");
                veri = false;
            }
            else if (txtnomprof.TextLength < 2)
            {
                errorProvider1.SetError(txtnomprof, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtnomprof, "");

            }
        }

        private void txtprenomprof_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtprenomprof.Text.Trim()))
            {
                errorProvider1.SetError(txtprenomprof, "Entrez un Prenom");
                veri = false;
            }
            else if (txtprenomprof.TextLength < 2)
            {
                errorProvider1.SetError(txtprenomprof, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtprenomprof, "");

            }
        }

        private void txtadresseprof_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtadresseprof.Text.Trim()))
            {
                errorProvider1.SetError(txtadresseprof, "Entrez un Prenom");
                veri = false;
            }
            else if (txtadresseprof.TextLength < 4)
            {
                errorProvider1.SetError(txtadresseprof, "Minimum 4 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtadresseprof, "");

            }
        }

        private void txtmatriculeprof_Validating(object sender, CancelEventArgs e)
        {
            String nif = txtmatriculeprof.Text.Trim();
            if (nif.Length < 13)
            {
                errorProvider1.SetError(txtmatriculeprof, "Entrez 10 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtmatriculeprof, "");

            }
        }

        private void txttelprof_Validating(object sender, CancelEventArgs e)
        {
            String telephone = txttelprof.Text.Trim();
            if (telephone.Length < 15)
            {
                errorProvider1.SetError(txttelprof, "Entrez 8 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txttelprof, "");

            }
        }

        private void txtnumref_Validating(object sender, CancelEventArgs e)
        {
            String telephone = txtnumref.Text.Trim();
            if (telephone.Length < 15)
            {
                errorProvider1.SetError(txtnumref, "Entrez 8 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtnumref, "");

            }
        }

        private void txtemailprof_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtemailprof.Text.Trim()))
            {
                errorProvider1.SetError(txtemailprof, "Entrez un email");
                veri = false;
            }
            else if (sa.verifyEmail(txtemailprof.Text) == false)
            {
                errorProvider1.SetError(txtemailprof, "Cet Email n'est pas valide");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtemailprof, "");

            }
        }

    }
}
