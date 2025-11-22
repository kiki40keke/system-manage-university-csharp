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
    public partial class GestionCours : Form
    {
        public Interface.InterfaceService ser;
        public GestionCours()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nomoption = txtnomoption.Text.Trim().Replace("'", "''");
            if (nomoption == "") { MessageBox.Show("Enterz un Nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string message = "Voulez vous vraiment Enregister cet option";
                string title = "Options";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(ser.EnregistrerOption(nomoption), "Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listeroptions();
                    remplircombooptions();
                    cbxoptioncours.SelectedIndex = 0;
                }
                else
                {
                    // Do something  
                }  
              
            }
            
        }

        public void veriflettre(KeyPressEventArgs e)
        {
            //  string lettre = "abcdefg";
            char point = '.';
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
            else if (point == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }
        public void veriflettreint(KeyPressEventArgs e)
        {
            //  string lettre = "abcdefg";
            char point = '.';
            char tiret = '-';
            char apos = '\'';

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
            else if (apos == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (point == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
        }

        private void GestionCours_Load(object sender, EventArgs e)
        {
            listeroptions();
            remplircombooptions();
            listercours();
            cbxniveau.SelectedIndex = 0;
            cbxsession.SelectedIndex = 0;
            cbxoptioncours.SelectedIndex = 0;
        }

        void listeroptions() {
            dataGridView1.Columns.Clear();
            DataSet bd = ser.listerOptions();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["options"];
            dataGridView1.DataSource = bn;
        }

        void listercours()
        {
            dataGridView2.Columns.Clear();     

            DataSet bd = ser.listerCours();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["cours"];
            dataGridView2.DataSource = bn;
        }

        void remplircombooptions() {
            ArrayList Al = new ArrayList();
            Al = ser.remplirComboOptions();
            cbxoptioncours.Items.Clear();
            foreach (var item in Al)
            {
                Console.Write(item + ", "); //output: 1, Bill, 300, 4.5, 
                cbxoptioncours.Items.Add(item);
            }
        }

        private void btnajcours_Click(object sender, EventArgs e)
        {
            string Nom_Opt = cbxoptioncours.SelectedItem.ToString().Replace("'", "''");
            string codeniv = cbxniveau.SelectedItem.ToString();

            string codesession = cbxsession.SelectedItem.ToString();
            string Nomcours = txtnomcours.Text.Trim().Replace("'", "''");

            if (Nomcours == "") { MessageBox.Show("Entrez un Nom", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                string message = "Voulez vous vraiment Enregister ce Cours";
                string title = "Cours";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show(ser.EnregistrerCours(Nom_Opt, codeniv, codesession, Nomcours), "Cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listercours();
                }
                else
                {
                    // Do something  
                }  
              
            }

            
        }

        private void txtnomoption_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtnomcours_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettreint(e);
        }


    }
}
