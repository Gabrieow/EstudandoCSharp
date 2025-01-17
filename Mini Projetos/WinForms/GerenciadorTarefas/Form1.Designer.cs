namespace Gerenciador_de_tarefas
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
            listaTarefas = new ListBox();
            boxTarefas = new TextBox();
            inserirTarefaBotao = new Button();
            label1 = new Label();
            removerBotao = new Button();
            limparBotao = new Button();
            SuspendLayout();
            // 
            // listaTarefas
            // 
            listaTarefas.FormattingEnabled = true;
            listaTarefas.ItemHeight = 15;
            listaTarefas.Location = new Point(271, 39);
            listaTarefas.Name = "listaTarefas";
            listaTarefas.Size = new Size(221, 154);
            listaTarefas.TabIndex = 0;
            // 
            // boxTarefas
            // 
            boxTarefas.Location = new Point(271, 270);
            boxTarefas.Name = "boxTarefas";
            boxTarefas.Size = new Size(221, 23);
            boxTarefas.TabIndex = 1;
            // 
            // inserirTarefaBotao
            // 
            inserirTarefaBotao.Location = new Point(498, 270);
            inserirTarefaBotao.Name = "inserirTarefaBotao";
            inserirTarefaBotao.Size = new Size(75, 23);
            inserirTarefaBotao.TabIndex = 2;
            inserirTarefaBotao.Text = "Inserir";
            inserirTarefaBotao.UseVisualStyleBackColor = true;
            inserirTarefaBotao.Click += inserirTarefaBotao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(109, 265);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 3;
            label1.Text = "Insira uma tarefa";
            // 
            // removerBotao
            // 
            removerBotao.Location = new Point(498, 39);
            removerBotao.Name = "removerBotao";
            removerBotao.Size = new Size(75, 23);
            removerBotao.TabIndex = 4;
            removerBotao.Text = "Remover";
            removerBotao.UseVisualStyleBackColor = true;
            removerBotao.Click += removerBotao_Click;
            // 
            // limparBotao
            // 
            limparBotao.Location = new Point(498, 170);
            limparBotao.Name = "limparBotao";
            limparBotao.Size = new Size(75, 23);
            limparBotao.TabIndex = 5;
            limparBotao.Text = "Limpar";
            limparBotao.UseVisualStyleBackColor = true;
            limparBotao.Click += limparBotao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(limparBotao);
            Controls.Add(removerBotao);
            Controls.Add(label1);
            Controls.Add(inserirTarefaBotao);
            Controls.Add(boxTarefas);
            Controls.Add(listaTarefas);
            Name = "Form1";
            Text = "Gerenciador de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaTarefas;
        private TextBox boxTarefas;
        private Button inserirTarefaBotao;
        private Label label1;
        private Button removerBotao;
        private Button limparBotao;
    }
}
