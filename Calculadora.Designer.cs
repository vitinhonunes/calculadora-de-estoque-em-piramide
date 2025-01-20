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
            this.MnS = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAlt = new System.Windows.Forms.TextBox();
            this.MnS.SuspendLayout();
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
            this.tbFrente.TabIndex = 1;
            this.tbFrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrente_KeyPress);
            // 
            // tbLateral
            // 
            this.tbLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLateral.Location = new System.Drawing.Point(158, 79);
            this.tbLateral.Name = "tbLateral";
            this.tbLateral.Size = new System.Drawing.Size(70, 26);
            this.tbLateral.TabIndex = 2;
            this.tbLateral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLateral_KeyPress);
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
            this.tbAvulso.TabIndex = 4;
            this.tbAvulso.Text = "0";
            this.tbAvulso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAvulso_KeyPress);
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
            this.tbRes.Size = new System.Drawing.Size(86, 26);
            this.tbRes.TabIndex = 5;
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
            this.btCalc.Location = new System.Drawing.Point(97, 314);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(163, 36);
            this.btCalc.TabIndex = 6;
            this.btCalc.Text = "Calcular";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // MnS
            // 
            this.MnS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.MnS.Location = new System.Drawing.Point(0, 0);
            this.MnS.Name = "MnS";
            this.MnS.Size = new System.Drawing.Size(338, 24);
            this.MnS.TabIndex = 16;
            this.MnS.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClose});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnClose
            // 
            this.mnClose.Name = "mnClose";
            this.mnClose.Size = new System.Drawing.Size(109, 22);
            this.mnClose.Text = "Fechar";
            this.mnClose.Click += new System.EventHandler(this.MnClose);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnVer});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // MnVer
            // 
            this.MnVer.Name = "MnVer";
            this.MnVer.Size = new System.Drawing.Size(108, 22);
            this.MnVer.Text = "Versão";
            this.MnVer.Click += new System.EventHandler(this.MnVers);
            // 
            // tbAlt
            // 
            this.tbAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlt.Location = new System.Drawing.Point(158, 125);
            this.tbAlt.Name = "tbAlt";
            this.tbAlt.Size = new System.Drawing.Size(70, 26);
            this.tbAlt.TabIndex = 3;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(338, 362);
            this.Controls.Add(this.tbAlt);
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
            this.Controls.Add(this.MnS);
            this.MainMenuStrip = this.MnS;
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.MnS.ResumeLayout(false);
            this.MnS.PerformLayout();
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
        private System.Windows.Forms.MenuStrip MnS;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnClose;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnVer;
        private System.Windows.Forms.TextBox tbAlt;
    }
}

