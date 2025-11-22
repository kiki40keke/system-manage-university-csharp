namespace Uniclient
{
    partial class FenRecherUtilisateur
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
            this.label6 = new System.Windows.Forms.Label();
            this.jPFMotPasse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomUser = new System.Windows.Forms.TextBox();
            this.pansasie = new System.Windows.Forms.Panel();
            this.cmetat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.txtCodeRechercher = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pansasie.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mot De Passe";
            // 
            // jPFMotPasse
            // 
            this.jPFMotPasse.Location = new System.Drawing.Point(107, 239);
            this.jPFMotPasse.MaxLength = 10;
            this.jPFMotPasse.Name = "jPFMotPasse";
            this.jPFMotPasse.Size = new System.Drawing.Size(122, 20);
            this.jPFMotPasse.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nom Utilisateur:";
            // 
            // txtNomUser
            // 
            this.txtNomUser.Location = new System.Drawing.Point(108, 199);
            this.txtNomUser.MaxLength = 15;
            this.txtNomUser.Name = "txtNomUser";
            this.txtNomUser.Size = new System.Drawing.Size(122, 20);
            this.txtNomUser.TabIndex = 17;
            // 
            // pansasie
            // 
            this.pansasie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pansasie.Controls.Add(this.cmetat);
            this.pansasie.Controls.Add(this.label8);
            this.pansasie.Controls.Add(this.btnModifier);
            this.pansasie.Controls.Add(this.label5);
            this.pansasie.Controls.Add(this.label6);
            this.pansasie.Controls.Add(this.txtFonction);
            this.pansasie.Controls.Add(this.jPFMotPasse);
            this.pansasie.Controls.Add(this.label4);
            this.pansasie.Controls.Add(this.label7);
            this.pansasie.Controls.Add(this.txtNomUser);
            this.pansasie.Controls.Add(this.txtPrenom);
            this.pansasie.Controls.Add(this.label3);
            this.pansasie.Controls.Add(this.txtnom);
            this.pansasie.Controls.Add(this.label2);
            this.pansasie.Controls.Add(this.txtcode);
            this.pansasie.Location = new System.Drawing.Point(52, 160);
            this.pansasie.Name = "pansasie";
            this.pansasie.Size = new System.Drawing.Size(509, 281);
            this.pansasie.TabIndex = 15;
            this.pansasie.Visible = false;
            this.pansasie.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cmetat
            // 
            this.cmetat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmetat.FormattingEnabled = true;
            this.cmetat.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmetat.Location = new System.Drawing.Point(108, 99);
            this.cmetat.Name = "cmetat";
            this.cmetat.Size = new System.Drawing.Size(121, 21);
            this.cmetat.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Etat :";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(281, 199);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(194, 60);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fonction";
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(367, 62);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.ReadOnly = true;
            this.txtFonction.Size = new System.Drawing.Size(122, 20);
            this.txtFonction.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(108, 59);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(122, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(367, 20);
            this.txtnom.Name = "txtnom";
            this.txtnom.ReadOnly = true;
            this.txtnom.Size = new System.Drawing.Size(122, 20);
            this.txtnom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code Employe";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(108, 17);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(122, 20);
            this.txtcode.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnRechercher);
            this.panel1.Controls.Add(this.txtCodeRechercher);
            this.panel1.Location = new System.Drawing.Point(115, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 84);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Employe";
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercher.ForeColor = System.Drawing.Color.White;
            this.BtnRechercher.Location = new System.Drawing.Point(249, 19);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(125, 48);
            this.BtnRechercher.TabIndex = 2;
            this.BtnRechercher.Text = "Rechercher";
            this.BtnRechercher.UseVisualStyleBackColor = false;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // txtCodeRechercher
            // 
            this.txtCodeRechercher.Location = new System.Drawing.Point(102, 34);
            this.txtCodeRechercher.MaxLength = 25;
            this.txtCodeRechercher.Name = "txtCodeRechercher";
            this.txtCodeRechercher.Size = new System.Drawing.Size(136, 20);
            this.txtCodeRechercher.TabIndex = 1;
            this.txtCodeRechercher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeRechercher_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 50);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 51);
            this.panel4.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(11, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Rechercher";
            // 
            // FenRecherUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 514);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pansasie);
            this.Controls.Add(this.panel1);
            this.Name = "FenRecherUtilisateur";
            this.Text = "FenRecherUtilisateur";
            this.Load += new System.EventHandler(this.FenRecherUtilisateur_Load);
            this.pansasie.ResumeLayout(false);
            this.pansasie.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox jPFMotPasse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomUser;
        private System.Windows.Forms.Panel pansasie;
        private System.Windows.Forms.ComboBox cmetat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.TextBox txtCodeRechercher;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
    }
}