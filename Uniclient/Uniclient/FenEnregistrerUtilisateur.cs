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
    public partial class FenEnregistrerUtilisateur : Form
    {
        public Interface.InterfaceEmployer Emp;
        public Interface.InterfaceUtilisateur Uti;
        public FenEnregistrerUtilisateur()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
          //  ChannelServices.RegisterChannel(tp);

            Emp = (Interface.InterfaceEmployer)Activator.GetObject(typeof(Interface.InterfaceEmployer), "tcp://localhost:1069/objetEmployer");
            Uti = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), "tcp://localhost:1069/objetUtilisateur");
        }

        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            string code = txtCodeRechercher.Text.Trim();

            if(code==""){
                MessageBox.Show("Entrer Un Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ArrayList FicheEmployer = new ArrayList();
            FicheEmployer = Emp.FicheEmployer(code);
            String Code2 = (string)FicheEmployer[0];
            if (Code2 != null)
            {
                txtcode.Text = (string)FicheEmployer[0];
                txtnom.Text = (string)FicheEmployer[1];
                txtPrenom.Text = (string)FicheEmployer[2];
                txtFonction.Text= (string)FicheEmployer[10];
              
            }

            else
            {
                MessageBox.Show("Le code n'est pas bon", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            renitialise();
            }
        }

        private void btncreer_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text.Trim().Replace("'", "''");
            string nomuser = txtNomUser.Text.Trim().Replace("'", "''");
            string motepasse2 = jPFMotPasse.Text.Trim();
            if (code == "")
            {
                MessageBox.Show("Rechercher d'abord l'employer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else  if ( nomuser == "" || motepasse2 == "")
            {
                MessageBox.Show("Remplissez tous les Champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = "Voulez vous vraiment Enregistrer cet utilisateur";
                string title = "Enregistrement";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    String mes = Uti.EnregistrerUtilisateur(code, nomuser, motepasse2);
                    MessageBox.Show(mes, "Utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    renitialise();   
                }
                else
                {
                    // Do something  
                }  
                
            }
        }

        void renitialise() {
            txtcode.Clear();
            txtnom.Clear();
            txtPrenom.Clear();
            txtFonction.Clear();
            txtCodeRechercher.Clear();
            txtNomUser.Clear();
            jPFMotPasse.Clear();
        
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

        private void FenEnregistrerUtilisateur_Load(object sender, EventArgs e)
        {
           
        }

        private void txtCodeRechercher_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }
    }
}
