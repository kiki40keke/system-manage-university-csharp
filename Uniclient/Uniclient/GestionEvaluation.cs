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
    public partial class GestionEvaluation : Form
    {
        public Interface.InterfaceService ser;
        public Interface.InterfaceEvaluationsNormal Eval;
        public GestionEvaluation()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://localhost:1069/objetServicesCours");
            Eval = (Interface.InterfaceEvaluationsNormal)Activator.GetObject(typeof(Interface.InterfaceEvaluationsNormal), "tcp://localhost:1069/objetEvaluation");
        }

        private void btnenreg_Click(object sender, EventArgs e)
        {
            String Codepalmares = txtcodepalmares.Text.Trim();
            String TypesNormal = cbxtype.SelectedItem.ToString();
            String DescriptionsNormal = cbxdescrip.SelectedItem.ToString();
            //decimal co = spincoef.Value;
            //MessageBox.Show(""+co);
            String coe = spincoef.Text;
            try
            {
                int CoeficientNormal = Int32.Parse(coe);
            }
            catch(Exception ff){}

            if (Codepalmares == "" || coe == "") { MessageBox.Show("Remplir les Champs Vides", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                int CoeficientNormal = Int32.Parse(coe);
                string message = "Voulez vous vraiment enregistrer cet Evaluation";
                string title = "Enregistrement";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string messa = Eval.EnregistrerEvaluation(Codepalmares, TypesNormal, DescriptionsNormal, CoeficientNormal);
                    MessageBox.Show(messa);
                    listerEvaluation();
                }
                else
                {
                    // Do something  
                }  
           
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Codepalmares = txtcodepalmares.Text.Trim();
            String TypesNormal = cbxtype.SelectedItem.ToString();
            String DescriptionsNormal = cbxdescrip.SelectedItem.ToString();
            if (Codepalmares == "") { MessageBox.Show("Entrer le Code Du palmaresse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            string codeeval = Eval.RechercherCodeEvaluation(Codepalmares, TypesNormal, DescriptionsNormal);
            txtcodeeval.Text = codeeval;
            if (codeeval == null) { MessageBox.Show("Cet Evaluation n'exites pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
        }

        private void GestionEvaluation_Load(object sender, EventArgs e)
        {
            listerEvaluation();
            cbxdescrip.SelectedIndex = 0;
            cbxtype.SelectedIndex = 0;
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

        void listerEvaluation()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "code Evaluation";
            dataGridView1.Columns[1].Name = "Options";
            dataGridView1.Columns[2].Name = "Cours";
            dataGridView1.Columns[3].Name = "Session";
            dataGridView1.Columns[4].Name = "Niveau";
            dataGridView1.Columns[5].Name = "Promotion";
            dataGridView1.Columns[6].Name = "Vacation";
            dataGridView1.Columns[7].Name = "Codepalmares";
            dataGridView1.Columns[8].Name = "Types";
            dataGridView1.Columns[9].Name = "Description";
            dataGridView1.Columns[10].Name = "Coefficient";



            String[,] Palmares = Eval.ListerEvaluation() ;

            int ligne = Palmares.Length;
            int div = ligne / 11;


            int i;
            for (i = 0; i < div; i++)
            {


                string codeEvaluationsNormal = Palmares[i, 0];
                string NomOptions = Palmares[i, 1];
                string Nomcours = Palmares[i, 2];
                string Session = Palmares[i, 3];
                string Niveau = Palmares[i, 4];
                string Promotions = Palmares[i, 5];
                string vacation = Palmares[i, 6];
                string Codepalmares = Palmares[i, 7];
                string TypesNormal = Palmares[i, 8];
                string DescriptionsNormal = Palmares[i, 9];
                string CoeficientNormal = Palmares[i, 10];
          

                dataGridView1.Rows.Add(codeEvaluationsNormal, NomOptions, Nomcours, Session, Niveau, Promotions, vacation,Codepalmares,TypesNormal,DescriptionsNormal,CoeficientNormal);


            }


        }

        private void txtcodepalmares_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }
    }
}
