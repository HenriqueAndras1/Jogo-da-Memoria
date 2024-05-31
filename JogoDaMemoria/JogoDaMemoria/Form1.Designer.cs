namespace JogoDaMemoria
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTempo = new Label();
            buttonReiniciar = new Button();
            labelMensagem = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScrollMargin = new Size(15, 15);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 407F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 0, 10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(473, 351);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // labelTempo
            // 
            labelTempo.BackColor = Color.Transparent;
            labelTempo.Dock = DockStyle.Top;
            labelTempo.FlatStyle = FlatStyle.Flat;
            labelTempo.Font = new Font("Arial", 16F);
            labelTempo.Location = new Point(0, 0);
            labelTempo.Margin = new Padding(2, 0, 2, 0);
            labelTempo.Name = "labelTempo";
            labelTempo.Size = new Size(473, 28);
            labelTempo.TabIndex = 1;
            labelTempo.Text = "Tempo: 60";
            labelTempo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonReiniciar
            // 
            buttonReiniciar.Dock = DockStyle.Bottom;
            buttonReiniciar.Font = new Font("Arial", 16F);
            buttonReiniciar.Location = new Point(0, 414);
            buttonReiniciar.Margin = new Padding(2);
            buttonReiniciar.Name = "buttonReiniciar";
            buttonReiniciar.Size = new Size(473, 35);
            buttonReiniciar.TabIndex = 2;
            buttonReiniciar.Text = "Reiniciar Jogo";
            buttonReiniciar.UseVisualStyleBackColor = true;
            buttonReiniciar.Click += buttonReiniciar_Click;
            // 
            // labelMensagem
            // 
            labelMensagem.BackColor = Color.Transparent;
            labelMensagem.Dock = DockStyle.Bottom;
            labelMensagem.FlatStyle = FlatStyle.Flat;
            labelMensagem.Font = new Font("Arial", 16F);
            labelMensagem.Location = new Point(0, 379);
            labelMensagem.Margin = new Padding(2, 0, 2, 0);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(473, 35);
            labelMensagem.TabIndex = 3;
            labelMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 600);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelMensagem);
            Controls.Add(buttonReiniciar);
            Controls.Add(labelTempo);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo da Memória";
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Label labelMensagem;
    }
}
