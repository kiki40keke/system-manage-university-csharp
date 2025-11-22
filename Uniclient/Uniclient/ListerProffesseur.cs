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
    public partial class ListerProffesseur : Form
    {
        public Interface.InterfaceProfesseur inte;
        public ListerProffesseur()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;
            inte = (Interface.InterfaceProfesseur)Activator.GetObject(typeof(Interface.InterfaceProfesseur), "tcp://localhost:1069/objetProfesseur");
        }

        private void ListerProffesseur_Load(object sender, EventArgs e)
        {
            DataSet bd = inte.listerProfesseur();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["professeur"];
            dataGridView1.DataSource = bn;
        }
    }
}
