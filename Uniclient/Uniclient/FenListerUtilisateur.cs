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
    public partial class FenListerUtilisateur : Form
    {
        public Interface.InterfaceUtilisateur Uti;
        public FenListerUtilisateur()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);

            Uti = (Interface.InterfaceUtilisateur)Activator.GetObject(typeof(Interface.InterfaceUtilisateur), "tcp://localhost:1069/objetUtilisateur");
        }

        private void FenListerUtilisateur_Load(object sender, EventArgs e)
        {
            listerutilisateur();
        }
        void listerutilisateur()
        {
            DataSet bd = Uti.ListerUtilisateur();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["utilisateur"];
            dataGridView1.DataSource = bn;
        }
    }
}
