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
    public partial class GestionPalmaresse : Form
    {
        public Interface.InterfaceService ser;
        public Interface.InterfacePalmares Pal;
        public GestionPalmaresse()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
            Pal = (Interface.InterfacePalmares)Activator.GetObject(typeof(Interface.InterfacePalmares), "tcp://localhost:1069/objetPalmaresse");
        
        }

        private void GestionPalmaresse_Load(object sender, EventArgs e)
        {
            remplircombooptions();
            cbxniveau.SelectedIndex = 0;
            cbxsession.SelectedIndex = 0;
            cbxvacation.SelectedIndex = 0;
            cbxoptioncours.SelectedIndex = 0;
            

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

        void selection()
        {
            try
            {
                cbxcours.Items.Clear();
                String Nom_Opt = cbxoptioncours.SelectedItem.ToString().Replace("'", "''");
                String Niveau = cbxniveau.SelectedItem.ToString();

                String Session = cbxsession.SelectedItem.ToString();
                ArrayList Al = new ArrayList();
                Al = ser.remplirComboCours(Nom_Opt, Niveau, Session);

                foreach (var item in Al)
                {
                    Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
                    cbxcours.Items.Add(item);
                }
                cbxcours.SelectedIndex = 0;
            }
            catch(Exception ff){}

        }

        public void verifint(KeyPressEventArgs e)
        {
           
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }


            else { e.Handled = true; }
        }

        private void cbxoptioncours_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void btnenregpalmares_Click(object sender, EventArgs e)
        {
            String NomOption = cbxoptioncours.SelectedItem.ToString().Replace("'", "''");
            String NomCours = cbxcours.SelectedItem.ToString().Replace("'", "''");

            String NomVacation = cbxvacation.SelectedItem.ToString();



            String Promotions = txtpromotion.Text;
            if (Promotions == "") { MessageBox.Show("Entrez une Promotion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                int promo = Int32.Parse(Promotions);
                if (promo < 2000 || promo > 2022) { MessageBox.Show("Les anne de promotions sont comprises entre 2000 a 2022", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else {
                    string message = "Voulez vous vraiment enregistrer ce palmares";
                    string title = "Enregistrement";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string messa = Pal.Palmaresse(NomOption, NomCours, NomVacation, Promotions);
                        MessageBox.Show(messa);
                    }
                    else
                    {
                        // Do something  
                    }  
                   
                }
              
            }
            
        }

        private void btnrecher_Click(object sender, EventArgs e)
        {
            String NomOption = cbxoptioncours.SelectedItem.ToString().Replace("'", "''");
            String NomCours = cbxcours.SelectedItem.ToString().Replace("'", "''");

            String NomVacation = cbxvacation.SelectedItem.ToString();



            String Promotions = txtpromotion.Text;
            if (Promotions == "") { MessageBox.Show("Entrez une Promotion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string message = Pal.RechercherCodePalmaresse(NomOption, NomCours, NomVacation, Promotions);
                txtcodpal.Text = message;
                if (message == null) { MessageBox.Show("Cette Palmaresse n'existe pas encore", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
          
        }

        private void cbxniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void cbxsession_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void txtpromotion_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifint(e);
        }
    }
}
