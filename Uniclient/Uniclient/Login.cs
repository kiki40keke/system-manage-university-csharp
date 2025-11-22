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
using System.Web;
using System.Net.Mail;
using Services;

namespace Uniclient
{
    public partial class Login : Form
    {

        public Interface.InterfaceUtilisateur Uti;
        public Interface.InterfaceEmployer Emp; string Cod;
        Service sa = new Service();
        public Login()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
         
            // ChannelServices.RegisterChannel(tp);
            Emp = (Interface.InterfaceEmployer)Activator.GetObject(typeof(Interface.InterfaceEmployer), "tcp://localhost:1069/objetEmployer");
            Uti = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), "tcp://localhost:1069/objetUtilisateur");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panLogin.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        void Menus(Menu m) {
            m.inscrireToolStripMenuItem.Enabled = false;
            m.rechercheretudToolStripMenuItem.Enabled = false;
            m.listeretudToolStripMenuItem.Enabled = false;
            m.embaucherprogToolStripMenuItem.Enabled = false;

            m.AttributionToolStripMenuItem1.Enabled = false;
            m.listerprofToolStripMenuItem1.Enabled = false;
            m.embaucherempToolStripMenuItem1.Enabled = false;
            m.listerempToolStripMenuItem2.Enabled = false;

            m.creerToolStripMenuItem.Enabled = false;
            m.rechercherutiToolStripMenuItem3.Enabled = false;
            m.listerutiToolStripMenuItem4.Enabled = false;
            m.enregistrerpaieToolStripMenuItem.Enabled = false;

            m.versmentToolStripMenuItem.Enabled = false;
            m.smnliMdpaiement.Enabled = false;
            m.listerDesAnciensModaliteDePaiementsToolStripMenuItem.Enabled = false;
            m.listerDesDepotEtudiantsToolStripMenuItem.Enabled = false;

            m.Gestioncours.Enabled = false;
            m.Bulletin.Enabled = false;
            m.CestionEvaluation.Enabled = false;
            m.GestionNotes.Enabled = false;

            m.Palmares.Enabled = false;
            m.bloqueToolStripMenuItem.Enabled = false;
            m.debloToolStripMenuItem.Enabled = false;
      
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string nomuser = txtNomUser.Text;
            string Motdepasse = txtMotPasse.Text;



            if (nomuser == "" || Motdepasse == "")
            {
                la.Text = "Tout les champs doivent être remplir";
                // MessageBox.Show("Tout les champs doivent etre remplir");
                txtNomUser.Focus();
            }

            else
            {
                String nomUtil = Uti.TesteUtilisateur(nomuser);


                ArrayList FicheLogin = new ArrayList();
                FicheLogin = Uti.FicheLogin(nomuser, Motdepasse);
                string code = (string)FicheLogin[0];
                string etat = (string)FicheLogin[3];
                if (nomUtil == nomuser && code == null)
                {
                    int etatU = Uti.UtilisateurBloque(nomuser);

                    if (etatU == 0)
                    {
                        MessageBox.Show("Utilisateur bloque");
                    }
                    else
                    {
                        String mes = Uti.EnregistrerTantative(nomuser);

                        int compterTantative = Uti.CompterTantative(nomuser);
                        int restant = 3 - compterTantative;
                        
                        if (compterTantative == 3)
                        {
                            String block = Uti.BloqueUtilisateur(nomuser);
                            String expediteur = "aime.jeanmytho@gmail.com";
                       
                            String Mes = "L'utilisateur " + nomuser + " à tenter de connecter à plusieurs reprise";
                            string ms = sa.sendEmail(expediteur, Mes,"Avertissement");
                         

                        }
                        MessageBox.Show("mot de passe incorrecte \n" + "Tenatative restant: " + restant, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMotPasse.Clear();
                        txtMotPasse.Focus();
                    }

                }

                else if (nomuser == nomUtil && code != null)
                {


                    if (etat == "0")
                    {
                        MessageBox.Show("Vous avez ete bloquer veuillez Contacter un administrateur");

                        txtNomUser.Clear();
                        txtMotPasse.Clear();
                    }

                    else
                    {
                        ArrayList FicheEmployer = new ArrayList();
                        FicheEmployer = Emp.FicheEmployer(code);
                        string fonction = (string)FicheEmployer[10];
                        Menu M = new Menu();
                        M.lbNomUser.Text = nomuser;
                        M.lblfonction.Text = fonction;
                        Menus(M);

                        if (fonction == "Administrateur")
                        {
                            M.Show();
                            M.creerToolStripMenuItem.Enabled = true;
                            M.rechercherutiToolStripMenuItem3.Enabled = true;
                            M.listerutiToolStripMenuItem4.Enabled = true;
                            M.bloqueToolStripMenuItem.Enabled = true;
                            M.debloToolStripMenuItem.Enabled = true;
                           

                        }
                        else if (fonction == "Gestionaire RH")
                        {
                            M.Show();
                            M.embaucherprogToolStripMenuItem.Enabled = true;

                       
                            M.listerprofToolStripMenuItem1.Enabled = true;
                            M.embaucherempToolStripMenuItem1.Enabled = true;
                            M.listerempToolStripMenuItem2.Enabled = true;
                        
                        }
                        else if (fonction == "Coordonateur")
                        {
                            M.Show();

                            M.Gestioncours.Enabled = true;
                            M.Bulletin.Enabled = true;
                            M.CestionEvaluation.Enabled = true;
                            M.GestionNotes.Enabled = true;
                            M.AttributionToolStripMenuItem1.Enabled = true;
                            M.Palmares.Enabled = true;
                            
                        }
                        else if (fonction == "Comptable")
                        {
                            M.Show();
                            M.enregistrerpaieToolStripMenuItem.Enabled = true;

                            M.versmentToolStripMenuItem.Enabled = true;
                            M.smnliMdpaiement.Enabled = true;
                            M.listerDesAnciensModaliteDePaiementsToolStripMenuItem.Enabled = true;
                            M.listerDesDepotEtudiantsToolStripMenuItem.Enabled = true;

                           
                        }
                        else if (fonction == "Secretaire")
                        {
                            M.Show();
                            M.inscrireToolStripMenuItem.Enabled = true;
                            M.rechercheretudToolStripMenuItem.Enabled = true;
                            M.listeretudToolStripMenuItem.Enabled = true;
                            M.versmentToolStripMenuItem.Enabled = true;
                           
                        }

                        else { MessageBox.Show("li pa sa"); }
                    }




                }

                else
                {
                    MessageBox.Show("Le Nom ou Mot de passe Incorrect");
                }
            }

          
           
           
                

        }

        private void cbxAfficher_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAfficher.Checked)
            {
                txtMotPasse.UseSystemPasswordChar = false;

            }
            else
            {
                txtMotPasse.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Etes-vous sur de vouloir quitter ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
