namespace Uniclient
{
    partial class FenEnregistrement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbSatut = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFonction = new System.Windows.Forms.ComboBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnembaucher = new System.Windows.Forms.Button();
            this.lbcode = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnRecher = new System.Windows.Forms.Button();
            this.btnmodif = new System.Windows.Forms.Button();
            this.panSaisi = new System.Windows.Forms.Panel();
            this.txtmodif = new System.Windows.Forms.TextBox();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.jDtnaissance = new System.Windows.Forms.DateTimePicker();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mskNif = new System.Windows.Forms.MaskedTextBox();
            this.rbEnregistr = new System.Windows.Forms.RadioButton();
            this.rbReche = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panSaisi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSatut
            // 
            this.cmbSatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatut.FormattingEnabled = true;
            this.cmbSatut.Items.AddRange(new object[] {
            "Celibataire ",
            "En Couple"});
            this.cmbSatut.Location = new System.Drawing.Point(367, 114);
            this.cmbSatut.Name = "cmbSatut";
            this.cmbSatut.Size = new System.Drawing.Size(121, 21);
            this.cmbSatut.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Salaire";
            // 
            // cmbFonction
            // 
            this.cmbFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFonction.FormattingEnabled = true;
            this.cmbFonction.Location = new System.Drawing.Point(367, 152);
            this.cmbFonction.Name = "cmbFonction";
            this.cmbFonction.Size = new System.Drawing.Size(159, 21);
            this.cmbFonction.TabIndex = 76;
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbSexe.Location = new System.Drawing.Point(86, 83);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(159, 21);
            this.cmbSexe.TabIndex = 73;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(86, 193);
            this.txtAdresse.MaxLength = 50;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(159, 20);
            this.txtAdresse.TabIndex = 72;
            this.txtAdresse.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresse_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 71;
            this.label13.Text = "Adresse :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 157);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 70;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Fonction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Date de Naissance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Statut";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Cin :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(367, 34);
            this.txtPrenom.MaxLength = 25;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(159, 20);
            this.txtPrenom.TabIndex = 60;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrenom_KeyPress);
            this.txtPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenom_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Sexe :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(86, 39);
            this.txtnom.MaxLength = 25;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(159, 20);
            this.txtnom.TabIndex = 57;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            this.txtnom.Validating += new System.ComponentModel.CancelEventHandler(this.txtnom_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Nom :";
            // 
            // btnembaucher
            // 
            this.btnembaucher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnembaucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnembaucher.ForeColor = System.Drawing.Color.White;
            this.btnembaucher.Location = new System.Drawing.Point(662, 83);
            this.btnembaucher.Name = "btnembaucher";
            this.btnembaucher.Size = new System.Drawing.Size(159, 50);
            this.btnembaucher.TabIndex = 80;
            this.btnembaucher.Text = "Embaucher";
            this.btnembaucher.UseVisualStyleBackColor = false;
            this.btnembaucher.Click += new System.EventHandler(this.btnembaucher_Click);
            // 
            // lbcode
            // 
            this.lbcode.AutoSize = true;
            this.lbcode.Location = new System.Drawing.Point(605, 124);
            this.lbcode.Name = "lbcode";
            this.lbcode.Size = new System.Drawing.Size(32, 13);
            this.lbcode.TabIndex = 81;
            this.lbcode.Text = "Code";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(682, 121);
            this.txtcode.MaxLength = 25;
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(132, 20);
            this.txtcode.TabIndex = 82;
            this.txtcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode_KeyPress);
            // 
            // btnRecher
            // 
            this.btnRecher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRecher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecher.ForeColor = System.Drawing.Color.White;
            this.btnRecher.Location = new System.Drawing.Point(820, 111);
            this.btnRecher.Name = "btnRecher";
            this.btnRecher.Size = new System.Drawing.Size(130, 39);
            this.btnRecher.TabIndex = 83;
            this.btnRecher.Text = "Rechercher";
            this.btnRecher.UseVisualStyleBackColor = false;
            this.btnRecher.Click += new System.EventHandler(this.btnRecher_Click);
            // 
            // btnmodif
            // 
            this.btnmodif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmodif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodif.ForeColor = System.Drawing.Color.White;
            this.btnmodif.Location = new System.Drawing.Point(662, 152);
            this.btnmodif.Name = "btnmodif";
            this.btnmodif.Size = new System.Drawing.Size(159, 52);
            this.btnmodif.TabIndex = 84;
            this.btnmodif.Text = "Modifier";
            this.btnmodif.UseVisualStyleBackColor = false;
            this.btnmodif.Click += new System.EventHandler(this.btnmodif_Click);
            // 
            // panSaisi
            // 
            this.panSaisi.Controls.Add(this.txtmodif);
            this.panSaisi.Controls.Add(this.txtsalaire);
            this.panSaisi.Controls.Add(this.jDtnaissance);
            this.panSaisi.Controls.Add(this.mskTelephone);
            this.panSaisi.Controls.Add(this.mskNif);
            this.panSaisi.Controls.Add(this.txtnom);
            this.panSaisi.Controls.Add(this.btnmodif);
            this.panSaisi.Controls.Add(this.label3);
            this.panSaisi.Controls.Add(this.label4);
            this.panSaisi.Controls.Add(this.cmbSexe);
            this.panSaisi.Controls.Add(this.btnembaucher);
            this.panSaisi.Controls.Add(this.label7);
            this.panSaisi.Controls.Add(this.label1);
            this.panSaisi.Controls.Add(this.cmbSatut);
            this.panSaisi.Controls.Add(this.cmbFonction);
            this.panSaisi.Controls.Add(this.label12);
            this.panSaisi.Controls.Add(this.label11);
            this.panSaisi.Controls.Add(this.txtEmail);
            this.panSaisi.Controls.Add(this.label5);
            this.panSaisi.Controls.Add(this.label9);
            this.panSaisi.Controls.Add(this.txtPrenom);
            this.panSaisi.Controls.Add(this.txtAdresse);
            this.panSaisi.Controls.Add(this.label6);
            this.panSaisi.Controls.Add(this.label13);
            this.panSaisi.Controls.Add(this.label8);
            this.panSaisi.Location = new System.Drawing.Point(12, 163);
            this.panSaisi.Name = "panSaisi";
            this.panSaisi.Size = new System.Drawing.Size(1022, 302);
            this.panSaisi.TabIndex = 85;
            // 
            // txtmodif
            // 
            this.txtmodif.Location = new System.Drawing.Point(855, 265);
            this.txtmodif.Name = "txtmodif";
            this.txtmodif.Size = new System.Drawing.Size(132, 20);
            this.txtmodif.TabIndex = 90;
            this.txtmodif.Visible = false;
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(367, 191);
            this.txtsalaire.MaxLength = 4;
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(159, 20);
            this.txtsalaire.TabIndex = 89;
            this.txtsalaire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalaire_KeyPress);
            this.txtsalaire.Validating += new System.ComponentModel.CancelEventHandler(this.txtsalaire_Validating);
            // 
            // jDtnaissance
            // 
            this.jDtnaissance.CustomFormat = "yyyy/MM/dd";
            this.jDtnaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.jDtnaissance.Location = new System.Drawing.Point(662, 31);
            this.jDtnaissance.MaxDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.jDtnaissance.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.jDtnaissance.Name = "jDtnaissance";
            this.jDtnaissance.Size = new System.Drawing.Size(139, 20);
            this.jDtnaissance.TabIndex = 88;
            this.jDtnaissance.Value = new System.DateTime(1996, 12, 31, 0, 0, 0, 0);
            // 
            // mskTelephone
            // 
            this.mskTelephone.Location = new System.Drawing.Point(86, 121);
            this.mskTelephone.Mask = "(+\\5\\0\\9)####-####";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(159, 20);
            this.mskTelephone.TabIndex = 86;
            this.mskTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.mskTelephone_Validating);
            // 
            // mskNif
            // 
            this.mskNif.Location = new System.Drawing.Point(367, 76);
            this.mskNif.Mask = "###-###-###-#";
            this.mskNif.Name = "mskNif";
            this.mskNif.Size = new System.Drawing.Size(159, 20);
            this.mskNif.TabIndex = 85;
            this.mskNif.Validating += new System.ComponentModel.CancelEventHandler(this.mskNif_Validating);
            // 
            // rbEnregistr
            // 
            this.rbEnregistr.AutoSize = true;
            this.rbEnregistr.Location = new System.Drawing.Point(28, 121);
            this.rbEnregistr.Name = "rbEnregistr";
            this.rbEnregistr.Size = new System.Drawing.Size(75, 17);
            this.rbEnregistr.TabIndex = 86;
            this.rbEnregistr.TabStop = true;
            this.rbEnregistr.Text = "Enregistrer";
            this.rbEnregistr.UseVisualStyleBackColor = true;
            this.rbEnregistr.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbReche
            // 
            this.rbReche.AutoSize = true;
            this.rbReche.Location = new System.Drawing.Point(140, 121);
            this.rbReche.Name = "rbReche";
            this.rbReche.Size = new System.Drawing.Size(81, 17);
            this.rbReche.TabIndex = 87;
            this.rbReche.TabStop = true;
            this.rbReche.Text = "Rechercher";
            this.rbReche.UseVisualStyleBackColor = true;
            this.rbReche.CheckedChanged += new System.EventHandler(this.rbReche_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 94);
            this.panel1.TabIndex = 88;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(390, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion Employer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(1, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 57);
            this.panel2.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(727, 40);
            this.label10.TabIndex = 0;
            this.label10.Text = "Vous pouvez embaucher un employe et faire un recherche puis apporter une modifica" +
    "tion.\r\nVous n\'avez qu\'a cliquer sur le button dont vous voulez faire l\'action.";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FenEnregistrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbReche);
            this.Controls.Add(this.rbEnregistr);
            this.Controls.Add(this.panSaisi);
            this.Controls.Add(this.btnRecher);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.lbcode);
            this.MaximizeBox = false;
            this.Name = "FenEnregistrement";
            this.Text = "FenEnregistrement";
            this.Load += new System.EventHandler(this.FenEnregistrement_Load);
            this.panSaisi.ResumeLayout(false);
            this.panSaisi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSatut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFonction;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnembaucher;
        private System.Windows.Forms.Label lbcode;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnRecher;
        private System.Windows.Forms.Button btnmodif;
        private System.Windows.Forms.Panel panSaisi;
        private System.Windows.Forms.RadioButton rbEnregistr;
        private System.Windows.Forms.RadioButton rbReche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskNif;
        private System.Windows.Forms.MaskedTextBox mskTelephone;
        private System.Windows.Forms.DateTimePicker jDtnaissance;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.TextBox txtmodif;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}