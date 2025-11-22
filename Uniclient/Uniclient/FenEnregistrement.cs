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
    public partial class FenEnregistrement : Form
    {
        Service sa = new Service();
        public Interface.InterfaceEmployer Emp;
        private string code;

        String nom, prenom, sexe, nif, adresse, telephone, email, DateNaissance, fonction, Statut;
        bool veri = false;
        public FenEnregistrement()
        {
            InitializeComponent();
            TcpChannel tp = new TcpChannel();
            //ChannelServices.RegisterChannel(tp);
          //  ServiceReseau sera = new ServiceReseau();
           // String reseaux = sera.getRmi();
            Emp = (Interface.InterfaceEmployer)Activator.GetObject(typeof(Interface.InterfaceEmployer), "tcp://localhost:1069/objetEmployer");
         
        }

        public void verifint(KeyPressEventArgs e) {
           char point='.';
            if(char.IsNumber(e.KeyChar)){
            e.Handled = false;
        }
        else if (char.IsControl(e.KeyChar))
        {
            e.Handled = false;
        }
           

        else { e.Handled = true; }
        }
        public void veriflettre(KeyPressEventArgs e)
        {
          //  string lettre = "abcdefg";
            char tiret = '-';
            char apos = '\'';
        
            if (char.IsLetter(e.KeyChar))
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
            else if (apos == (e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }
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

        private void btnembaucher_Click(object sender, EventArgs e)
        {

            int salaire = 0;
            nom = txtnom.Text.Trim().Replace("'", "''");
            prenom = txtPrenom.Text.Trim().Replace("'", "''");
            sexe = cmbSexe.SelectedItem.ToString();
            nif = mskNif.Text.Trim();
            adresse = txtAdresse.Text.Trim().Replace("'", "''");
            telephone = mskTelephone.Text.Trim();
            email = txtEmail.Text.Trim().Replace("'", "''");
            DateNaissance = jDtnaissance.Text;

            fonction = cmbFonction.SelectedItem.ToString();
            String sal = txtsalaire.Text;
            try
            {
                salaire = Int32.Parse(sal);
            }
            catch(Exception ff){}
            Statut = cmbSatut.SelectedItem.ToString();
            verif();

            //if (nom == "" || prenom == "" || adresse == "" || email == "" || sal == "")
            //{
            //    MessageBox.Show("Tous les champs doivent etres remplis", "Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
           
            //}
            //else if (nom.Length < 2 || prenom.Length < 2)
            //{
            //    MessageBox.Show("les champs noms et prenoms ne doivent pas inferieur a un caractere", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            //}
            //else if (nif.Length < 12)
            //{
            //    MessageBox.Show("Le Cin doit contenir 10 Chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //else if (telephone.Length <= 14)
            //{
            //    MessageBox.Show("Les Telephones doivent avoir plus de avoir 8 chiffres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            //}
            //else if (salaire < 5)
            //{
            //    MessageBox.Show("le champs salaire doit etre superieur a 5", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else if (b != true)
            //{
            //    MessageBox.Show("L'email n'est pas correct", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if(veri==false){
                MessageBox.Show("li pa bon");
            }

            else
            {
                MessageBox.Show("li  bon");
                //string message = "Voulez vous vraiment enregistrer cet employer";
                //string title = "Enregistrement";
                //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                //DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                //if (result == DialogResult.Yes)
                //{
                //    MessageBox.Show(Emp.EnregistrerEmployer(nom, prenom, sexe, nif, adresse, telephone, email, DateNaissance, Statut, fonction, salaire), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    renitialiser(); 
                //}
                //else
                //{
                //    // Do something  
                //}  
           
            }
        }

        void renitialiser() {
            txtnom.Clear();
            txtPrenom.Clear();
            mskNif.Clear();
            txtAdresse.Clear();
            mskTelephone.Clear();
            txtEmail.Clear();
            txtsalaire.Clear();
            jDtnaissance.Text = "1996/12/31";
            cmbFonction.SelectedIndex = 0;
            cmbSatut.SelectedIndex = 0;
            cmbSexe.SelectedIndex = 0;
            
            

        }

        void remplirfonction()
        {
            ArrayList Al = new ArrayList();
            Al = Emp.remplirCombofonction();
            cmbFonction.Items.Clear();
            foreach (var item in Al)
            {
             cmbFonction.Items.Add(item);
            }
        }

        void verifsalaire(int salaire) {
           
            string nomfonction = cmbFonction.SelectedItem.ToString();
            ArrayList Al = new ArrayList();
            Al = Emp.recherchersalaire(nomfonction);
            int salaire_mini = (int)Al[0];
            int salaire_maxi= (int)Al[1];
            if(salaire<salaire_mini){
                errorProvider1.SetError(txtsalaire, "Salaire Minimum pour "+nomfonction+" "+salaire_mini);
                veri = false;
            }
            else if (salaire > salaire_maxi)
            {
                errorProvider1.SetError(txtsalaire, "Salaire Maximum pour " + nomfonction + " " + salaire_maxi);
                veri = false;
            }
            else { errorProvider1.SetError(txtsalaire, "");}
           
        
        }
        private void btnRecher_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text.Trim();

            if (code == "")
            {
                MessageBox.Show("Entrer un Code", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ArrayList FicheEmployer = new ArrayList();
                FicheEmployer = Emp.FicheEmployer(code);
                String Code2 = (string)FicheEmployer[0];
           
                if (Code2 != null)
                {
                    txtmodif.Text = (string)FicheEmployer[0];
                    txtnom.Text = (string)FicheEmployer[1];
                    txtPrenom.Text = (string)FicheEmployer[2];
                    cmbSexe.SelectedItem = (string)FicheEmployer[3];
                    mskNif.Text = (string)FicheEmployer[4];
                    txtAdresse.Text = (string)FicheEmployer[5];
                    mskTelephone.Text = (string)FicheEmployer[6];

                    txtEmail.Text = (string)FicheEmployer[7];
                    String datee = (string)FicheEmployer[8];
                    jDtnaissance.Text = datee;

                    cmbSatut.SelectedItem = (string)FicheEmployer[9];
                    cmbFonction.SelectedItem = (string)FicheEmployer[10];
                    String coe = (string)FicheEmployer[11];
                    txtsalaire.Text = coe;
                    panSaisi.Visible = true;
                    btnmodif.Visible = true;
                    btnembaucher.Visible = false;
                }

                else
                {
                    MessageBox.Show("Le code n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    renitialiser();
                panSaisi.Visible = false;
                }
            }
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            code = txtmodif.Text;
            int salaire = 0;
            nom = txtnom.Text.Trim().Replace("'", "''");
            prenom = txtPrenom.Text.Trim().Replace("'", "''");
            sexe = cmbSexe.SelectedItem.ToString();
            nif = mskNif.Text.Trim();
            adresse = txtAdresse.Text.Trim().Replace("'", "''");
            telephone = mskTelephone.Text.Trim();
            email = txtEmail.Text.Trim().Replace("'", "''");
            DateNaissance = jDtnaissance.Text;

            fonction = cmbFonction.SelectedItem.ToString();
            
            String sal = txtsalaire.Text;
            try
            {
                salaire = Int32.Parse(sal);
            }
            catch(Exception ff){}
            Statut = cmbSatut.SelectedItem.ToString();
          verif();
            if(veri==false){
                MessageBox.Show("Valider les formats");
            }

            else
            {
               
                
                    string message = "Voulez vous vraiment Modifier cet employer";
                    string title = "Enregistrement";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show(Emp.ModifierEmployer(nom, prenom, telephone, email, adresse, Statut, salaire, code), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        renitialiser();
                        rbReche_CheckedChanged(sender, e);

                    }
                    else
                    {
                        // Do something  
                    }  
                
            }

        }

        private void FenEnregistrement_Load(object sender, EventArgs e)
        {

            remplirfonction();
            try
            {
                cmbFonction.SelectedIndex = 0;
            }
            catch(Exception){}
            cmbSatut.SelectedIndex = 0;
            cmbSexe.SelectedIndex = 0;
            panSaisi.Visible = false;
            lbcode.Visible = false;
            txtcode.Visible = false;
            btnmodif.Visible = false;
            btnRecher.Visible = false;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEnregistr.Checked == true)
            {
                panSaisi.Visible = true;
                btnmodif.Visible = false;
                lbcode.Visible = false;
                txtcode.Visible = false;
                btnRecher.Visible = false;
                rbReche.Checked = false;
                renitialiser();
                mskNif.Enabled = true;
                cmbFonction.Enabled = true;
            }
            else { 
               panSaisi.Visible = false;
            lbcode.Visible = true;
            txtcode.Visible = true;
            btnmodif.Visible = true;
            btnRecher.Visible = true;
            rbReche.Checked = true;
            mskNif.Enabled = false;
            cmbFonction.Enabled = false;
            renitialiser();
            }
        }

        private void rbReche_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rbReche.Checked == true)
            {
                panSaisi.Visible = false;
                lbcode.Visible = true;
                txtcode.Visible = true;
                btnRecher.Visible = true;
                rbEnregistr.Checked = false;
                renitialiser();
                mskNif.Enabled = false;
                cmbFonction.Enabled = false;

            }
            else {

                btnmodif.Visible = false;
                lbcode.Visible = false;
                txtcode.Visible = false;
                btnRecher.Visible = false;
                rbEnregistr.Checked = true;
                panSaisi.Visible = true;
                mskNif.Enabled = true;
                cmbFonction.Enabled = true;
                renitialiser();
            }
        }

       

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre(e);
        }

        private void txtsalaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            verifint(e);
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            veriflettre2(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void verif() {
            veri = true;
            object sender = new object();
            CancelEventArgs e = new CancelEventArgs();
            txtnom_Validating(sender, e);
            txtPrenom_Validating(sender, e);
            txtAdresse_Validating(sender, e);
            mskNif_Validating(sender, e);
            mskTelephone_Validating(sender, e);
            txtEmail_Validating(sender, e);
            txtsalaire_Validating(sender, e);
        }

        private void txtnom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtnom.Text.Trim()))
            {
                errorProvider1.SetError(txtnom, "Entrez un Nom");
                veri = false;
            }
            else if (txtnom.TextLength < 2)
            {
                errorProvider1.SetError(txtnom, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtnom, "");
               
            }
        }

        private void txtPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrenom.Text.Trim()))
            {
                errorProvider1.SetError(txtPrenom, "Entrez un Prenom");
                veri = false;
            }
            else if (txtPrenom.TextLength < 2)
            {
                errorProvider1.SetError(txtPrenom, "Minimum 2 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtPrenom, "");
               
            }
        }

        private void txtAdresse_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdresse.Text.Trim()))
            {
                errorProvider1.SetError(txtAdresse, "Entrez un Prenom");
                veri = false;
            }
            else if (txtAdresse.TextLength < 4)
            {
                errorProvider1.SetError(txtAdresse, "Minimum 4 caracteres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtAdresse, "");
             
            }
        }

        private void mskNif_Validating(object sender, CancelEventArgs e)
        {
            String nif = mskNif.Text.Trim();
            if (nif.Length < 13)
            {
                errorProvider1.SetError(mskNif, "Entrez 10 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(mskNif, "");
               
            }
        }

        private void mskTelephone_Validating(object sender, CancelEventArgs e)
        {
            String telephone = mskTelephone.Text.Trim();
            if (telephone.Length < 15)
            {
                errorProvider1.SetError(mskTelephone, "Entrez 8 Chifres");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(mskTelephone, "");
                
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                errorProvider1.SetError(txtEmail, "Entrez un email");
                veri = false;
            }
            else if (sa.verifyEmail(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Cet Email n'est pas valide");
                veri = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
               
            }
        }

        private void txtsalaire_Validating(object sender, CancelEventArgs e)
        {
            int salaire = 0;
             try
            {
                salaire = Int32.Parse(txtsalaire.Text);
            }
            catch(Exception ff){}
             if (string.IsNullOrEmpty(txtsalaire.Text.Trim()))
             {
                 errorProvider1.SetError(txtsalaire, "Entrez un salaire");
                 veri = false;
             }
             else {
                 verifsalaire(salaire);
             }

          

           



        }
    }
}
