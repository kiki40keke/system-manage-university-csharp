namespace Uniclient
{
    partial class GestionCours
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtnomoption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnajcours = new System.Windows.Forms.Button();
            this.txtnomcours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sessionlbl = new System.Windows.Forms.Label();
            this.cbxsession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxoptioncours = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.txtnomoption);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 337);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 180);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(120, 58);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(190, 32);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter Option";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtnomoption
            // 
            this.txtnomoption.Location = new System.Drawing.Point(120, 32);
            this.txtnomoption.MaxLength = 40;
            this.txtnomoption.Name = "txtnomoption";
            this.txtnomoption.Size = new System.Drawing.Size(190, 20);
            this.txtnomoption.TabIndex = 1;
            this.txtnomoption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomoption_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Option";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.btnajcours);
            this.panel2.Controls.Add(this.txtnomcours);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Sessionlbl);
            this.panel2.Controls.Add(this.cbxsession);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxniveau);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxoptioncours);
            this.panel2.Location = new System.Drawing.Point(455, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 402);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(559, 235);
            this.dataGridView2.TabIndex = 10;
            // 
            // btnajcours
            // 
            this.btnajcours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnajcours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajcours.ForeColor = System.Drawing.Color.White;
            this.btnajcours.Location = new System.Drawing.Point(195, 99);
            this.btnajcours.Name = "btnajcours";
            this.btnajcours.Size = new System.Drawing.Size(166, 39);
            this.btnajcours.TabIndex = 9;
            this.btnajcours.Text = "Ajouter Cours";
            this.btnajcours.UseVisualStyleBackColor = false;
            this.btnajcours.Click += new System.EventHandler(this.btnajcours_Click);
            // 
            // txtnomcours
            // 
            this.txtnomcours.Location = new System.Drawing.Point(340, 63);
            this.txtnomcours.MaxLength = 40;
            this.txtnomcours.Name = "txtnomcours";
            this.txtnomcours.Size = new System.Drawing.Size(121, 20);
            this.txtnomcours.TabIndex = 8;
            this.txtnomcours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomcours_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cours";
            // 
            // Sessionlbl
            // 
            this.Sessionlbl.AutoSize = true;
            this.Sessionlbl.Location = new System.Drawing.Point(25, 63);
            this.Sessionlbl.Name = "Sessionlbl";
            this.Sessionlbl.Size = new System.Drawing.Size(44, 13);
            this.Sessionlbl.TabIndex = 5;
            this.Sessionlbl.Text = "Session";
            // 
            // cbxsession
            // 
            this.cbxsession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsession.FormattingEnabled = true;
            this.cbxsession.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxsession.Location = new System.Drawing.Point(105, 60);
            this.cbxsession.Name = "cbxsession";
            this.cbxsession.Size = new System.Drawing.Size(121, 21);
            this.cbxsession.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Niveau";
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
            this.cbxniveau.Location = new System.Drawing.Point(340, 14);
            this.cbxniveau.Name = "cbxniveau";
            this.cbxniveau.Size = new System.Drawing.Size(121, 21);
            this.cbxniveau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Options";
            // 
            // cbxoptioncours
            // 
            this.cbxoptioncours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxoptioncours.FormattingEnabled = true;
            this.cbxoptioncours.Location = new System.Drawing.Point(105, 14);
            this.cbxoptioncours.Name = "cbxoptioncours";
            this.cbxoptioncours.Size = new System.Drawing.Size(121, 21);
            this.cbxoptioncours.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 61);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(2, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 28);
            this.panel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(204, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 42);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gestion Cours";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Location = new System.Drawing.Point(0, 553);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1074, 49);
            this.panel5.TabIndex = 3;
            // 
            // GestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 603);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GestionCours";
            this.Text = "GestionCours";
            this.Load += new System.EventHandler(this.GestionCours_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtnomoption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxoptioncours;
        private System.Windows.Forms.Button btnajcours;
        private System.Windows.Forms.TextBox txtnomcours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Sessionlbl;
        private System.Windows.Forms.ComboBox cbxsession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxniveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
    }
}