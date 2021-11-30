namespace OperazioniConFrazioni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tDen1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.tDen2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tNum3 = new System.Windows.Forms.TextBox();
            this.tDen3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lRisultato = new System.Windows.Forms.Label();
            this.bSomma = new System.Windows.Forms.Button();
            this.bProdotto = new System.Windows.Forms.Button();
            this.bDifferenza = new System.Windows.Forms.Button();
            this.bRapporto = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bOff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frazione 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tNum1
            // 
            this.tNum1.BackColor = System.Drawing.Color.Gainsboro;
            this.tNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum1.Location = new System.Drawing.Point(13, 13);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(90, 24);
            this.tNum1.TabIndex = 0;
            this.tNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNum1_KeyPress);
            // 
            // tDen1
            // 
            this.tDen1.BackColor = System.Drawing.Color.Gainsboro;
            this.tDen1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDen1.Location = new System.Drawing.Point(13, 68);
            this.tDen1.Name = "tDen1";
            this.tDen1.Size = new System.Drawing.Size(90, 24);
            this.tDen1.TabIndex = 1;
            this.tDen1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tDen1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNum1_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "______________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tNum1);
            this.panel1.Controls.Add(this.tDen1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tNum2);
            this.panel2.Controls.Add(this.tDen2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(149, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 100);
            this.panel2.TabIndex = 1;
            // 
            // tNum2
            // 
            this.tNum2.BackColor = System.Drawing.Color.Gainsboro;
            this.tNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum2.Location = new System.Drawing.Point(13, 13);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(90, 24);
            this.tNum2.TabIndex = 0;
            this.tNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNum1_KeyPress);
            // 
            // tDen2
            // 
            this.tDen2.BackColor = System.Drawing.Color.Gainsboro;
            this.tDen2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDen2.Location = new System.Drawing.Point(13, 68);
            this.tDen2.Name = "tDen2";
            this.tDen2.Size = new System.Drawing.Size(90, 24);
            this.tDen2.TabIndex = 1;
            this.tDen2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tDen2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNum1_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "______________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Frazione 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tNum3);
            this.panel3.Controls.Add(this.tDen3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(487, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 100);
            this.panel3.TabIndex = 12;
            // 
            // tNum3
            // 
            this.tNum3.AllowDrop = true;
            this.tNum3.BackColor = System.Drawing.Color.Gainsboro;
            this.tNum3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum3.ForeColor = System.Drawing.Color.Black;
            this.tNum3.Location = new System.Drawing.Point(13, 13);
            this.tNum3.Name = "tNum3";
            this.tNum3.ReadOnly = true;
            this.tNum3.Size = new System.Drawing.Size(90, 24);
            this.tNum3.TabIndex = 0;
            this.tNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tDen3
            // 
            this.tDen3.BackColor = System.Drawing.Color.Gainsboro;
            this.tDen3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDen3.ForeColor = System.Drawing.Color.Black;
            this.tDen3.Location = new System.Drawing.Point(-115, 25);
            this.tDen3.Name = "tDen3";
            this.tDen3.ReadOnly = true;
            this.tDen3.Size = new System.Drawing.Size(90, 24);
            this.tDen3.TabIndex = 1;
            this.tDen3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "____________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lRisultato
            // 
            this.lRisultato.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRisultato.ForeColor = System.Drawing.Color.Black;
            this.lRisultato.Location = new System.Drawing.Point(484, 277);
            this.lRisultato.Name = "lRisultato";
            this.lRisultato.Size = new System.Drawing.Size(113, 27);
            this.lRisultato.TabIndex = 0;
            this.lRisultato.Text = "Risultato";
            this.lRisultato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSomma
            // 
            this.bSomma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bSomma.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSomma.ForeColor = System.Drawing.Color.White;
            this.bSomma.Location = new System.Drawing.Point(305, 187);
            this.bSomma.Name = "bSomma";
            this.bSomma.Size = new System.Drawing.Size(41, 37);
            this.bSomma.TabIndex = 2;
            this.bSomma.Text = "+";
            this.bSomma.UseVisualStyleBackColor = false;
            this.bSomma.Click += new System.EventHandler(this.Operazione);
            // 
            // bProdotto
            // 
            this.bProdotto.AllowDrop = true;
            this.bProdotto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bProdotto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProdotto.ForeColor = System.Drawing.Color.White;
            this.bProdotto.Location = new System.Drawing.Point(352, 187);
            this.bProdotto.Name = "bProdotto";
            this.bProdotto.Size = new System.Drawing.Size(41, 37);
            this.bProdotto.TabIndex = 4;
            this.bProdotto.Text = "x";
            this.bProdotto.UseVisualStyleBackColor = false;
            this.bProdotto.Click += new System.EventHandler(this.Operazione);
            // 
            // bDifferenza
            // 
            this.bDifferenza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bDifferenza.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDifferenza.ForeColor = System.Drawing.Color.White;
            this.bDifferenza.Location = new System.Drawing.Point(305, 229);
            this.bDifferenza.Name = "bDifferenza";
            this.bDifferenza.Size = new System.Drawing.Size(41, 37);
            this.bDifferenza.TabIndex = 3;
            this.bDifferenza.Text = "-";
            this.bDifferenza.UseVisualStyleBackColor = false;
            this.bDifferenza.Click += new System.EventHandler(this.Operazione);
            // 
            // bRapporto
            // 
            this.bRapporto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bRapporto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRapporto.ForeColor = System.Drawing.Color.White;
            this.bRapporto.Location = new System.Drawing.Point(352, 229);
            this.bRapporto.Name = "bRapporto";
            this.bRapporto.Size = new System.Drawing.Size(41, 37);
            this.bRapporto.TabIndex = 5;
            this.bRapporto.Text = "/";
            this.bRapporto.UseVisualStyleBackColor = false;
            this.bRapporto.Click += new System.EventHandler(this.Operazione);
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.bReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.ForeColor = System.Drawing.Color.White;
            this.bReset.Location = new System.Drawing.Point(412, 187);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(51, 37);
            this.bReset.TabIndex = 6;
            this.bReset.Text = "C";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.Operazione);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(140, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Operazioni con le frazioni";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bOff
            // 
            this.bOff.BackColor = System.Drawing.Color.DarkRed;
            this.bOff.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOff.ForeColor = System.Drawing.Color.White;
            this.bOff.Location = new System.Drawing.Point(412, 229);
            this.bOff.Name = "bOff";
            this.bOff.Size = new System.Drawing.Size(51, 37);
            this.bOff.TabIndex = 6;
            this.bOff.Text = "OFF";
            this.bOff.UseVisualStyleBackColor = false;
            this.bOff.Click += new System.EventHandler(this.Operazione);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(460, 103);
            this.label6.TabIndex = 0;
            this.label6.Text = "Applicazione WinForm in Visual C# che fa uso di una  classe Frazioni con l\'overlo" +
    "ading degli operatori";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(610, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bRapporto);
            this.Controls.Add(this.bDifferenza);
            this.Controls.Add(this.bOff);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bProdotto);
            this.Controls.Add(this.bSomma);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lRisultato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Operazioni con le frazioni ITIS Rossi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tDen1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.TextBox tDen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tNum3;
        private System.Windows.Forms.TextBox tDen3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lRisultato;
        private System.Windows.Forms.Button bSomma;
        private System.Windows.Forms.Button bProdotto;
        private System.Windows.Forms.Button bDifferenza;
        private System.Windows.Forms.Button bRapporto;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}

