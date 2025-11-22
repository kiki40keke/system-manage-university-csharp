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
    public partial class FenListerTransactions : Form
    {
        public Interface.InterfacePaiement Paie;
        public FenListerTransactions()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;

            Paie = (Interface.InterfacePaiement)Activator.GetObject(typeof(Interface.InterfacePaiement), "tcp://localhost:1069/objetPaiement");
        }

        private void FenListerTransactions_Load(object sender, EventArgs e)
        {
            Listertransactions();
        }

        void Listertransactions()
        {
            DataSet bd = Paie.Listertransactions();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["TransacrionsEtudiants"];
            dataGridView1.DataSource = bn;
        }
    }
}
