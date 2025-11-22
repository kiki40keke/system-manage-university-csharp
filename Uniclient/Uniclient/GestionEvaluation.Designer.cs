namespace Uniclient
{
    partial class GestionEvaluation
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
            this.spincoef = new System.Windows.Forms.NumericUpDown();
            this.txtcodeeval = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnenreg = new System.Windows.Forms.Button();
            this.cbxdescrip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodepalmares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spincoef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.spincoef);
            this.panel1.Controls.Add(this.txtcodeeval);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnenreg);
            this.panel1.Controls.Add(this.cbxdescrip);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbxtype);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtcodepalmares);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(689, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 188);
            this.panel1.TabIndex = 0;
            // 
            // spincoef
            // 
            this.spincoef.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spincoef.Location = new System.Drawing.Point(381, 82);
            this.spincoef.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spincoef.Name = "spincoef";
            this.spincoef.Size = new System.Drawing.Size(120, 20);
            this.spincoef.TabIndex = 3;
            this.spincoef.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtcodeeval
            // 
            this.txtcodeeval.Location = new System.Drawing.Point(381, 145);
            this.txtcodeeval.Name = "txtcodeeval";
            this.txtcodeeval.ReadOnly = true;
            this.txtcodeeval.Size = new System.Drawing.Size(121, 20);
            this.txtcodeeval.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(381, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "rechercher code";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnenreg
            // 
            this.btnenreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnenreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenreg.ForeColor = System.Drawing.Color.White;
            this.btnenreg.Location = new System.Drawing.Point(79, 116);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(151, 44);
            this.btnenreg.TabIndex = 8;
            this.btnenreg.Text = "Enregistrer Evaluation";
            this.btnenreg.UseVisualStyleBackColor = false;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // cbxdescrip
            // 
            this.cbxdescrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxdescrip.FormattingEnabled = true;
            this.cbxdescrip.Items.AddRange(new object[] {
            "Examen",
            "Devoir"});
            this.cbxdescrip.Location = new System.Drawing.Point(381, 31);
            this.cbxdescrip.Name = "cbxdescrip";
            this.cbxdescrip.Size = new System.Drawing.Size(121, 21);
            this.cbxdescrip.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // cbxtype
            // 
            this.cbxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtype.FormattingEnabled = true;
            this.cbxtype.Items.AddRange(new object[] {
            "Intra",
            "Final"});
            this.cbxtype.Location = new System.Drawing.Point(109, 74);
            this.cbxtype.Name = "cbxtype";
            this.cbxtype.Size = new System.Drawing.Size(121, 21);
            this.cbxtype.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type Evaluation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coefficient";
            // 
            // txtcodepalmares
            // 
            this.txtcodepalmares.Location = new System.Drawing.Point(109, 28);
            this.txtcodepalmares.MaxLength = 25;
            this.txtcodepalmares.Name = "txtcodepalmares";
            this.txtcodepalmares.Size = new System.Drawing.Size(121, 20);
            this.txtcodepalmares.TabIndex = 1;
            this.txtcodepalmares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodepalmares_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code palmares";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 39);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Evaluation";
            // 
            // GestionEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "GestionEvaluation";
            this.Text = "GestionEvaluation";
            this.Load += new System.EventHandler(this.GestionEvaluation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spincoef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.ComboBox cbxdescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodepalmares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodeeval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spincoef;
    }
}