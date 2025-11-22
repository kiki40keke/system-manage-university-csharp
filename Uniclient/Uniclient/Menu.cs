using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniclient
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        void fermer(){
        foreach(Form frm in this.MdiChildren){
            frm.Dispose();
        }
        }
        private void inscrireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fenmen();
            fermer();
            FenEnregistrementEtudiant Fen = new FenEnregistrementEtudiant();
            Fen.MdiParent = this;
            Fen.Show();
            
            
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenrecherEtudiant Fen = new FenrecherEtudiant();
          
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void embaucherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            FenEnregistrement Fen = new FenEnregistrement();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fermer();
            FenListerEmployer Fen = new FenListerEmployer();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            fermer();
            GestionCours Fen = new GestionCours();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            fermer();
            GestionEvaluation Fen = new GestionEvaluation();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            fermer();
            GestionNotes Fen = new GestionNotes();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void creerUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rechercherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenlisterEtudiant Fen = new FenlisterEtudiant();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenEnregistrerUtilisateur Fen = new FenEnregistrerUtilisateur();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void rechercherToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fermer();
            FenRecherUtilisateur Fen = new FenRecherUtilisateur();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenmodalitePaiement Fen = new FenmodalitePaiement();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fermer();
            FenlisterModaliterPaiement Fen = new FenlisterModaliterPaiement();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void versmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            Fendepot Fen = new Fendepot();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            fermer();
            FenListerUtilisateur Fen = new FenListerUtilisateur();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenListerPalmaresse Fen = new FenListerPalmaresse();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerCompToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenlisterPalmaresDetails Fen = new FenlisterPalmaresDetails();
            Fen.MdiParent = this;
            Fen.Show();
           
        }

        private void connecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void embaucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            Form1 Fen = new Form1();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            ListerProffesseur Fen = new ListerProffesseur();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void gestionPalmaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            GestionPalmaresse Fen = new GestionPalmaresse();
            Fen.MdiParent = this;
            Fen.Show();
        }

      

        private void listerDesAnciensModaliteDePaiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenlisterAncienpaiement Fen = new FenlisterAncienpaiement();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void listerDesDepotEtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenListerTransactions Fen = new FenListerTransactions();
            Fen.MdiParent = this;
            Fen.Show();
        }


        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            fermer();
            FenBulletin Fen = new FenBulletin();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void AttributionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fermer();
            SelectionCours Fen = new SelectionCours();
            Fen.MdiParent = this;
            Fen.Show();
        }

        private void lbNomUser_Click(object sender, EventArgs e)
        {

        }

        private void lblfonction_Click(object sender, EventArgs e)
        {

        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Hide();
            Login Lo = new Login();
            
            

            var result = MessageBox.Show("Etes-vous sur de vouloir quitter ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Lo.Show();
                this.Visible = false;
            }
        }

        private void bloqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenBloque Fen = new FenBloque();
            Fen.MdiParent = this;
            Fen.btndeblock.Visible = false;
            Fen.Show();
        }

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            FenBloque Fen = new FenBloque();
            Fen.MdiParent = this;
            Fen.btnBlock.Visible = false;
            Fen.Show();
        }
    }
}
