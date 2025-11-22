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
using Services;

namespace Uniclient
{
    public partial class FenBulletin : Form
    {
        public Interface.InterfaceNote Note;
        public Interface.InterfaceService ser;
        public Interface.IEtudiants Etu;
        Service s = new Service();
        public FenBulletin()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
          //  ChannelServices.RegisterChannel(tp);
            ServiceReseau sera = new ServiceReseau();
            String reseaux = sera.getRmi();
            Note = (Interface.InterfaceNote)Activator.GetObject(typeof(Interface.InterfaceNote), "tcp://127.0.0.2:1069/objetNote");
            ser = (Interface.InterfaceService)Activator.GetObject(typeof(Interface.InterfaceService), "tcp://127.0.0.1:1069/objetServicesCours");
            Etu = (Interface.IEtudiants)Activator.GetObject(typeof(Interface.IEtudiants), "tcp://127.0.0.1:1069/objetEtudiant");
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
        private void FenBulletin_Load(object sender, EventArgs e)
        {
           
            
            cbxsession.SelectedIndex = 0;
            cbxniveau.SelectedIndex = 0;
           
        }

        void Listerbulletin(String Nom_Opt, String codeniv, String codesession, String Id_Etud, String NomVacation, String Promotion)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Cours";
            dataGridView1.Columns[1].Name = "Notes";
            dataGridView1.Columns[2].Name = "Sur";
            dataGridView1.Columns[3].Name = "Reprises 1";
            dataGridView1.Columns[4].Name = "Reprises 2";



            String[,] ListeNotes = Note.ListerBulletin(Nom_Opt, codeniv, codesession, Id_Etud, NomVacation, Promotion);

            int ligne = ListeNotes.Length;
            int div = ligne / 5;


            //MessageBox.Show(ListeNotes[0, 0].ToString());
           
            int i;
            for (i = 0; i < div; i++)
            {


                string code = ListeNotes[i, 0].ToString();
                string Nom = ListeNotes[i, 1];
                string Prenom = ListeNotes[i, 2];
                string Notes = ListeNotes[i, 3];
                string Coef = ListeNotes[i, 4];

                dataGridView1.Rows.Add(code, Nom, Prenom, Notes, Coef);


            }


        }

     

        private void txtpromotion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbulletin_Click(object sender, EventArgs e)
        {
            String CodeEt = txtCodeEt.Text.Trim();
            if (CodeEt == "")
            {
                MessageBox.Show("Entrez un Code","Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList fiche = new ArrayList();
                fiche = Etu.FicheEtudiant(CodeEt);
                string Id_Etud = (string)fiche[0];
                if (Id_Etud != null)
                {
                  
                    String codeniv = cbxniveau.SelectedItem.ToString();
                    String codesession = cbxsession.SelectedItem.ToString();
                    String NomVacation = (string)fiche[11];
                    String Promotion = (string)fiche[13];
                    String niv = (string)fiche[14];
                    int niv2 = Int32.Parse(niv);
                    string Nomopt = (string)fiche[12];

                    lbloptions.Text = "Options : " + Nomopt;
                    lblvacation.Text = "Vacation : " + NomVacation;
                    lblpromo.Text = "Promotion : " + Promotion;

                    ArrayList RechercherBulletin = new ArrayList();
                    RechercherBulletin = Note.RechercherBulletin(codeniv, codesession, Id_Etud);
                    String Options = (string)RechercherBulletin[0];
                    String Groupe = (string)RechercherBulletin[1];
                    String Exer = (string)RechercherBulletin[2];
                    int ex = Int32.Parse(Exer);
                    int ext = ex + niv2;
                    String Exercice = Exer + "-" + ext;
                    String Session = (string)RechercherBulletin[3];
                    String Niveau = (string)RechercherBulletin[4];
                    String Nom = (string)RechercherBulletin[5];
                    String Prenom = (string)RechercherBulletin[6];
                    String Matricule = (string)RechercherBulletin[7];
                    String Total1 = (string)RechercherBulletin[8];
                    String Total2 = (string)RechercherBulletin[9];
                    String Moyenne = (string)RechercherBulletin[10];
                    double moy = Double.Parse(Moyenne);
                
                    string moyenne2 = String.Format("{0:0.##}", moy);
                    lblNom.Text = ("Nom: " + Nom);
                    lblPrenom.Text = ("Prenom: " + Prenom);
                    lbltotal.Text = ("Total " + Total1 + " Sur " + Total2);
               //     MessageBox.Show(Total1);
                    lblmoy.Text = ("Moyenne " + moyenne2 + " Sur 10 ");
                    if (Moyenne == "0" || Total1 == "0") 
                    {
                        MessageBox.Show("Cet Etudiant ne contient pas de notes dans aucun Palmares de ce niveau et cette Session", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        panbulletin.Visible = false;
                    }
                    else
                    {

                        Listerbulletin(Nomopt, codeniv, codesession, Id_Etud, NomVacation, Promotion);
                        panbulletin.Visible = true;
                        panrech.Visible = false;
                    
                    }
                }
                else
                {
                    MessageBox.Show("le code est incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    panbulletin.Visible = false; }

            }
        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void lbloptions_Click(object sender, EventArgs e)
        {

        }

        private void lblvacation_Click(object sender, EventArgs e)
        {

        }

        private void lblpromo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodeEt_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
            String CodeEt = txtCodeEt.Text.Trim();
            String codeniv = cbxniveau.SelectedItem.ToString();
            String codesession = cbxsession.SelectedItem.ToString();

            int var = bulletin(codeniv, CodeEt, codesession);
            if(var==1){
                ArrayList fiche = new ArrayList();
                fiche = Etu.FicheEtudiant(CodeEt);
                string Id_Etud = (string)fiche[0];
               

           
                    string email = (string)fiche[7];
                    String NomVacation = (string)fiche[11];
                    String Promotion = (string)fiche[13];
                    String niv = (string)fiche[14];
                    int niv2 = Int32.Parse(niv);
                    string Nomopt = (string)fiche[12];

                    lbloptions.Text = "Options : " + Nomopt;
                    lblvacation.Text = "Vacation : " + NomVacation;
                    lblpromo.Text = "Promotion : " + Promotion;

                    ArrayList RechercherBulletin = new ArrayList();
                    RechercherBulletin = Note.RechercherBulletin(codeniv, codesession, Id_Etud);
                    String Options = (string)RechercherBulletin[0];
                    String Groupe = (string)RechercherBulletin[1];
                    String Exer = (string)RechercherBulletin[2];
                    int ex = Int32.Parse(Exer);
                    int ext = ex + niv2;
                    String Exercice = Exer + "-" + ext;
                    String Session = (string)RechercherBulletin[3];
                    String Niveau = (string)RechercherBulletin[4];
                    String Nom = (string)RechercherBulletin[5];
                    String Prenom = (string)RechercherBulletin[6];
                    String Matricule = (string)RechercherBulletin[7];
                    String Total1 = (string)RechercherBulletin[8];
                    String Total2 = (string)RechercherBulletin[9];
                    String Moyenne = (string)RechercherBulletin[10];
                    double moy = Double.Parse(Moyenne);

                    string moyenne2 = String.Format("{0:0.##}", moy);
                   
                   

                        String[,] maliste = Note.ListerBulletin(Options, codeniv, codesession, Id_Etud, NomVacation, Promotion);
                        int ligne = maliste.Length;
                        int div = ligne / 5;
                        String td="";
            String tr1="<tr>";
            String tr2="</tr>";
            int v=0;
            ArrayList Fiche=new ArrayList();
            for(int i=0;i<div;i++){
             
                Fiche.Add(tr1);
                for(int j=0;j<5;j++){
                   
                    td="<td>"+maliste[i,j]+"</td>";
                    Fiche.Add(td);
                }
                
                Fiche.Add(tr2);
                
          
            }
            string Fiche2 = Fiche.ToString();
          
            string Name = string.Empty;
            foreach (string str in Fiche)
            {
                string[] loc = str.Split();
                Name += String.Format("[{0}], ", loc[0]);
     
            }
            String Fiche3 = Name.Replace(",", "");
            String Fiche4 = Fiche3.Replace("[", "");
            String Tbody = Fiche4.Replace("]", "");

          //  MessageBox.Show(Tbody);

            BulletinHtmlEtudiant html = new BulletinHtmlEtudiant();
            string ht = html.BulletinHtmlEtudiant1(Options, Niveau, Session, Exercice, Nom, Prenom, Matricule, Groupe, Total1, Total2, moyenne2, Tbody);
            //    MessageBox.Show(ht);
            string msa = s.sendEmail(email, ht,"Bulletin");
            MessageBox.Show(msa);
                    
                
               
        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CodeEt = txtCodeEt.Text.Trim();
            String codeniv = cbxniveau.SelectedItem.ToString();
            String codesession = cbxsession.SelectedItem.ToString();
            bulletin(codeniv,CodeEt,codesession);
        }

        int bulletin(string Niv, string CodeEtud, string session) {
            int permis = 0;
            permis=Etu.verifierpaie( Niv,  CodeEtud,  session);
            if (permis == 0)
            {
                MessageBox.Show("cette Etudiant a une dette pour cette session");
            }
            else if (permis == 1) {}
            return permis;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panrech.Visible = true;
            panbulletin.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            String CodeEt = txtCodeEt.Text.Trim();
            String codeniv = cbxniveau.SelectedItem.ToString();
            String codesession = cbxsession.SelectedItem.ToString();

            int var = bulletin(codeniv, CodeEt, codesession);
            if (var == 1)
            {
                ArrayList fiche = new ArrayList();
                fiche = Etu.FicheEtudiant(CodeEt);
                string Id_Etud = (string)fiche[0];



                string email = (string)fiche[7];
                String NomVacation = (string)fiche[11];
                String Promotion = (string)fiche[13];
                String niv = (string)fiche[14];
                int niv2 = Int32.Parse(niv);
                string Nomopt = (string)fiche[12];

                lbloptions.Text = "Options : " + Nomopt;
                lblvacation.Text = "Vacation : " + NomVacation;
                lblpromo.Text = "Promotion : " + Promotion;

                ArrayList RechercherBulletin = new ArrayList();
                RechercherBulletin = Note.RechercherBulletin(codeniv, codesession, Id_Etud);
                String Options = (string)RechercherBulletin[0];
                String Groupe = (string)RechercherBulletin[1];
                String Exer = (string)RechercherBulletin[2];
                int ex = Int32.Parse(Exer);
                int ext = ex + niv2;
                String Exercice = Exer + "-" + ext;
                String Session = (string)RechercherBulletin[3];
                String Niveau = (string)RechercherBulletin[4];
                String Nom = (string)RechercherBulletin[5];
                String Prenom = (string)RechercherBulletin[6];
                String Matricule = (string)RechercherBulletin[7];
                String Total1 = (string)RechercherBulletin[8];
                String Total2 = (string)RechercherBulletin[9];
                String Moyenne = (string)RechercherBulletin[10];
                double moy = Double.Parse(Moyenne);

                string moyenne2 = String.Format("{0:0.##}", moy);



                string[,] maliste = Note.ListerBulletin(Options, codeniv, codesession, Id_Etud, NomVacation, Promotion);
                int ligne = maliste.Length;
                int div = ligne / 5;
                String td = "";
                String tr1 = "<tr>";
                String tr2 = "</tr>";
                int v = 0;
                ArrayList Fiche = new ArrayList();
                for (int i = 0; i < div; i++)
                {

                    Fiche.Add(tr1);
                    for (int j = 0; j < 5; j++)
                    {

                        td = "<td>" + maliste[i, j] + "</td>";
                        Fiche.Add(td);
                    }

                    Fiche.Add(tr2);


                }
                string Fiche2 = Fiche.ToString();

                string Name = string.Empty;
                foreach (string str in Fiche)
                {
                    string[] loc = str.Split();
                    Name += String.Format("[{0}], ", loc[0]);

                }
                String Fiche3 = Name.Replace(",", "");
                String Fiche4 = Fiche3.Replace("[", "");
                String Tbody = Fiche4.Replace("]", "");

                //  MessageBox.Show(Tbody);

                BulletinHtmlEtudiant html1 = new BulletinHtmlEtudiant();
                string ht = html1.BulletinHtmlEtudiant1(Options, Niveau, Session, Exercice, Nom, Prenom, Matricule, Groupe, Total1, Total2, moyenne2, Tbody);
            
                CreerPdf tr = new CreerPdf();
               
               
                string nomfichier = "Bulletin" + Nom + Prenom + Niveau + Session;
                // String DEST = "C:/Users/kelly/source/repos/Uniclient/helloWorld01.pdf";
                // MessageBox.Show();
                tr.createPdf(ht, nomfichier);


            }
          
        }
    }
}
