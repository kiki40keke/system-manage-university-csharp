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

namespace Uniclient
{
    public partial class FenRecherUtilisateur : Form
    {
        public Interface.InterfaceEmployer Emp;
        public Interface.InterfaceUtilisateur Uti;
        public FenRecherUtilisateur()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);

            Emp = (Interface.InterfaceEmployer)Activator.GetObject(typeof(Interface.InterfaceEmployer), "tcp://localhost:1069/objetEmployer");
            Uti = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), "tcp://localhost:1069/objetUtilisateur");
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text.Trim();
            if (code == "")
            {
                MessageBox.Show("Effectuez une rechercher", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                string nomuser = txtNomUser.Text.Trim().Replace("'", "''");
                string motepasse2 = jPFMotPasse.Text.Trim().Replace("'", "''");
                string etat = cmetat.SelectedItem.ToString();
                if (nomuser == "" || motepasse2 == "")
                {
                    MessageBox.Show("Remplissez les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = "Voulez vous vraiment Modifier cet utilisateur";
                    string title = "Utilisateur";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string mes = Uti.ModifierUtilisateur(nomuser, motepasse2, etat, code);
                        MessageBox.Show(mes, "Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        renitialise();
                    }
                    else
                    {
                        // Do something  
                    }  
                   
                }
            }
            

        }
        void renitialise() {
            txtcode.Clear();
            txtnom.Clear();
            txtPrenom.Clear();
            txtFonction.Clear();
            txtNomUser.Clear();
            jPFMotPasse.Clear();
            cmetat.SelectedIndex = 0;
        }
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            string code = txtCodeRechercher.Text;
            if (code == "")
            {
                MessageBox.Show("Entrer un Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList FicheEmployer = new ArrayList();
                FicheEmployer = Emp.FicheEmployer(code);
                String Code2 = (string)FicheEmployer[0];
                if (Code2 != null)
                {
                    txtcode.Text = (string)FicheEmployer[0];
                    txtnom.Text = (string)FicheEmployer[1];
                    txtPrenom.Text = (string)FicheEmployer[2];
                    txtFonction.Text = (string)FicheEmployer[10];

                    ArrayList FicheYtilisateur = new ArrayList();
                    FicheYtilisateur = Uti.FicheUtilisateur(Code2);
                    String Codeuti = (string)FicheYtilisateur[0];
                    if (Codeuti != null)
                    {
                        txtNomUser.Text = (string)FicheYtilisateur[1];
                        jPFMotPasse.Text = (string)FicheYtilisateur[2];
                        cmetat.SelectedItem = (string)FicheYtilisateur[3];
                        pansasie.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Cet Employe n'est pas encore un utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pansasie.Visible = false;
                        renitialise();
                    }

                }

                else { MessageBox.Show("Le code n'est pas bon", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); pansasie.Visible = false; renitialise(); }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FenRecherUtilisateur_Load(object sender, EventArgs e)
        {
            cmetat.SelectedIndex = 0;
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

        private void txtCodeRechercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

    }
}
