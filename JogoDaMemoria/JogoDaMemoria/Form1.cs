using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JogoDaMemoria
{
    public partial class Form1 : Form
    {
        private const int tempoLimite = 60;
        private int tempoRestante;
        private List<Button> botoes;
        private List<string> imagens;
        private Button primeiroClique, segundoClique;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            botoes = new List<Button>();
            imagens = Directory.GetFiles("Imagens", "*.png").ToList();
            imagens.AddRange(imagens); // Duplicar as imagens para formar pares

            // Limpar os controles existentes no painel
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                var botao = tableLayoutPanel1.Controls[i] as Button;
                if (botao != null)
                {
                    botao.Dispose();
                }
            }

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            // Definir o layout do painel
            for (int i = 0; i < 16; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            }

            // Adicionar botões ao painel com tamanho fixo
            for (int i = 0; i < 16; i++)
            {
                var botao = new Button();
                botao.Size = new Size(100, 100); // Defina o tamanho desejado para os botões
                botao.Dock = DockStyle.Fill;
                botao.Font = new Font("Arial", 12, FontStyle.Bold);
                botao.Click += new EventHandler(Botao_Click);
                botao.Margin = new Padding(5);
                botoes.Add(botao);
                tableLayoutPanel1.Controls.Add(botao);
            }

            tempoRestante = tempoLimite;
            labelTempo.Text = $"Tempo: {tempoRestante}";
            labelMensagem.Text = string.Empty;
            buttonReiniciar.Enabled = false;

            AtribuirImagens();
            timer1.Start();
        }

        private void AtribuirImagens()
        {
            foreach (Button botao in botoes)
            {
                int indice = random.Next(imagens.Count);
                botao.Tag = imagens[indice];
                imagens.RemoveAt(indice);
                botao.BackgroundImage = null;
                botao.Text = string.Empty;
            }
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            if (primeiroClique != null && segundoClique != null)
                return;

            Button clicado = sender as Button;

            if (clicado == null || clicado.BackgroundImage != null)
                return;

            clicado.BackgroundImage = Image.FromFile(clicado.Tag.ToString());
            clicado.BackgroundImageLayout = ImageLayout.Stretch;

            if (primeiroClique == null)
            {
                primeiroClique = clicado;
                return;
            }

            segundoClique = clicado;

            if (primeiroClique.Tag.ToString() == segundoClique.Tag.ToString())
            {
                primeiroClique = null;
                segundoClique = null;
                VerificarFimDeJogo();
            }
            else
            {
                timer1.Stop();
                System.Windows.Forms.Timer temporizador = new System.Windows.Forms.Timer();
                temporizador.Interval = 500;
                temporizador.Tick += (s, ev) =>
                {
                    primeiroClique.BackgroundImage = null;
                    segundoClique.BackgroundImage = null;
                    primeiroClique = null;
                    segundoClique = null;
                    temporizador.Stop();
                    timer1.Start();
                };
                temporizador.Start();
            }
        }

        private void VerificarFimDeJogo()
        {
            foreach (Button botao in botoes)
            {
                if (botao.BackgroundImage == null)
                    return;
            }

            timer1.Stop();
            labelMensagem.Text = "Você Ganhou!";
            buttonReiniciar.Enabled = true;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            tempoRestante--;
            labelTempo.Text = $"Tempo: {tempoRestante}";

            if (tempoRestante <= 0)
            {
                timer1.Stop();
                labelMensagem.Text = "Acabou o Tempo!";
                foreach (Button botao in botoes)
                {
                    botao.BackgroundImage = Image.FromFile(botao.Tag.ToString());
                    botao.BackgroundImageLayout = ImageLayout.Stretch;
                }
                buttonReiniciar.Enabled = true;
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }
    }
}
