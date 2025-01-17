namespace CalculadoraBásica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botao1 = new Button();
            botao2 = new Button();
            botao3 = new Button();
            botao6 = new Button();
            botao5 = new Button();
            botao4 = new Button();
            botao9 = new Button();
            botao8 = new Button();
            botao7 = new Button();
            botaoMultiplicacao = new Button();
            botaoDivisao = new Button();
            botaoAdicao = new Button();
            botaoSubtracao = new Button();
            botao0 = new Button();
            resultadoCalculadora = new Label();
            botaoCE = new Button();
            botaoIgual = new Button();
            SuspendLayout();
            // 
            // botao1
            // 
            botao1.Font = new Font("Segoe UI", 20F);
            botao1.Location = new Point(24, 187);
            botao1.Name = "botao1";
            botao1.Size = new Size(94, 89);
            botao1.TabIndex = 0;
            botao1.Text = "1";
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += botao1_Click;
            // 
            // botao2
            // 
            botao2.Font = new Font("Segoe UI", 20F);
            botao2.Location = new Point(124, 187);
            botao2.Name = "botao2";
            botao2.Size = new Size(94, 89);
            botao2.TabIndex = 1;
            botao2.Text = "2";
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += botao2_Click;
            // 
            // botao3
            // 
            botao3.Font = new Font("Segoe UI", 20F);
            botao3.Location = new Point(224, 187);
            botao3.Name = "botao3";
            botao3.Size = new Size(94, 89);
            botao3.TabIndex = 2;
            botao3.Text = "3";
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += botao3_Click;
            // 
            // botao6
            // 
            botao6.Font = new Font("Segoe UI", 20F);
            botao6.Location = new Point(224, 282);
            botao6.Name = "botao6";
            botao6.Size = new Size(94, 89);
            botao6.TabIndex = 5;
            botao6.Text = "6";
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += botao6_Click;
            // 
            // botao5
            // 
            botao5.Font = new Font("Segoe UI", 20F);
            botao5.Location = new Point(124, 282);
            botao5.Name = "botao5";
            botao5.Size = new Size(94, 89);
            botao5.TabIndex = 4;
            botao5.Text = "5";
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += botao5_Click;
            // 
            // botao4
            // 
            botao4.Font = new Font("Segoe UI", 20F);
            botao4.Location = new Point(24, 282);
            botao4.Name = "botao4";
            botao4.Size = new Size(94, 89);
            botao4.TabIndex = 3;
            botao4.Text = "4";
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += botao4_Click;
            // 
            // botao9
            // 
            botao9.Font = new Font("Segoe UI", 20F);
            botao9.Location = new Point(224, 377);
            botao9.Name = "botao9";
            botao9.Size = new Size(94, 89);
            botao9.TabIndex = 8;
            botao9.Text = "9";
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += botao9_Click;
            // 
            // botao8
            // 
            botao8.Font = new Font("Segoe UI", 20F);
            botao8.Location = new Point(124, 377);
            botao8.Name = "botao8";
            botao8.Size = new Size(94, 89);
            botao8.TabIndex = 7;
            botao8.Text = "8";
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += botao8_Click;
            // 
            // botao7
            // 
            botao7.Font = new Font("Segoe UI", 20F);
            botao7.Location = new Point(24, 377);
            botao7.Name = "botao7";
            botao7.Size = new Size(94, 89);
            botao7.TabIndex = 6;
            botao7.Text = "7";
            botao7.UseVisualStyleBackColor = true;
            botao7.Click += botao7_Click;
            // 
            // botaoMultiplicacao
            // 
            botaoMultiplicacao.Font = new Font("Segoe UI", 20F);
            botaoMultiplicacao.Location = new Point(338, 472);
            botaoMultiplicacao.Name = "botaoMultiplicacao";
            botaoMultiplicacao.Size = new Size(94, 89);
            botaoMultiplicacao.TabIndex = 9;
            botaoMultiplicacao.Text = "*";
            botaoMultiplicacao.UseVisualStyleBackColor = true;
            botaoMultiplicacao.Click += botaoMultiplicacao_Click;
            // 
            // botaoDivisao
            // 
            botaoDivisao.Font = new Font("Segoe UI", 20F);
            botaoDivisao.Location = new Point(224, 472);
            botaoDivisao.Name = "botaoDivisao";
            botaoDivisao.Size = new Size(94, 89);
            botaoDivisao.TabIndex = 10;
            botaoDivisao.Text = "/";
            botaoDivisao.UseVisualStyleBackColor = true;
            botaoDivisao.Click += botaoDivisao_Click;
            // 
            // botaoAdicao
            // 
            botaoAdicao.Font = new Font("Segoe UI", 20F);
            botaoAdicao.Location = new Point(338, 282);
            botaoAdicao.Name = "botaoAdicao";
            botaoAdicao.Size = new Size(94, 89);
            botaoAdicao.TabIndex = 11;
            botaoAdicao.Text = "+";
            botaoAdicao.UseVisualStyleBackColor = true;
            botaoAdicao.Click += botaoAdicao_Click;
            // 
            // botaoSubtracao
            // 
            botaoSubtracao.Font = new Font("Segoe UI", 20F);
            botaoSubtracao.Location = new Point(338, 377);
            botaoSubtracao.Name = "botaoSubtracao";
            botaoSubtracao.Size = new Size(94, 89);
            botaoSubtracao.TabIndex = 12;
            botaoSubtracao.Text = "-";
            botaoSubtracao.UseVisualStyleBackColor = true;
            botaoSubtracao.Click += botaoSubtracao_Click;
            // 
            // botao0
            // 
            botao0.Font = new Font("Segoe UI", 20F);
            botao0.Location = new Point(24, 472);
            botao0.Name = "botao0";
            botao0.Size = new Size(94, 89);
            botao0.TabIndex = 13;
            botao0.Text = "0";
            botao0.UseVisualStyleBackColor = true;
            botao0.Click += botao0_Click;
            // 
            // resultadoCalculadora
            // 
            resultadoCalculadora.BorderStyle = BorderStyle.FixedSingle;
            resultadoCalculadora.Font = new Font("Segoe UI", 35F);
            resultadoCalculadora.ForeColor = SystemColors.ControlText;
            resultadoCalculadora.Location = new Point(24, 21);
            resultadoCalculadora.Name = "resultadoCalculadora";
            resultadoCalculadora.Size = new Size(408, 146);
            resultadoCalculadora.TabIndex = 14;
            resultadoCalculadora.Text = "--";
            resultadoCalculadora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botaoCE
            // 
            botaoCE.Font = new Font("Segoe UI", 20F);
            botaoCE.Location = new Point(124, 472);
            botaoCE.Name = "botaoCE";
            botaoCE.Size = new Size(94, 89);
            botaoCE.TabIndex = 15;
            botaoCE.Text = "CE";
            botaoCE.UseVisualStyleBackColor = true;
            botaoCE.Click += botaoCE_Click;
            // 
            // botaoIgual
            // 
            botaoIgual.Font = new Font("Segoe UI", 20F);
            botaoIgual.Location = new Point(338, 187);
            botaoIgual.Name = "botaoIgual";
            botaoIgual.Size = new Size(94, 89);
            botaoIgual.TabIndex = 16;
            botaoIgual.Text = "=";
            botaoIgual.UseVisualStyleBackColor = true;
            botaoIgual.Click += botaoIgual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 595);
            Controls.Add(botaoIgual);
            Controls.Add(botaoCE);
            Controls.Add(resultadoCalculadora);
            Controls.Add(botao0);
            Controls.Add(botaoSubtracao);
            Controls.Add(botaoAdicao);
            Controls.Add(botaoDivisao);
            Controls.Add(botaoMultiplicacao);
            Controls.Add(botao9);
            Controls.Add(botao8);
            Controls.Add(botao7);
            Controls.Add(botao6);
            Controls.Add(botao5);
            Controls.Add(botao4);
            Controls.Add(botao3);
            Controls.Add(botao2);
            Controls.Add(botao1);
            Name = "Form1";
            Text = "Calculadora Simples";
            ResumeLayout(false);
        }

        #endregion

        private Button botao1;
        private Button botao2;
        private Button botao3;
        private Button botao6;
        private Button botao5;
        private Button botao4;
        private Button botao9;
        private Button botao8;
        private Button botao7;
        private Button botaoMultiplicacao;
        private Button botaoDivisao;
        private Button botaoAdicao;
        private Button botaoSubtracao;
        private Button botao0;
        private Label resultadoCalculadora;
        private Button botaoCE;
        private Button botaoIgual;
    }
}
