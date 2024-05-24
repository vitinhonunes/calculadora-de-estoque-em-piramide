namespace AppCalculo
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrente = new System.Windows.Forms.TextBox();
            this.tbLateral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAvulso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btCalc = new System.Windows.Forms.Button();
            this.cmAlt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frente:";
            // 
            // tbFrente
            // 
            this.tbFrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFrente.Location = new System.Drawing.Point(158, 34);
            this.tbFrente.Name = "tbFrente";
            this.tbFrente.Size = new System.Drawing.Size(70, 26);
            this.tbFrente.TabIndex = 5;
            // 
            // tbLateral
            // 
            this.tbLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLateral.Location = new System.Drawing.Point(158, 79);
            this.tbLateral.Name = "tbLateral";
            this.tbLateral.Size = new System.Drawing.Size(70, 26);
            this.tbLateral.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lateral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Altura:";
            // 
            // tbAvulso
            // 
            this.tbAvulso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAvulso.Location = new System.Drawing.Point(158, 174);
            this.tbAvulso.Name = "tbAvulso";
            this.tbAvulso.Size = new System.Drawing.Size(70, 26);
            this.tbAvulso.TabIndex = 11;
            this.tbAvulso.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Avulso:";
            // 
            // tbRes
            // 
            this.tbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRes.Location = new System.Drawing.Point(142, 255);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(173, 26);
            this.tbRes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado:";
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(65, 314);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(182, 36);
            this.btCalc.TabIndex = 14;
            this.btCalc.Text = "Calcular";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // cmAlt
            // 
            this.cmAlt.AllowDrop = true;
            this.cmAlt.CausesValidation = false;
            this.cmAlt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmAlt.FormattingEnabled = true;
            this.cmAlt.IntegralHeight = false;
            this.cmAlt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmAlt.Location = new System.Drawing.Point(158, 128);
            this.cmAlt.Name = "cmAlt";
            this.cmAlt.Size = new System.Drawing.Size(70, 28);
            this.cmAlt.TabIndex = 15;
            this.cmAlt.TabStop = false;
            this.cmAlt.Tag = "";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(338, 362);
            this.Controls.Add(this.cmAlt);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAvulso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLateral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFrente);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrente;
        private System.Windows.Forms.TextBox tbLateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAvulso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.ComboBox cmAlt;
    }
}

