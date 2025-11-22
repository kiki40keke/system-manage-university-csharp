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
    public partial class FenlisterModaliterPaiement : Form
    {
        public Interface.InterfacePaiement Paie;
        public FenlisterModaliterPaiement()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            // inte = inter;

            Paie = (Interface.InterfacePaiement)Activator.GetObject(typeof(Interface.InterfacePaiement), "tcp://localhost:1069/objetPaiement");
        }

        private void FenlisterModaliterPaiement_Load(object sender, EventArgs e)
        {
            listepaiemnt();
        }
        void listepaiemnt()
        {
            DataSet bd = Paie.ListerPaiement();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["Paiment P,Options O"];
            dataGridView1.DataSource = bn;
        }
    }
}
