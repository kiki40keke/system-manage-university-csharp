namespace Uniclient
{
    partial class FenEnregistrementEtudiant
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
            this.cbxvacation = new System.Windows.Forms.ComboBox();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxoptioncours = new System.Windows.Forms.ComboBox();
            this.btninscrire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtref = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhoneRespon = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtNif = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxvacation
            // 
            this.cbxvacation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxvacation.FormattingEnabled = true;
            this.cbxvacation.Items.AddRange(new object[] {
            "Matin",
            "Median",
            "Soir",
            "Week-End"});
            this.cbxvacation.Location = new System.Drawing.Point(758, 146);
            this.cbxvacation.Name = "cbxvacation";
            this.cbxvacation.Size = new System.Drawing.Size(159, 21);
            this.cbxvacation.TabIndex = 52;
            // 
            // cmbSexe
            // 
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.FormattingEnabled = true;
            this.cmbSexe.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbSexe.Location = new System.Drawing.Point(132, 61);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(159, 21);
            this.cmbSexe.TabIndex = 49;
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(425, 151);
            this.txtadresse.MaxLength = 100;
            this.txtadresse.Multiline = true;
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(185, 99);
            this.txtadresse.TabIndex = 48;
            this.txtadresse.Validating += new System.ComponentModel.CancelEventHandler(this.txtadresse_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(344, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Adresse :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 151);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 20);
            this.txtEmail.TabIndex = 46;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Email :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Vacation :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(648, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tel Reference :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Date de Naissance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nif :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(425, 18);
            this.txtPrenom.MaxLength = 50;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(159, 20);
            this.txtPrenom.TabIndex = 35;
            this.txtPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtPrenom.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrenom_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sexe :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 18);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(159, 20);
            this.txtNom.TabIndex = 32;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNom_KeyPress);
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nom :";
            // 
            // cbxoptioncours
            // 
            this.cbxoptioncours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxoptioncours.FormattingEnabled = true;
            this.cbxoptioncours.Location = new System.Drawing.Point(425, 102);
            this.cbxoptioncours.Name = "cbxoptioncours";
            this.cbxoptioncours.Size = new System.Drawing.Size(121, 21);
            this.cbxoptioncours.TabIndex = 55;
            // 
            // btninscrire
            // 
            this.btninscrire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btninscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninscrire.ForeColor = System.Drawing.Color.White;
            this.btninscrire.Location = new System.Drawing.Point(758, 201);
            this.btninscrire.Name = "btninscrire";
            this.btninscrire.Size = new System.Drawing.Size(157, 49);
            this.btninscrire.TabIndex = 56;
            this.btninscrire.Text = "Inscrire";
            this.btninscrire.UseVisualStyleBackColor = false;
            this.btninscrire.Click += new System.EventHandler(this.btninscrire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Reference :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtref);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.txtPhoneRespon);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtNif);
            this.panel1.Controls.Add(this.cbxoptioncours);
            this.panel1.Controls.Add(this.btninscrire);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxvacation);
            this.panel1.Controls.Add(this.cmbSexe);
            this.panel1.Controls.Add(this.txtadresse);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(37, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 272);
            this.panel1.TabIndex = 57;
            // 
            // txtref
            // 
            this.txtref.Location = new System.Drawing.Point(758, 64);
            this.txtref.MaxLength = 50;
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(139, 20);
            this.txtref.TabIndex = 90;
            this.txtref.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtref_KeyPress);
            this.txtref.Validating += new System.ComponentModel.CancelEventHandler(this.txtref_Validating);
            // 
            // txtDate
            // 
            this.txtDate.CustomFormat = "yyyy/MM/dd";
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDate.Location = new System.Drawing.Point(758, 25);
            this.txtDate.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.txtDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(139, 20);
            this.txtDate.TabIndex = 89;
            this.txtDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtPhoneRespon
            // 
            this.txtPhoneRespon.Location = new System.Drawing.Point(758, 109);
            this.txtPhoneRespon.Mask = "+\\5\\0\\9 ####-####";
            this.txtPhoneRespon.Name = "txtPhoneRespon";
            this.txtPhoneRespon.Size = new System.Drawing.Size(159, 20);
            this.txtPhoneRespon.TabIndex = 59;
            this.txtPhoneRespon.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneRespon_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 106);
            this.txtPhone.Mask = "+\\5\\0\\9####-####";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(159, 20);
            this.txtPhone.TabIndex = 58;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // txtNif
            // 
            this.txtNif.Location = new System.Drawing.Point(425, 65);
            this.txtNif.Mask = "###-###-###-#";
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(159, 20);
            this.txtNif.TabIndex = 57;
            this.txtNif.Validating += new System.ComponentModel.CancelEventHandler(this.txtNif_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 62);
            this.panel2.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(687, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tous les champs sont Obligatoire\r\nVous n\'avez qu\'a cliquer sur le Bouton Inscrire" +
    " Pour Valider l\'inscription de l\'etudiant.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 100);
            this.panel3.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(285, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(451, 55);
            this.label14.TabIndex = 0;
            this.label14.Text = "Inscription Etudiant";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FenEnregistrementEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FenEnregistrementEtudiant";
            this.Text = "FenEnregistrementEtudiant";
            this.Load += new System.EventHandler(this.FenEnregistrementEtudiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxvacation;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxoptioncours;
        private System.Windows.Forms.Button btninscrire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtNif;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtPhoneRespon;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}