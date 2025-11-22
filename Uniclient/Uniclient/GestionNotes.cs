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
    public partial class GestionNotes : Form
    {
        public Interface.InterfaceEvaluationsNormal Eval;
        public Interface.InterfaceNote Note;
        public GestionNotes()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
           // ChannelServices.RegisterChannel(tp);
            ServiceReseau ser = new ServiceReseau();
            String reseaux = ser.getRmi();
            Eval = (Interface.InterfaceEvaluationsNormal)Activator.GetObject(typeof(Interface.InterfaceEvaluationsNormal), "tcp://localhost:1069/objetEvaluation");
            Note = (Interface.InterfaceNote)Activator.GetObject(typeof(Interface.InterfaceNote), "tcp://localhost:1069/objetNote");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codeEvaluationsNormal = txtcodeeval.Text.Trim();
            if (codeEvaluationsNormal == "") { MessageBox.Show("Entrez un Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                listerNotes(codeEvaluationsNormal);
            }

        }

        void colonne(){
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "code";
            dataGridView1.Columns[1].Name = "Nom";
            dataGridView1.Columns[2].Name = "Prenom";
            dataGridView1.Columns[3].Name = "Notes sur";
            dataGridView1.Columns[4].Name = "Coefficient";
            dataGridView1.Columns[5].Name = "Code Evaluation";
        }
        void renitialise() {
            txtcode.Clear();
            txtnote.Clear();
            txtcodeeval2.Clear();
            txtcoef.Clear();
        }
        void listerNotes(String codeEvaluationsNormal)
        {
            dataGridView1.Columns.Clear();

            colonne();

            String[,] ListeNotes = Eval.ListerNotes(codeEvaluationsNormal);

            int ligne = ListeNotes.Length;
            int div = ligne / 6;

            Console.WriteLine(ListeNotes);

            if (div == 0) {
                MessageBox.Show("soit cet evaluation ne contient pas d'etudiant \n soit Le code de cette evaluation est Incorecte \n si vous vous souvenez pas du code allez dans le Gestion Evaluation Pour trouvez le code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                renitialise();
               // MessageBox.Show("" + div);
            }
            else
            {
                renitialise();
              
                int i;
                for (i = 0; i < div; i++)
                {


                    string code = ListeNotes[i, 0].ToString();
                    string Nom = ListeNotes[i, 1];
                    string Prenom = ListeNotes[i, 2];
                    string Note = ListeNotes[i, 3];
                    string Coef = ListeNotes[i, 4];
                    string codeeval = ListeNotes[i, 5];

                    dataGridView1.Rows.Add(code, Nom, Prenom, Note, Coef,codeeval);


                }
            }

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

        private void GestionNotes_Load(object sender, EventArgs e)
        {
            colonne();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void verifint(KeyPressEventArgs e)
        {
            char point = '.';
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }


            else { e.Handled = true; }
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            String codeEvaluationsNormal = txtcodeeval2.Text.Trim();
            String Id_Etud = txtcode.Text;
            String no = txtnote.Text.Trim();
            String coef = txtcoef.Text;
            if (Id_Etud == "") { MessageBox.Show("Veuillez Selectionnez un Etudiant dans la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else if (no == "") { MessageBox.Show("Entrez Une Note", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else if (codeEvaluationsNormal == "") { MessageBox.Show("Effectuez une recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                double note = Double.Parse(no);
                double co = Double.Parse(coef);
                if (co < note)
                {
                    MessageBox.Show("la note doit etre inferieur ou egal au coeficient", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ArrayList Fiche = new ArrayList();
                    Fiche = Note.FicheNote(codeEvaluationsNormal, Id_Etud);
                    String codenoraml = (string)Fiche[0];
                    if (codenoraml == null)
                    {
                        String message = Note.EnregistrerNotesNormalNote(codeEvaluationsNormal, Id_Etud, note);

                        listerNotes(codeEvaluationsNormal);
                        
                    }
                    else
                    {
                        String message = Note.ModifierNote(codeEvaluationsNormal, Id_Etud, note);

                        listerNotes(codeEvaluationsNormal);
                        
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtcode.Text = row.Cells["code"].Value.ToString();
                txtcoef.Text = row.Cells["Coefficient"].Value.ToString();
                txtnote.Text = row.Cells["Notes sur"].Value.ToString();
                txtcodeeval2.Text = row.Cells["Code Evaluation"].Value.ToString();
            }
            //else { MessageBox.Show("li pa bon"); }
        }

        private void txtcoef_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnote_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifint(e);
        }

        private void txtcodeeval_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }
    }
}
