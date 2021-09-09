using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho02.Controlller;

namespace Trabalho02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              

        private void Form1_Load(object sender, EventArgs e)
        {
            List<List<char>> PreencheTabuleiro =  TabuleiroController.Matriz();
            lblAD.Text = PreencheTabuleiro[0][0].ToString();
            lblEF.Text = PreencheTabuleiro[0][1].ToString();
            lblBC.Text = PreencheTabuleiro[0][2].ToString();
            lblGIU.Text = PreencheTabuleiro[1][0].ToString();
            lblHJV.Text = PreencheTabuleiro[1][1].ToString();
            lblKL.Text = PreencheTabuleiro[1][2].ToString();
            lblMOQ.Text = PreencheTabuleiro[2][0].ToString();
            lblNTP.Text = PreencheTabuleiro[2][1].ToString();
            lblRSZ.Text = PreencheTabuleiro[2][2].ToString();

            lblpontuacao.Text = "0";          
         
        }    

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OBRIGADO POR JOGAR!");
            Application.Exit();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            int pontuacao = TabuleiroController.ConferePalavra(txtpalavra.Text.ToString().ToUpper());           
            if (pontuacao == -1)
            {
                MessageBox.Show("ESSA PALAVRA JÁ FOI INSERIDA ANTERIORMENTE!");
            }
            else
            {
                MessageBox.Show("VOCÊ GANHOU " + pontuacao + " PONTO(S)");
                pontuacao += Convert.ToInt32(lblpontuacao.Text.ToString());
                lblpontuacao.Text = pontuacao.ToString();
                txtpalavra.Clear();

                lbpalavrasinseridas.Items.Clear();
                foreach (var item in TabuleiroController.Palavras())
                {
                    lbpalavrasinseridas.Items.Add(item);
                }
                lbpalavrasinseridas.Show();
            }

        }

        private void btngerarnovo_Click(object sender, EventArgs e)
        {
            List<List<char>> PreencheTabuleiro = TabuleiroController.BotaoNovo();
            lblAD.Text = PreencheTabuleiro[0][0].ToString();
            lblEF.Text = PreencheTabuleiro[0][1].ToString();
            lblBC.Text = PreencheTabuleiro[0][2].ToString();
            lblGIU.Text = PreencheTabuleiro[1][0].ToString();
            lblHJV.Text = PreencheTabuleiro[1][1].ToString();
            lblKL.Text = PreencheTabuleiro[1][2].ToString();
            lblMOQ.Text = PreencheTabuleiro[2][0].ToString();
            lblNTP.Text = PreencheTabuleiro[2][1].ToString();
            lblRSZ.Text = PreencheTabuleiro[2][2].ToString();
            lbpalavrasinseridas.Items.Clear();
        }
    }
}
