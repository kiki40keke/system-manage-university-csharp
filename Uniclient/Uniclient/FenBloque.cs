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
    public partial class FenBloque : Form
    {
        public Interface.InterfaceUtilisateur Uti;
        public FenBloque()
        {
            InitializeComponent();
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            String nomUser = txtBlock.Text;
            String mes = Uti.BloqueUtilisateur(nomUser);
            MessageBox.Show(mes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String nomUser = txtBlock.Text;
            //String mes = Uti.DebloqueUtilisateur(nomUser);
            //MessageBox.Show(mes);
            //if (ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    MessageBox.Show("ou pase");
            //}
            //else {
            //    MessageBox.Show("ou paka pase");
            //}
            if (string.IsNullOrEmpty(txtBlock.Text.Trim()))
            //{
            //    // e.Cancel = true;
            //    errorProvider1.SetError(txtBlock, "Entrez un code");
            //}
            //else { MessageBox.Show("ou pase"); }
                MessageBox.Show("ou pase");
            
        }

        private void FenBloque_Load(object sender, EventArgs e)
        {

        }

        private void txtBlock_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlock.Text.Trim()))
            {
                // e.Cancel = true;
                errorProvider1.SetError(txtBlock, "Entrez un code");
            }
            else
            {
              //  e.Cancel = true;
                errorProvider1.SetError(txtBlock, "");
            }
        }
    }
}
