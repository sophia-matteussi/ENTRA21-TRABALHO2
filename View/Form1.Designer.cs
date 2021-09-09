
namespace Trabalho02
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcaçapalavras = new System.Windows.Forms.Label();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.lblinserirpalavra = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.btngerarnovo = new System.Windows.Forms.Button();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.lblpontuacaodojogador = new System.Windows.Forms.Label();
            this.lblpontuacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAD = new System.Windows.Forms.Label();
            this.lblEF = new System.Windows.Forms.Label();
            this.lblBC = new System.Windows.Forms.Label();
            this.lblGIU = new System.Windows.Forms.Label();
            this.lblHJV = new System.Windows.Forms.Label();
            this.lblKL = new System.Windows.Forms.Label();
            this.lblMOQ = new System.Windows.Forms.Label();
            this.lblNTP = new System.Windows.Forms.Label();
            this.lblRSZ = new System.Windows.Forms.Label();
            this.lbpalavrasinseridas = new System.Windows.Forms.ListBox();
            this.lbllistadepalavrasinseridas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcaçapalavras
            // 
            this.lblcaçapalavras.AutoSize = true;
            this.lblcaçapalavras.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaçapalavras.Location = new System.Drawing.Point(259, 11);
            this.lblcaçapalavras.Name = "lblcaçapalavras";
            this.lblcaçapalavras.Size = new System.Drawing.Size(256, 45);
            this.lblcaçapalavras.TabIndex = 9;
            this.lblcaçapalavras.Text = "CAÇA-PALAVRAS";
            // 
            // txtpalavra
            // 
            this.txtpalavra.Location = new System.Drawing.Point(258, 406);
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(249, 38);
            this.txtpalavra.TabIndex = 10;
            // 
            // lblinserirpalavra
            // 
            this.lblinserirpalavra.AutoSize = true;
            this.lblinserirpalavra.Location = new System.Drawing.Point(252, 372);
            this.lblinserirpalavra.Name = "lblinserirpalavra";
            this.lblinserirpalavra.Size = new System.Drawing.Size(263, 31);
            this.lblinserirpalavra.TabIndex = 11;
            this.lblinserirpalavra.Text = "INSIRA A PALAVRA";
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(296, 450);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(168, 43);
            this.btninserir.TabIndex = 12;
            this.btninserir.Text = "INSERIR";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btngerarnovo
            // 
            this.btngerarnovo.Location = new System.Drawing.Point(296, 314);
            this.btngerarnovo.Name = "btngerarnovo";
            this.btngerarnovo.Size = new System.Drawing.Size(168, 43);
            this.btngerarnovo.TabIndex = 13;
            this.btngerarnovo.Text = "NOVO";
            this.btngerarnovo.UseVisualStyleBackColor = true;
            this.btngerarnovo.Click += new System.EventHandler(this.btngerarnovo_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(586, 504);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(186, 45);
            this.btnencerrar.TabIndex = 14;
            this.btnencerrar.Text = "ENCERRAR";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // lblpontuacaodojogador
            // 
            this.lblpontuacaodojogador.AutoSize = true;
            this.lblpontuacaodojogador.Location = new System.Drawing.Point(12, 511);
            this.lblpontuacaodojogador.Name = "lblpontuacaodojogador";
            this.lblpontuacaodojogador.Size = new System.Drawing.Size(385, 31);
            this.lblpontuacaodojogador.TabIndex = 15;
            this.lblpontuacaodojogador.Text = "PONTUAÇÃO DO JOGADOR:";
            // 
            // lblpontuacao
            // 
            this.lblpontuacao.AutoSize = true;
            this.lblpontuacao.Location = new System.Drawing.Point(403, 511);
            this.lblpontuacao.Name = "lblpontuacao";
            this.lblpontuacao.Size = new System.Drawing.Size(141, 31);
            this.lblpontuacao.TabIndex = 16;
            this.lblpontuacao.Text = "pontuacao";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblAD
            // 
            this.lblAD.AutoSize = true;
            this.lblAD.Location = new System.Drawing.Point(290, 93);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(32, 31);
            this.lblAD.TabIndex = 18;
            this.lblAD.Text = "X";
            // 
            // lblEF
            // 
            this.lblEF.AutoSize = true;
            this.lblEF.Location = new System.Drawing.Point(365, 93);
            this.lblEF.Name = "lblEF";
            this.lblEF.Size = new System.Drawing.Size(32, 31);
            this.lblEF.TabIndex = 19;
            this.lblEF.Text = "X";
            // 
            // lblBC
            // 
            this.lblBC.AutoSize = true;
            this.lblBC.Location = new System.Drawing.Point(441, 93);
            this.lblBC.Name = "lblBC";
            this.lblBC.Size = new System.Drawing.Size(32, 31);
            this.lblBC.TabIndex = 20;
            this.lblBC.Text = "X";
            // 
            // lblGIU
            // 
            this.lblGIU.AutoSize = true;
            this.lblGIU.Location = new System.Drawing.Point(290, 173);
            this.lblGIU.Name = "lblGIU";
            this.lblGIU.Size = new System.Drawing.Size(32, 31);
            this.lblGIU.TabIndex = 21;
            this.lblGIU.Text = "X";
            // 
            // lblHJV
            // 
            this.lblHJV.AutoSize = true;
            this.lblHJV.Location = new System.Drawing.Point(365, 173);
            this.lblHJV.Name = "lblHJV";
            this.lblHJV.Size = new System.Drawing.Size(32, 31);
            this.lblHJV.TabIndex = 22;
            this.lblHJV.Text = "X";
            // 
            // lblKL
            // 
            this.lblKL.AutoSize = true;
            this.lblKL.Location = new System.Drawing.Point(441, 173);
            this.lblKL.Name = "lblKL";
            this.lblKL.Size = new System.Drawing.Size(32, 31);
            this.lblKL.TabIndex = 23;
            this.lblKL.Text = "X";
            // 
            // lblMOQ
            // 
            this.lblMOQ.AutoSize = true;
            this.lblMOQ.Location = new System.Drawing.Point(290, 248);
            this.lblMOQ.Name = "lblMOQ";
            this.lblMOQ.Size = new System.Drawing.Size(32, 31);
            this.lblMOQ.TabIndex = 24;
            this.lblMOQ.Text = "X";
            // 
            // lblNTP
            // 
            this.lblNTP.AutoSize = true;
            this.lblNTP.Location = new System.Drawing.Point(365, 248);
            this.lblNTP.Name = "lblNTP";
            this.lblNTP.Size = new System.Drawing.Size(32, 31);
            this.lblNTP.TabIndex = 25;
            this.lblNTP.Text = "X";
            // 
            // lblRSZ
            // 
            this.lblRSZ.AutoSize = true;
            this.lblRSZ.Location = new System.Drawing.Point(441, 248);
            this.lblRSZ.Name = "lblRSZ";
            this.lblRSZ.Size = new System.Drawing.Size(32, 31);
            this.lblRSZ.TabIndex = 26;
            this.lblRSZ.Text = "X";
            // 
            // lbpalavrasinseridas
            // 
            this.lbpalavrasinseridas.FormattingEnabled = true;
            this.lbpalavrasinseridas.ItemHeight = 31;
            this.lbpalavrasinseridas.Location = new System.Drawing.Point(18, 56);
            this.lbpalavrasinseridas.Name = "lbpalavrasinseridas";
            this.lbpalavrasinseridas.Size = new System.Drawing.Size(212, 252);
            this.lbpalavrasinseridas.TabIndex = 27;
            // 
            // lbllistadepalavrasinseridas
            // 
            this.lbllistadepalavrasinseridas.AutoSize = true;
            this.lbllistadepalavrasinseridas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistadepalavrasinseridas.Location = new System.Drawing.Point(14, 311);
            this.lbllistadepalavrasinseridas.Name = "lbllistadepalavrasinseridas";
            this.lbllistadepalavrasinseridas.Size = new System.Drawing.Size(212, 24);
            this.lbllistadepalavrasinseridas.TabIndex = 28;
            this.lbllistadepalavrasinseridas.Text = "PALAVRAS INSERIDAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lbllistadepalavrasinseridas);
            this.Controls.Add(this.lbpalavrasinseridas);
            this.Controls.Add(this.lblRSZ);
            this.Controls.Add(this.lblNTP);
            this.Controls.Add(this.lblMOQ);
            this.Controls.Add(this.lblKL);
            this.Controls.Add(this.lblHJV);
            this.Controls.Add(this.lblGIU);
            this.Controls.Add(this.lblBC);
            this.Controls.Add(this.lblEF);
            this.Controls.Add(this.lblAD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpontuacao);
            this.Controls.Add(this.lblpontuacaodojogador);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.btngerarnovo);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.lblinserirpalavra);
            this.Controls.Add(this.txtpalavra);
            this.Controls.Add(this.lblcaçapalavras);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcaçapalavras;
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.Label lblinserirpalavra;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btngerarnovo;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.Label lblpontuacaodojogador;
        private System.Windows.Forms.Label lblpontuacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAD;
        private System.Windows.Forms.Label lblEF;
        private System.Windows.Forms.Label lblBC;
        private System.Windows.Forms.Label lblGIU;
        private System.Windows.Forms.Label lblHJV;
        private System.Windows.Forms.Label lblKL;
        private System.Windows.Forms.Label lblMOQ;
        private System.Windows.Forms.Label lblNTP;
        private System.Windows.Forms.Label lblRSZ;
        private System.Windows.Forms.ListBox lbpalavrasinseridas;
        private System.Windows.Forms.Label lbllistadepalavrasinseridas;
    }
}

