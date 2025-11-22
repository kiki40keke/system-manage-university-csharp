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
    public partial class FenmodalitePaiement : Form
    {
        public Interface.InterfaceService ser;
        public Interface.InterfacePaiement Paie;
        public string Dateenreg;
       public string codepc;
        public FenmodalitePaiement()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
            Paie = (Interface.InterfacePaiement)Activator.GetObject(typeof(Interface.InterfacePaiement), "tcp://localhost:1069/objetPaiement");
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
        private void button1_Click(object sender, EventArgs e)
        {
            string codepc = txtcode.Text.Trim();
            if (codepc == "") { MessageBox.Show("Entrez un Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string nomoption = null;
                rechercher(codepc, nomoption);
            }
        }

        void rechercher(string codepc,string nomoption){
            ArrayList Fiche = new ArrayList();
            if(codepc!=null){
                Fiche = Paie.FichePaiement(codepc);
            }
            else  if (nomoption != null)
            {
                Fiche = Paie.FichePaiement2(nomoption);
            }
            else if (nomoption == null || codepc==null){
                Fiche = Paie.FichePaiement2(nomoption);
            }

            string id_prof2 = (string)Fiche[0];
            if (id_prof2 != null)
            {
                codepc = (string)Fiche[0];
                cbxoptioncours.SelectedItem = (string)Fiche[1];
                txtinsc.Text = (string)Fiche[2];
                txtentre.Text = (string)Fiche[3];
                txtsess.Text = (string)Fiche[4];
                Dateenreg = Text = (string)Fiche[5];
            }

            else { MessageBox.Show("Le code Est Incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void remplircombooptions()
        {
            ArrayList Al = new ArrayList();
            Al = ser.remplirComboOptions();
            cbxoptioncours.Items.Clear();
            foreach (var item in Al)
            {
                //Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
                cbxoptioncours.Items.Add(item);
                cbxoptioncours2.Items.Add(item);
            }
        }

        private void FenmodalitePaiement_Load(object sender, EventArgs e)
        {
            remplircombooptions();
            try
            {
                cbxoptioncours.SelectedIndex = 0;
                cbxoptioncours2.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void btnrech1_Click(object sender, EventArgs e)
        {
            string codepc = null;
            string nomoption = cbxoptioncours2.SelectedItem.ToString();
            rechercher(codepc, nomoption);
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {
            if (txtinsc.Text.Trim() == "" || txtentre.Text.Trim() == "" || txtsess.Text.Trim() == "")
            {

                MessageBox.Show("Remplissez Tous les Frais", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                String Nom_Opt = cbxoptioncours.SelectedItem.ToString();
                double fraisInscription = Double.Parse(txtinsc.Text.Trim());
                double fraisDentres = Double.Parse(txtentre.Text.Trim());
                double fraisSession = Double.Parse(txtsess.Text.Trim());

                string message = "Voulez vous vraiment Enregistrer ce modalite pour cet option";
                string title = "Modalite";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string messag = Paie.EnregistrerPaiement(Nom_Opt, fraisInscription, fraisDentres, fraisSession);
                    MessageBox.Show(messag, "Modalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Do something  
                }  

               
            }

        }

        private void btnmiseajour_Click(object sender, EventArgs e)
        {
            if (txtinsc.Text.Trim() == "" || txtentre.Text.Trim() == "" || txtsess.Text.Trim() == "")
            {

                MessageBox.Show("Remplissez Tous les Frais", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                String Nom_Opt = cbxoptioncours.SelectedItem.ToString();
                double fraisInscription = Double.Parse(txtinsc.Text.Trim());
                double fraisDentres = Double.Parse(txtentre.Text.Trim());
                double fraisSession = Double.Parse(txtsess.Text.Trim());

                string message = "Voulez vous vraiment Modifier ce modalite pour cet option";
                string title = "Modalite";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string messag = Paie.ModifierPaiement(codepc, Nom_Opt, Dateenreg, fraisInscription, fraisDentres, fraisSession);
                    MessageBox.Show(messag, "Modalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Do something  
                }  

              
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtinsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifint(e);
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }
    }
}
