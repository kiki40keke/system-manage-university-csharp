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
    public partial class FenListerEmployer : Form
    {
        public Interface.InterfaceEmployer Emp;
        public FenListerEmployer()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();

           // ChannelServices.RegisterChannel(tp);
            Emp = (Interface.InterfaceEmployer)Activator.GetObject(typeof(Interface.InterfaceEmployer), "tcp://localhost:1069/objetEmployer");
        }

        private void FenListerEmployer_Load(object sender, EventArgs e)
        {
            listeremployert();
        }
        void listeremployert()
        {
            DataSet bd = Emp.ListerEmployer();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["personne"];
            dataGridView1.DataSource = bn;
        }
    }
}
