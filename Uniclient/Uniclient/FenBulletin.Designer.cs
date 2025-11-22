namespace Uniclient
{
    partial class FenBulletin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panrech = new System.Windows.Forms.Panel();
            this.btnbulletin = new System.Windows.Forms.Button();
            this.txtCodeEt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxsession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbloptions = new System.Windows.Forms.Label();
            this.lblvacation = new System.Windows.Forms.Label();
            this.lblpromo = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblmoy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panbulletin = new System.Windows.Forms.Panel();
            this.btnpdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panrech.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panbulletin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // panrech
            // 
            this.panrech.BackColor = System.Drawing.Color.Teal;
            this.panrech.Controls.Add(this.btnbulletin);
            this.panrech.Controls.Add(this.txtCodeEt);
            this.panrech.Controls.Add(this.label1);
            this.panrech.Controls.Add(this.cbxsession);
            this.panrech.Controls.Add(this.label3);
            this.panrech.Controls.Add(this.cbxniveau);
            this.panrech.Controls.Add(this.label2);
            this.panrech.Location = new System.Drawing.Point(34, 89);
            this.panrech.Name = "panrech";
            this.panrech.Size = new System.Drawing.Size(581, 141);
            this.panrech.TabIndex = 1;
            this.panrech.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnbulletin
            // 
            this.btnbulletin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnbulletin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbulletin.ForeColor = System.Drawing.Color.White;
            this.btnbulletin.Location = new System.Drawing.Point(332, 56);
            this.btnbulletin.Name = "btnbulletin";
            this.btnbulletin.Size = new System.Drawing.Size(140, 36);
            this.btnbulletin.TabIndex = 30;
            this.btnbulletin.Text = "Voir Bulletin";
            this.btnbulletin.UseVisualStyleBackColor = false;
            this.btnbulletin.Click += new System.EventHandler(this.btnbulletin_Click);
            // 
            // txtCodeEt
            // 
            this.txtCodeEt.Location = new System.Drawing.Point(118, 65);
            this.txtCodeEt.MaxLength = 25;
            this.txtCodeEt.Name = "txtCodeEt";
            this.txtCodeEt.Size = new System.Drawing.Size(140, 20);
            this.txtCodeEt.TabIndex = 29;
            this.txtCodeEt.TextChanged += new System.EventHandler(this.txtpromotion_TextChanged);
            this.txtCodeEt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeEt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Code Etudiant";
            // 
            // cbxsession
            // 
            this.cbxsession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsession.FormattingEnabled = true;
            this.cbxsession.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxsession.Location = new System.Drawing.Point(380, 10);
            this.cbxsession.Name = "cbxsession";
            this.cbxsession.Size = new System.Drawing.Size(140, 21);
            this.cbxsession.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Session";
            // 
            // cbxniveau
            // 
            this.cbxniveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxniveau.FormattingEnabled = true;
            this.cbxniveau.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxniveau.Location = new System.Drawing.Point(81, 15);
            this.cbxniveau.Name = "cbxniveau";
            this.cbxniveau.Size = new System.Drawing.Size(140, 21);
            this.cbxniveau.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Niveau";
            // 
            // lbloptions
            // 
            this.lbloptions.AutoSize = true;
            this.lbloptions.BackColor = System.Drawing.Color.Transparent;
            this.lbloptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloptions.ForeColor = System.Drawing.Color.Black;
            this.lbloptions.Location = new System.Drawing.Point(28, 74);
            this.lbloptions.Name = "lbloptions";
            this.lbloptions.Size = new System.Drawing.Size(55, 15);
            this.lbloptions.TabIndex = 2;
            this.lbloptions.Text = "Options :";
            this.lbloptions.Click += new System.EventHandler(this.lbloptions_Click);
            // 
            // lblvacation
            // 
            this.lblvacation.AutoSize = true;
            this.lblvacation.BackColor = System.Drawing.Color.Transparent;
            this.lblvacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvacation.ForeColor = System.Drawing.Color.Black;
            this.lblvacation.Location = new System.Drawing.Point(234, 74);
            this.lblvacation.Name = "lblvacation";
            this.lblvacation.Size = new System.Drawing.Size(60, 15);
            this.lblvacation.TabIndex = 3;
            this.lblvacation.Text = "Vacation :";
            this.lblvacation.Click += new System.EventHandler(this.lblvacation_Click);
            // 
            // lblpromo
            // 
            this.lblpromo.AutoSize = true;
            this.lblpromo.BackColor = System.Drawing.Color.Transparent;
            this.lblpromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromo.ForeColor = System.Drawing.Color.Black;
            this.lblpromo.Location = new System.Drawing.Point(480, 74);
            this.lblpromo.Name = "lblpromo";
            this.lblpromo.Size = new System.Drawing.Size(70, 15);
            this.lblpromo.TabIndex = 4;
            this.lblpromo.Text = "Promotion :";
            this.lblpromo.Click += new System.EventHandler(this.lblpromo_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(3, 403);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(31, 13);
            this.lbltotal.TabIndex = 7;
            this.lbltotal.Text = "Total";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.Transparent;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.Black;
            this.lblPrenom.Location = new System.Drawing.Point(234, 33);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 15);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prenom :";
            this.lblPrenom.Click += new System.EventHandler(this.lblPrenom_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(30, 33);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 15);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblmoy
            // 
            this.lblmoy.AutoSize = true;
            this.lblmoy.Location = new System.Drawing.Point(282, 403);
            this.lblmoy.Name = "lblmoy";
            this.lblmoy.Size = new System.Drawing.Size(57, 13);
            this.lblmoy.TabIndex = 8;
            this.lblmoy.Text = "Moyenne :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(241, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "BULLETIN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 88);
            this.panel2.TabIndex = 10;
            // 
            // panbulletin
            // 
            this.panbulletin.Controls.Add(this.btnpdf);
            this.panbulletin.Controls.Add(this.button1);
            this.panbulletin.Controls.Add(this.lblNom);
            this.panbulletin.Controls.Add(this.dataGridView1);
            this.panbulletin.Controls.Add(this.lbloptions);
            this.panbulletin.Controls.Add(this.lblmoy);
            this.panbulletin.Controls.Add(this.lblvacation);
            this.panbulletin.Controls.Add(this.button3);
            this.panbulletin.Controls.Add(this.lbltotal);
            this.panbulletin.Controls.Add(this.lblpromo);
            this.panbulletin.Controls.Add(this.lblPrenom);
            this.panbulletin.Location = new System.Drawing.Point(34, 247);
            this.panbulletin.Name = "panbulletin";
            this.panbulletin.Size = new System.Drawing.Size(626, 458);
            this.panbulletin.TabIndex = 11;
            this.panbulletin.Visible = false;
            // 
            // btnpdf
            // 
            this.btnpdf.Location = new System.Drawing.Point(6, 432);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(75, 23);
            this.btnpdf.TabIndex = 15;
            this.btnpdf.Text = "Sortir en pdf";
            this.btnpdf.UseVisualStyleBackColor = true;
            this.btnpdf.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Envoyer Par Email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(344, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "Effectuez une nouvelle rechercher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FenBulletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Uniclient.Properties.Resources._int;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(758, 714);
            this.Controls.Add(this.panrech);
            this.Controls.Add(this.panbulletin);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FenBulletin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FenBulletin";
            this.Load += new System.EventHandler(this.FenBulletin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panrech.ResumeLayout(false);
            this.panrech.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panbulletin.ResumeLayout(false);
            this.panbulletin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panrech;
        private System.Windows.Forms.TextBox txtCodeEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxniveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbulletin;
        private System.Windows.Forms.Label lbloptions;
        private System.Windows.Forms.Label lblvacation;
        private System.Windows.Forms.Label lblpromo;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblmoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panbulletin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnpdf;
    }
}