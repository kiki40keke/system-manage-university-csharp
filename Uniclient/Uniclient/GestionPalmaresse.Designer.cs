namespace Uniclient
{
    partial class GestionPalmaresse
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcodpal = new System.Windows.Forms.TextBox();
            this.btnrecher = new System.Windows.Forms.Button();
            this.btnenregpalmares = new System.Windows.Forms.Button();
            this.txtpromotion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxvacation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxcours = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxsession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxoptioncours = new System.Windows.Forms.ComboBox();
            this.Option = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txtcodpal);
            this.panel1.Controls.Add(this.btnrecher);
            this.panel1.Controls.Add(this.btnenregpalmares);
            this.panel1.Controls.Add(this.txtpromotion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxvacation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxcours);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxsession);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxniveau);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxoptioncours);
            this.panel1.Controls.Add(this.Option);
            this.panel1.Location = new System.Drawing.Point(51, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 343);
            this.panel1.TabIndex = 0;
            // 
            // txtcodpal
            // 
            this.txtcodpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodpal.Location = new System.Drawing.Point(343, 276);
            this.txtcodpal.Name = "txtcodpal";
            this.txtcodpal.ReadOnly = true;
            this.txtcodpal.Size = new System.Drawing.Size(239, 38);
            this.txtcodpal.TabIndex = 24;
            // 
            // btnrecher
            // 
            this.btnrecher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrecher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecher.ForeColor = System.Drawing.Color.White;
            this.btnrecher.Location = new System.Drawing.Point(37, 276);
            this.btnrecher.Name = "btnrecher";
            this.btnrecher.Size = new System.Drawing.Size(292, 42);
            this.btnrecher.TabIndex = 23;
            this.btnrecher.Text = "Trouver le code du palmares";
            this.btnrecher.UseVisualStyleBackColor = false;
            this.btnrecher.Click += new System.EventHandler(this.btnrecher_Click);
            // 
            // btnenregpalmares
            // 
            this.btnenregpalmares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnenregpalmares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregpalmares.ForeColor = System.Drawing.Color.White;
            this.btnenregpalmares.Location = new System.Drawing.Point(390, 172);
            this.btnenregpalmares.Name = "btnenregpalmares";
            this.btnenregpalmares.Size = new System.Drawing.Size(192, 48);
            this.btnenregpalmares.TabIndex = 22;
            this.btnenregpalmares.Text = "Enregistrer une Palmares";
            this.btnenregpalmares.UseVisualStyleBackColor = false;
            this.btnenregpalmares.Click += new System.EventHandler(this.btnenregpalmares_Click);
            // 
            // txtpromotion
            // 
            this.txtpromotion.Location = new System.Drawing.Point(429, 119);
            this.txtpromotion.MaxLength = 4;
            this.txtpromotion.Name = "txtpromotion";
            this.txtpromotion.Size = new System.Drawing.Size(140, 20);
            this.txtpromotion.TabIndex = 21;
            this.txtpromotion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpromotion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Anne Promotion";
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
            this.cbxvacation.Location = new System.Drawing.Point(429, 78);
            this.cbxvacation.Name = "cbxvacation";
            this.cbxvacation.Size = new System.Drawing.Size(147, 21);
            this.cbxvacation.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vacation";
            // 
            // cbxcours
            // 
            this.cbxcours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcours.FormattingEnabled = true;
            this.cbxcours.Location = new System.Drawing.Point(429, 35);
            this.cbxcours.Name = "cbxcours";
            this.cbxcours.Size = new System.Drawing.Size(147, 21);
            this.cbxcours.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cours";
            // 
            // cbxsession
            // 
            this.cbxsession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsession.FormattingEnabled = true;
            this.cbxsession.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxsession.Location = new System.Drawing.Point(137, 120);
            this.cbxsession.Name = "cbxsession";
            this.cbxsession.Size = new System.Drawing.Size(147, 21);
            this.cbxsession.TabIndex = 15;
            this.cbxsession.SelectedIndexChanged += new System.EventHandler(this.cbxsession_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 14;
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
            this.cbxniveau.Location = new System.Drawing.Point(137, 78);
            this.cbxniveau.Name = "cbxniveau";
            this.cbxniveau.Size = new System.Drawing.Size(147, 21);
            this.cbxniveau.TabIndex = 13;
            this.cbxniveau.SelectedIndexChanged += new System.EventHandler(this.cbxniveau_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Niveau";
            // 
            // cbxoptioncours
            // 
            this.cbxoptioncours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxoptioncours.FormattingEnabled = true;
            this.cbxoptioncours.Location = new System.Drawing.Point(137, 47);
            this.cbxoptioncours.Name = "cbxoptioncours";
            this.cbxoptioncours.Size = new System.Drawing.Size(147, 21);
            this.cbxoptioncours.TabIndex = 11;
            this.cbxoptioncours.SelectedIndexChanged += new System.EventHandler(this.cbxoptioncours_SelectedIndexChanged);
            // 
            // Option
            // 
            this.Option.AutoSize = true;
            this.Option.Location = new System.Drawing.Point(72, 43);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(38, 13);
            this.Option.TabIndex = 10;
            this.Option.Text = "Option";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 62);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(480, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 62);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gestion Palmares";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(-1, 503);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(837, 48);
            this.panel4.TabIndex = 2;
            // 
            // GestionPalmaresse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GestionPalmaresse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GestionPalmaresse";
            this.Load += new System.EventHandler(this.GestionPalmaresse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxvacation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxcours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxniveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxoptioncours;
        private System.Windows.Forms.Label Option;
        private System.Windows.Forms.TextBox txtcodpal;
        private System.Windows.Forms.Button btnrecher;
        private System.Windows.Forms.Button btnenregpalmares;
        private System.Windows.Forms.TextBox txtpromotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
    }
}