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
    public partial class FenlisterEtudiant : Form
    {
        public Interface.IEtudiants Etu;
        public FenlisterEtudiant()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            // inte = inter;

            Etu = (Interface.IEtudiants)Activator.GetObject(typeof(Interface.IEtudiants), "tcp://localhost:1069/objetEtudiant");
        }

        private void FenlisterEtudiant_Load(object sender, EventArgs e)
        {
            listeretudiant();
        }
        void listeretudiant()
        {
            DataSet bd = Etu.ListerEtudiant();
            BindingSource bn = new BindingSource();
            bn.DataSource = bd.Tables["Etudiant"];
            dataGridView1.DataSource = bn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
