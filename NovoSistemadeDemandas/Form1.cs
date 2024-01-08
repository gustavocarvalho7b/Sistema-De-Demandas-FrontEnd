namespace NovoSistemadeDemandas
{
    public partial class Program1 : Form
    {
        string nome1 { get; set; }
        string entidade1 { get; set; }
        string conexao1 { get; set; }
        string modulo1 { get; set; }
        string tempoInicio1 { get; set; }
        string tempoFinal1 { get; set; }
        string email1 { get; set; }
        string descricao1 { get; set; }
        string sigla1 { get; set; }
        public Program1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxHistorico_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            nome1 = textBoxNome.Text;
            entidade1 = textBoxEntidade.Text;
            conexao1 = textBoxConexao.Text;
            tempoInicio1 = textBoxTempoInicio.Text;
            tempoFinal1 = textBoxTempoTermino.Text;
            email1 = textBoxEmail.Text;
            modulo1 = comboBoxModulo.Text;
            sigla1 = comboBoxSigla.Text;
            descricao1 = richTextBoxDescricao.Text;

            richTextBoxHistorico.Text = nome1 + ", " + entidade1 + ", " + conexao1 + ", " + tempoInicio1 + ", " + tempoFinal1 + ", " + email1 + ", " + modulo1;
        }

        private void buttonTemporizador_Click(object sender, EventArgs e)
        {
            if (tempoInicio1 is null)
            {
                DateTime horarioAtual1 = DateTime.Now;

                tempoInicio1 = horarioAtual1.ToString("HH:mm");

                textBoxTempoInicio.Text = tempoInicio1;
            }
            else if (tempoFinal1 is null)
            {
                DateTime horarioAtual2 = DateTime.Now;

                tempoFinal1 = horarioAtual2.ToString("HH:mm");

                textBoxTempoTermino.Text = tempoFinal1;

            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Verifica se o controle é um TextBox, ComboBox ou RichTextBox
                if (control is TextBox)
                {
                    // Limpa o conteúdo do TextBox
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    // Limpa a seleção do ComboBox
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is RichTextBox)
                {
                    // Limpa o conteúdo do RichTextBox
                    ((RichTextBox)control).Clear();
                }
            }
        }
    }
}