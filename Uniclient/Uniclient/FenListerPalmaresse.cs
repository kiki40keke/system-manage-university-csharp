using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Uniclient
{
    public partial class FenListerPalmaresse : Form
    {
        public Interface.InterfacePalmares Pal;
       
       
        public FenListerPalmaresse()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            Pal = (Interface.InterfacePalmares)Activator.GetObject(typeof(Interface.InterfacePalmares), "tcp://localhost:1069/objetPalmaresse");
        }

        private void FenListerPalmaresse_Load(object sender, EventArgs e)
        {
            listerpalmaresse();
           
        }

        void listerpalmaresse() {

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "code";
            dataGridView1.Columns[1].Name = "Options";
            dataGridView1.Columns[2].Name = "Cours";
            dataGridView1.Columns[3].Name = "Vacation";
            dataGridView1.Columns[4].Name = "Coefficient";
            dataGridView1.Columns[5].Name = "Promotion";
            dataGridView1.Columns[6].Name = "Date";



            String[,] Palmares = Pal.ListerPalmares2();

            int ligne = Palmares.Length;
            int div = ligne / 7;


            int i;
            for (i = 0; i < div; i++)
            {
                string Codepalmares = Palmares[i, 0];
                string NomOptions = Palmares[i, 1];
                string Nomcours = Palmares[i, 2];
                string Vacation = Palmares[i, 3];
                string Coefficient = Palmares[i, 4];
                string Promotions = Palmares[i, 5];
                string Date = Palmares[i, 6];

                dataGridView1.Rows.Add(Codepalmares, NomOptions, Nomcours, Vacation, Coefficient, Promotions, Date);
            }
   
        
        }
    }
}
