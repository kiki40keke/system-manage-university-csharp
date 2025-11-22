namespace Uniclient
{
    partial class Form1
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
            this.btnenregprof = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodeprof = new System.Windows.Forms.Label();
            this.txtcodeprof = new System.Windows.Forms.TextBox();
            this.txtnomprof = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprenomprof = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtemailprof = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtadresseprof = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxsexeprof = new System.Windows.Forms.ComboBox();
            this.txtnumref = new System.Windows.Forms.MaskedTextBox();
            this.cbxEtat = new System.Windows.Forms.ComboBox();
            this.btnrechercherprof = new System.Windows.Forms.Button();
            this.btnmodifprof = new System.Windows.Forms.Button();
            this.rdbEnreg = new System.Windows.Forms.CheckBox();
            this.rdbseach = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panSaisi = new System.Windows.Forms.Panel();
            this.cbxprofession = new System.Windows.Forms.ComboBox();
            this.txtmodif = new System.Windows.Forms.TextBox();
            this.jDtnaissance = new System.Windows.Forms.DateTimePicker();
            this.txtmatriculeprof = new System.Windows.Forms.MaskedTextBox();
            this.txttelprof = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panSaisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnenregprof
            // 
            this.btnenregprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnenregprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregprof.ForeColor = System.Drawing.Color.White;
            this.btnenregprof.Location = new System.Drawing.Point(567, 193);
            this.btnenregprof.Name = "btnenregprof";
            this.btnenregprof.Size = new System.Drawing.Size(188, 40);
            this.btnenregprof.TabIndex = 0;
            this.btnenregprof.Text = "Embaucher";
            this.btnenregprof.UseVisualStyleBackColor = false;
            this.btnenregprof.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(414, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professeur";
            // 
            // lblcodeprof
            // 
            this.lblcodeprof.AutoSize = true;
            this.lblcodeprof.BackColor = System.Drawing.Color.Transparent;
            this.lblcodeprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodeprof.Location = new System.Drawing.Point(523, 95);
            this.lblcodeprof.Name = "lblcodeprof";
            this.lblcodeprof.Size = new System.Drawing.Size(52, 18);
            this.lblcodeprof.TabIndex = 2;
            this.lblcodeprof.Text = "Code :";
            this.lblcodeprof.Click += new System.EventHandler(this.lblcodeprof_Click);
            // 
            // txtcodeprof
            // 
            this.txtcodeprof.Location = new System.Drawing.Point(581, 95);
            this.txtcodeprof.Name = "txtcodeprof";
            this.txtcodeprof.Size = new System.Drawing.Size(159, 20);
            this.txtcodeprof.TabIndex = 3;
            this.txtcodeprof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodeprof_KeyPress);
            // 
            // txtnomprof
            // 
            this.txtnomprof.Location = new System.Drawing.Point(102, 29);
            this.txtnomprof.MaxLength = 50;
            this.txtnomprof.Name = "txtnomprof";
            this.txtnomprof.Size = new System.Drawing.Size(159, 20);
            this.txtnomprof.TabIndex = 5;
            this.txtnomprof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomprof_KeyPress);
            this.txtnomprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtnomprof_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sexe :";
            // 
            // txtprenomprof
            // 
            this.txtprenomprof.Location = new System.Drawing.Point(374, 27);
            this.txtprenomprof.MaxLength = 50;
            this.txtprenomprof.Name = "txtprenomprof";
            this.txtprenomprof.Size = new System.Drawing.Size(159, 20);
            this.txtprenomprof.TabIndex = 9;
            this.txtprenomprof.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprenomprof_KeyPress);
            this.txtprenomprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtprenomprof_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prenom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(291, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nif :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telephone :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Proffession :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date de Naissance :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(636, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Reference :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(636, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Etat :";
            // 
            // txtemailprof
            // 
            this.txtemailprof.Location = new System.Drawing.Point(100, 203);
            this.txtemailprof.MaxLength = 100;
            this.txtemailprof.Name = "txtemailprof";
            this.txtemailprof.Size = new System.Drawing.Size(159, 20);
            this.txtemailprof.TabIndex = 23;
            this.txtemailprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailprof_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email :";
            // 
            // txtadresseprof
            // 
            this.txtadresseprof.Location = new System.Drawing.Point(374, 201);
            this.txtadresseprof.MaxLength = 100;
            this.txtadresseprof.Multiline = true;
            this.txtadresseprof.Name = "txtadresseprof";
            this.txtadresseprof.Size = new System.Drawing.Size(169, 58);
            this.txtadresseprof.TabIndex = 25;
            this.txtadresseprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtadresseprof_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Adresse :";
            // 
            // cbxsexeprof
            // 
            this.cbxsexeprof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsexeprof.FormattingEnabled = true;
            this.cbxsexeprof.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cbxsexeprof.Location = new System.Drawing.Point(102, 87);
            this.cbxsexeprof.Name = "cbxsexeprof";
            this.cbxsexeprof.Size = new System.Drawing.Size(159, 21);
            this.cbxsexeprof.TabIndex = 27;
            // 
            // txtnumref
            // 
            this.txtnumref.Location = new System.Drawing.Point(790, 96);
            this.txtnumref.Mask = "(+\\5\\0\\9)####-####";
            this.txtnumref.Name = "txtnumref";
            this.txtnumref.Size = new System.Drawing.Size(159, 20);
            this.txtnumref.TabIndex = 29;
            this.txtnumref.Validating += new System.ComponentModel.CancelEventHandler(this.txtnumref_Validating);
            // 
            // cbxEtat
            // 
            this.cbxEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEtat.FormattingEnabled = true;
            this.cbxEtat.Items.AddRange(new object[] {
            "Actif",
            "Passif"});
            this.cbxEtat.Location = new System.Drawing.Point(790, 153);
            this.cbxEtat.Name = "cbxEtat";
            this.cbxEtat.Size = new System.Drawing.Size(159, 21);
            this.cbxEtat.TabIndex = 30;
            // 
            // btnrechercherprof
            // 
            this.btnrechercherprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrechercherprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercherprof.ForeColor = System.Drawing.Color.White;
            this.btnrechercherprof.Location = new System.Drawing.Point(746, 82);
            this.btnrechercherprof.Name = "btnrechercherprof";
            this.btnrechercherprof.Size = new System.Drawing.Size(147, 45);
            this.btnrechercherprof.TabIndex = 31;
            this.btnrechercherprof.Text = "Rechercher";
            this.btnrechercherprof.UseVisualStyleBackColor = false;
            this.btnrechercherprof.Click += new System.EventHandler(this.btnrechercherprof_Click);
            // 
            // btnmodifprof
            // 
            this.btnmodifprof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnmodifprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifprof.ForeColor = System.Drawing.Color.White;
            this.btnmodifprof.Location = new System.Drawing.Point(761, 193);
            this.btnmodifprof.Name = "btnmodifprof";
            this.btnmodifprof.Size = new System.Drawing.Size(188, 40);
            this.btnmodifprof.TabIndex = 32;
            this.btnmodifprof.Text = "Modifier";
            this.btnmodifprof.UseVisualStyleBackColor = false;
            this.btnmodifprof.Click += new System.EventHandler(this.btnmodifprof_Click);
            // 
            // rdbEnreg
            // 
            this.rdbEnreg.AutoSize = true;
            this.rdbEnreg.BackColor = System.Drawing.Color.Transparent;
            this.rdbEnreg.Checked = true;
            this.rdbEnreg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rdbEnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEnreg.Location = new System.Drawing.Point(37, 89);
            this.rdbEnreg.Name = "rdbEnreg";
            this.rdbEnreg.Size = new System.Drawing.Size(137, 24);
            this.rdbEnreg.TabIndex = 33;
            this.rdbEnreg.Text = "Enregistrement";
            this.rdbEnreg.UseVisualStyleBackColor = false;
            this.rdbEnreg.CheckedChanged += new System.EventHandler(this.rdbEnreg_CheckedChanged);
            // 
            // rdbseach
            // 
            this.rdbseach.AutoSize = true;
            this.rdbseach.BackColor = System.Drawing.Color.Transparent;
            this.rdbseach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbseach.Location = new System.Drawing.Point(188, 89);
            this.rdbseach.Name = "rdbseach";
            this.rdbseach.Size = new System.Drawing.Size(106, 24);
            this.rdbseach.TabIndex = 34;
            this.rdbseach.Text = "Recherche";
            this.rdbseach.UseVisualStyleBackColor = false;
            this.rdbseach.CheckedChanged += new System.EventHandler(this.rdbseach_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 75);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-2, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 67);
            this.panel2.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(747, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vous pouvez embaucher un professeur et faire un recherche puis apporter une modif" +
    "ication.\r\nVous n\'avez qu\'a cliquer sur le button dont vous voulez faire l\'action" +
    ".";
            // 
            // panSaisi
            // 
            this.panSaisi.Controls.Add(this.cbxprofession);
            this.panSaisi.Controls.Add(this.txtmodif);
            this.panSaisi.Controls.Add(this.jDtnaissance);
            this.panSaisi.Controls.Add(this.txtmatriculeprof);
            this.panSaisi.Controls.Add(this.txttelprof);
            this.panSaisi.Controls.Add(this.txtnomprof);
            this.panSaisi.Controls.Add(this.label3);
            this.panSaisi.Controls.Add(this.label4);
            this.panSaisi.Controls.Add(this.label7);
            this.panSaisi.Controls.Add(this.btnmodifprof);
            this.panSaisi.Controls.Add(this.label12);
            this.panSaisi.Controls.Add(this.txtemailprof);
            this.panSaisi.Controls.Add(this.cbxEtat);
            this.panSaisi.Controls.Add(this.btnenregprof);
            this.panSaisi.Controls.Add(this.cbxsexeprof);
            this.panSaisi.Controls.Add(this.txtnumref);
            this.panSaisi.Controls.Add(this.label11);
            this.panSaisi.Controls.Add(this.label10);
            this.panSaisi.Controls.Add(this.label5);
            this.panSaisi.Controls.Add(this.label9);
            this.panSaisi.Controls.Add(this.txtadresseprof);
            this.panSaisi.Controls.Add(this.txtprenomprof);
            this.panSaisi.Controls.Add(this.label13);
            this.panSaisi.Controls.Add(this.label6);
            this.panSaisi.Controls.Add(this.label8);
            this.panSaisi.Location = new System.Drawing.Point(15, 144);
            this.panSaisi.Name = "panSaisi";
            this.panSaisi.Size = new System.Drawing.Size(1003, 281);
            this.panSaisi.TabIndex = 37;
            // 
            // cbxprofession
            // 
            this.cbxprofession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxprofession.FormattingEnabled = true;
            this.cbxprofession.Items.AddRange(new object[] {
            "Medecin",
            "Ingenieur",
            "Mecanicien",
            "Agronome"});
            this.cbxprofession.Location = new System.Drawing.Point(376, 138);
            this.cbxprofession.Name = "cbxprofession";
            this.cbxprofession.Size = new System.Drawing.Size(157, 21);
            this.cbxprofession.TabIndex = 91;
            // 
            // txtmodif
            // 
            this.txtmodif.Location = new System.Drawing.Point(790, 239);
            this.txtmodif.Name = "txtmodif";
            this.txtmodif.Size = new System.Drawing.Size(100, 20);
            this.txtmodif.TabIndex = 90;
            this.txtmodif.Visible = false;
            // 
            // jDtnaissance
            // 
            this.jDtnaissance.CustomFormat = "yyyy/MM/dd";
            this.jDtnaissance.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.jDtnaissance.Location = new System.Drawing.Point(790, 45);
            this.jDtnaissance.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.jDtnaissance.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.jDtnaissance.Name = "jDtnaissance";
            this.jDtnaissance.Size = new System.Drawing.Size(139, 20);
            this.jDtnaissance.TabIndex = 89;
            this.jDtnaissance.Value = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            // 
            // txtmatriculeprof
            // 
            this.txtmatriculeprof.Location = new System.Drawing.Point(374, 88);
            this.txtmatriculeprof.Mask = "###-###-###-#";
            this.txtmatriculeprof.Name = "txtmatriculeprof";
            this.txtmatriculeprof.Size = new System.Drawing.Size(159, 20);
            this.txtmatriculeprof.TabIndex = 38;
            this.txtmatriculeprof.Validating += new System.ComponentModel.CancelEventHandler(this.txtmatriculeprof_Validating);
            // 
            // txttelprof
            // 
            this.txttelprof.Location = new System.Drawing.Point(102, 138);
            this.txttelprof.Mask = "(+\\5\\0\\9)####-####";
            this.txttelprof.Name = "txttelprof";
            this.txttelprof.Size = new System.Drawing.Size(159, 20);
            this.txttelprof.TabIndex = 37;
            this.txttelprof.Validating += new System.ComponentModel.CancelEventHandler(this.txttelprof_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 533);
            this.Controls.Add(this.panSaisi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbseach);
            this.Controls.Add(this.rdbEnreg);
            this.Controls.Add(this.btnrechercherprof);
            this.Controls.Add(this.txtcodeprof);
            this.Controls.Add(this.lblcodeprof);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panSaisi.ResumeLayout(false);
            this.panSaisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnenregprof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodeprof;
        private System.Windows.Forms.TextBox txtcodeprof;
        private System.Windows.Forms.TextBox txtnomprof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprenomprof;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtemailprof;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtadresseprof;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxsexeprof;
        private System.Windows.Forms.MaskedTextBox txtnumref;
        private System.Windows.Forms.ComboBox cbxEtat;
        private System.Windows.Forms.Button btnrechercherprof;
        private System.Windows.Forms.Button btnmodifprof;
        private System.Windows.Forms.CheckBox rdbEnreg;
        private System.Windows.Forms.CheckBox rdbseach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panSaisi;
        private System.Windows.Forms.MaskedTextBox txtmatriculeprof;
        private System.Windows.Forms.MaskedTextBox txttelprof;
        private System.Windows.Forms.DateTimePicker jDtnaissance;
        private System.Windows.Forms.TextBox txtmodif;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbxprofession;
    }
}

