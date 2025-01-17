namespace Gerenciador_de_tarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void inserirTarefaBotao_Click(object sender, EventArgs e)
        {
            string tarefa = boxTarefas.Text;
            listaTarefas.Items.Add(tarefa);
            boxTarefas.Clear();
        }

        private void removerBotao_Click(object sender, EventArgs e)
        {
            string tarefa = listaTarefas.Text.Trim();
            listaTarefas.Items.Remove(tarefa);
        }

        private void limparBotao_Click(object sender, EventArgs e)
        {
            listaTarefas.Items.Clear();
        }
    }
}
