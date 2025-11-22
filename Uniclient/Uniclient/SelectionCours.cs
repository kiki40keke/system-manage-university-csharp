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
    public partial class SelectionCours : Form
    {
        public Interface.InterfaceService ser;
        public Interface.InterfaceProfesseur inte;
    
        public SelectionCours()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
            inte = (Interface.InterfaceProfesseur)Activator.GetObject(typeof(Interface.InterfaceProfesseur), "tcp://localhost:1069/objetProfesseur");
        }

        private void SelectionCours_Load(object sender, EventArgs e)
        {
            remplircombooptions();
            cbxniveau.SelectedIndex = 0;
            cbxsession.SelectedIndex = 0;
            cbxvacation.SelectedIndex = 0;
            try
            {
                cbxoptioncours.SelectedIndex = 0;
                cbxcours.SelectedIndex = 0;
            }
            catch(Exception ff){}
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

        void remplirliste()
        {
            string idpro = txtcode2.Text;
            ArrayList Al = new ArrayList();
            Al = ser.remplirlisetecours(idpro);
            listBox1.Items.Clear();
            txtdetails.Clear();
            foreach (var item in Al)
            {
               
                listBox1.Items.Add(item);
            }
        }

        void selection() {
            try
            {
        
            String Nom_Opt = cbxoptioncours.SelectedItem.ToString();
            String Niveau = cbxniveau.SelectedItem.ToString();

            String Session = cbxsession.SelectedItem.ToString();
            ArrayList Al = new ArrayList();
            Al = ser.remplirComboCours(Nom_Opt, Niveau, Session);
            cbxcours.Items.Clear();
            foreach (var item in Al)
            {
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
                cbxcours.Items.Add(item);
            }

          
                cbxcours.SelectedIndex = 0;
            }
            catch (Exception ff) { }


        }

        private void cbxoptioncours_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Idprof = txtcode2.Text.Trim();
            String Nom_Cours = cbxcours.SelectedItem.ToString();
            String Nom_Opt = cbxoptioncours.SelectedItem.ToString();
            String Vacation = cbxvacation.SelectedItem.ToString();

            if (Idprof == "") { MessageBox.Show("Effectuez une rechercher"); }
            else
            {


                string message = ser.EnregistrerCoursSelectionner(Idprof, Nom_Opt, Nom_Cours, Vacation);
                MessageBox.Show(message);
                remplirliste();
            }
        }

        private void btnrecherprofcours_Click(object sender, EventArgs e)
        {
            String id_prof = txtcodeprofcours.Text.Trim();
            if (id_prof == "") { MessageBox.Show("entrez le code"); }
            else
            {
                ArrayList fiche = new ArrayList();
                fiche = inte.FicheProfesseur(id_prof);
                string id_prof2 = (string)fiche[0];
                //  string bled = "wyw";
                if (id_prof2 != null)
                {
                  
                    txtcode2.Text = (string)fiche[0];
                    remplirliste();
                    pansaisie.Visible = true;
                }
                else
                {
                    MessageBox.Show("Code Incorrect");
                    txtcode2.Clear();
              
                    pansaisie.Visible = false;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codecs = listBox1.SelectedItem.ToString();
            string resul = ser.InformationCoursSelect(codecs);
            txtdetails.Text = resul;
        }

        private void btndissoc_Click(object sender, EventArgs e)
        {
            string ve = txtdetails.Text.Trim();
            if (ve == "") { MessageBox.Show("Selectionnez d'abord un Code Cours"); }
            else
            {
                string codecs = listBox1.SelectedItem.ToString();
                string mes = ser.SuprimmerAttributionCours(codecs);
                MessageBox.Show(mes);
                remplirliste();
            }
         
        }

        private void txtcodeprofcours_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        private void cbxniveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

        private void cbxsession_SelectedIndexChanged(object sender, EventArgs e)
        {
            selection();
        }

    }
}
