namespace AHR12_WI_Mehrwertsteuer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBruttobetrag19 = new System.Windows.Forms.TextBox();
            this.txtMwStBetrag19 = new System.Windows.Forms.TextBox();
            this.txtNettobetrag = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArtikel = new System.Windows.Forms.TextBox();
            this.rtbAusgabe = new System.Windows.Forms.RichTextBox();
            this.txtBruttobetrag16 = new System.Windows.Forms.TextBox();
            this.txtMwStBetrag16 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AHR12_WI_Mehrwertsteuer.Properties.Resources.mwst_bild;
            this.pictureBox1.Location = new System.Drawing.Point(333, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mehrwertsteuer-Rechner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bruttobetrag in EUR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "MwSt-Betrag in EUR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nettobetrag in EUR:";
            // 
            // txtBruttobetrag19
            // 
            this.txtBruttobetrag19.Location = new System.Drawing.Point(133, 97);
            this.txtBruttobetrag19.Margin = new System.Windows.Forms.Padding(2);
            this.txtBruttobetrag19.Name = "txtBruttobetrag19";
            this.txtBruttobetrag19.Size = new System.Drawing.Size(68, 20);
            this.txtBruttobetrag19.TabIndex = 5;
            this.txtBruttobetrag19.Text = "0";
            // 
            // txtMwStBetrag19
            // 
            this.txtMwStBetrag19.Location = new System.Drawing.Point(133, 130);
            this.txtMwStBetrag19.Margin = new System.Windows.Forms.Padding(2);
            this.txtMwStBetrag19.Name = "txtMwStBetrag19";
            this.txtMwStBetrag19.Size = new System.Drawing.Size(68, 20);
            this.txtMwStBetrag19.TabIndex = 6;
            // 
            // txtNettobetrag
            // 
            this.txtNettobetrag.Location = new System.Drawing.Point(133, 162);
            this.txtNettobetrag.Margin = new System.Windows.Forms.Padding(2);
            this.txtNettobetrag.Name = "txtNettobetrag";
            this.txtNettobetrag.Size = new System.Drawing.Size(68, 20);
            this.txtNettobetrag.TabIndex = 7;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(17, 195);
            this.btnBerechnen.Margin = new System.Windows.Forms.Padding(2);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(183, 32);
            this.btnBerechnen.TabIndex = 8;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "19 % MwSt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Artikel:";
            // 
            // txtArtikel
            // 
            this.txtArtikel.Location = new System.Drawing.Point(132, 48);
            this.txtArtikel.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtikel.Name = "txtArtikel";
            this.txtArtikel.Size = new System.Drawing.Size(168, 20);
            this.txtArtikel.TabIndex = 11;
            // 
            // rtbAusgabe
            // 
            this.rtbAusgabe.Location = new System.Drawing.Point(208, 203);
            this.rtbAusgabe.Name = "rtbAusgabe";
            this.rtbAusgabe.Size = new System.Drawing.Size(285, 59);
            this.rtbAusgabe.TabIndex = 12;
            this.rtbAusgabe.Text = "";
            // 
            // txtBruttobetrag16
            // 
            this.txtBruttobetrag16.Location = new System.Drawing.Point(232, 96);
            this.txtBruttobetrag16.Margin = new System.Windows.Forms.Padding(2);
            this.txtBruttobetrag16.Name = "txtBruttobetrag16";
            this.txtBruttobetrag16.Size = new System.Drawing.Size(68, 20);
            this.txtBruttobetrag16.TabIndex = 13;
            this.txtBruttobetrag16.Text = "0";
            // 
            // txtMwStBetrag16
            // 
            this.txtMwStBetrag16.Location = new System.Drawing.Point(232, 130);
            this.txtMwStBetrag16.Margin = new System.Windows.Forms.Padding(2);
            this.txtMwStBetrag16.Name = "txtMwStBetrag16";
            this.txtMwStBetrag16.Size = new System.Drawing.Size(68, 20);
            this.txtMwStBetrag16.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "16% MwSt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 267);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMwStBetrag16);
            this.Controls.Add(this.txtBruttobetrag16);
            this.Controls.Add(this.rtbAusgabe);
            this.Controls.Add(this.txtArtikel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtNettobetrag);
            this.Controls.Add(this.txtMwStBetrag19);
            this.Controls.Add(this.txtBruttobetrag19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MwSt-Rechner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBruttobetrag19;
        private System.Windows.Forms.TextBox txtMwStBetrag19;
        private System.Windows.Forms.TextBox txtNettobetrag;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArtikel;
        private System.Windows.Forms.RichTextBox rtbAusgabe;
        private System.Windows.Forms.TextBox txtBruttobetrag16;
        private System.Windows.Forms.TextBox txtMwStBetrag16;
        private System.Windows.Forms.Label label7;
    }
}

