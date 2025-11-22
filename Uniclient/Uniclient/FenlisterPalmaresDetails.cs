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
using Services;


namespace Uniclient
{
    public partial class FenlisterPalmaresDetails : Form
    {
        
        
        public Interface.InterfacePalmares Pal;
        public FenlisterPalmaresDetails()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
            ServiceReseau ser = new ServiceReseau();
            String reseaux = ser.getRmi();
            Pal = (Interface.InterfacePalmares)Activator.GetObject(typeof(Interface.InterfacePalmares), "tcp://127.0.0.2:1069/objetPalmaresse");
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

        private void FenlisterPalmaresDetails_Load(object sender, EventArgs e)
        {
            colonne(); 
        }

        void colonne() {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "code";
            dataGridView1.Columns[1].Name = "Nom";
            dataGridView1.Columns[2].Name = "Prenom";
            dataGridView1.Columns[3].Name = "Examen Intra";
            dataGridView1.Columns[4].Name = "Devoir Intra";
            dataGridView1.Columns[5].Name = "Examen Final";
            dataGridView1.Columns[6].Name = "Devoir Final";
            dataGridView1.Columns[7].Name = "Total Notes";
            dataGridView1.Columns[8].Name = "Coefficient";
        }
        void listerpalmaresse(string codepal)
        {

            dataGridView1.Columns.Clear();
          

            colonne();
            String[,] Palmares = Pal.ListerPalmares(codepal);

         //   MessageBox.Show(Palmares[1,3].ToString());

            int ligne = Palmares.Length;
            int div = ligne / 9;

            if (div == 0)
            {
                string aver = "soit ce palmares ne contient pas d'etudiant \n soit Le code de ce palmaresse est Incorecte \n si vous vous souvenez pas du code allez dans le Gestion Palmaresse Pour trouvez le code";
                MessageBox.Show(aver, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnimprimer.Visible = false;
            }
            else
            {
                int i;
                for (i = 0; i < div; i++)
                {


                    string code = Palmares[i, 0];
                    string Nom = Palmares[i, 1];
                    string Prenom = Palmares[i, 2];
                    string Intra = Palmares[i, 3];
                    string Intra1 = Palmares[i, 4];
                    string Final = Palmares[i, 5];
                    string Final1 = Palmares[i, 6];
                    string Notes = Palmares[i, 7];
                    string Coefficient = Palmares[i, 8];

                    dataGridView1.Rows.Add(code, Nom, Prenom, Intra, Intra1, Final, Final1, Notes, Coefficient);
                    btnimprimer.Visible = true;


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codepal = txtcodepal.Text.Trim();
            if (codepal == "") { MessageBox.Show("Entrez un code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                listerpalmaresse(codepal);
            }
        }

        private void txtcodepal_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codepalmares = txtcodepal.Text;
            string[,] maliste = Pal.ListerPalmares(codepalmares);
            int ligne = maliste.Length;
            int div = ligne / 9;
            String td = "";
            String tr1 = "<tr>";
            String tr2 = "</tr>";
            int v = 0;
            ArrayList Fiche = new ArrayList();
            for (int i = 0; i < div; i++)
            {
                // System.out.println("<tr>");
                Fiche.Add(tr1);
                for (int j = 0; j < 9; j++)
                {
                    // System.out.println("<td>"+maliste[i][j]+"</td>");
                    td = "<td>" + maliste[i,j] + "</td>";
                    Fiche.Add(td);
                }

                Fiche.Add(tr2);

                //System.out.println("</tr>");
            }
           

            string Name = string.Empty;
            foreach (string str in Fiche)
            {
                string[] loc = str.Split();
                Name += String.Format("[{0}], ", loc[0]);

            }

            String Fiche3 = Name.Replace(",", "");
            String Fiche4 = Fiche3.Replace("[", "");
            String Tbody = Fiche4.Replace("]", "");
          
            ArrayList Al = new ArrayList();
            Al = Pal.RechercherPalmares(codepalmares);
            String NomOption = (string)Al[0];
           
            String NomCours = (string)Al[1];
          
            String NomVacation = (string)Al[2];
            String Promotions = (string)Al[3];
            String Nomsession = (string)Al[4];
        
            String Nomniveaux = (string)Al[5];
           
            RapportPalmares html1 = new RapportPalmares();
            string ht = html1.RapportPalmares1(Tbody, NomOption, NomCours, NomVacation, Promotions, Nomsession, Nomniveaux);
            CreerPdf tr = new CreerPdf();


            string nomfichier = "Palmaresse"; //+ NomOption + NomCours + NomVacation + Nomniveaux + Nomsession + Promotions;
                                              // String DEST = "C:/Users/kelly/source/repos/Uniclient/helloWorld01.pdf";
            tr.createPdf(ht, nomfichier);


        }
    }
}
