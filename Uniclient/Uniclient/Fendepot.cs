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
    public partial class Fendepot : Form
    {
        public Interface.InterfacePaiement Paie;
        public Fendepot()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            ServiceReseau sera = new ServiceReseau();
            String reseaux = sera.getRmi();

            Paie = (Interface.InterfacePaiement)Activator.GetObject(typeof(Interface.InterfacePaiement), "tcp://localhost:1069/objetPaiement");
        }

        private void Fendepot_Load(object sender, EventArgs e)
        {

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
        private void btndepot_Click(object sender, EventArgs e)
        {
            String Id_Etud = txtCode.Text.Trim();
            String mon = txtMontant.Text.Trim();
            if (Id_Etud == "" || mon == "")
            {
                MessageBox.Show("Remplissez tous les Champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                double montant = Double.Parse(mon);
                if (montant < 5) { MessageBox.Show("Le montant minimal est de 5 dollars", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else
                {
                    string message = "Voulez vous vraiment Effectuez ce depot";
                    string title = "Depot";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string messag = Paie.enregTransfert(Id_Etud, montant);
                        MessageBox.Show(messag, "Depot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Do something  
                    }  
                   
                }
            }
           
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifint(e);
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

    }
}
