using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

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
        string resumo1 { get; set; }
        public Program1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarHistorico();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxHistorico_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTemporizador_Click(object sender, EventArgs e)
        {
            if (textBoxTempoInicio.Text == "00:00")
            {
                DateTime horarioAtual1 = DateTime.Now;

                tempoInicio1 = horarioAtual1.ToString("HH:mm");

                textBoxTempoInicio.Text = tempoInicio1;
            }
            else if (textBoxTempoTermino.Text == "00:00")
            {
                DateTime horarioAtual2 = DateTime.Now;

                tempoFinal1 = horarioAtual2.ToString("HH:mm");

                textBoxTempoTermino.Text = tempoFinal1;

            }
        }
        private void AtualizarHistorico()
        {
            string ano = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.ToString("MM.yyyy");
            string dia = DateTime.Now.ToString("dd.MM.yyyy");

            string diretorioBase = @"C:\Users\Embras\Desktop\PinkCode\DestinoAtendimentos";
            string diretorioAno = Path.Combine(diretorioBase, ano);
            string diretorioMes = Path.Combine(diretorioAno, mes);
            string caminhoBlocoNotas = Path.Combine(diretorioMes, $"{dia}.txt");

            // Verifica se o arquivo existe antes de tentar lê-lo
            if (File.Exists(caminhoBlocoNotas))
            {
                // Lê o conteúdo do arquivo
                string conteudo = File.ReadAllText(caminhoBlocoNotas);

                // Inicializa uma lista para armazenar os atendimentos
                List<string> atendimentos = new List<string>();

                // Utiliza uma expressão regular para encontrar todos os atendimentos no conteúdo
                MatchCollection matches = Regex.Matches(conteudo, @"Nome:[^\n]*\nEntidade:[^\n]*\nConexão:[^\n]*\nHorario:[^\n]*\nModulo:[^\n]*\nE-mail:[^\n]*\nDescrição:[^\n]*\n\n------------------------------\s*------------------------------------------\s*\n\n");

                // Itera sobre as correspondências e adiciona à lista

                foreach (Match match in matches)
                {
                    // Extrai os valores dos campos específicos
                    string nome = ExtrairCampo(match.Value, "Nome:");
                    string entidade = ExtrairCampo(match.Value, "Entidade:");
                    string conexao = ExtrairCampo(match.Value, "Conexão:");
                    string horario = ExtrairCampo(match.Value, "Horario:");
                    string modulo = ExtrairCampo(match.Value, "Modulo:");
               
                    // Formato desejado para armazenar na lista
                    string formatoDesejado = $"{nome} - {modulo} {entidade} - {conexao} - {horario}";

                    // Adiciona o atendimento no novo formato à lista
                    atendimentos.Add(formatoDesejado);
                }

                // Exibe os atendimentos no campo de histórico
                richTextBoxHistorico.Text = string.Join("\n", atendimentos);
            }
            else
            {
                // Se o arquivo não existir, limpa o campo de histórico
                richTextBoxHistorico.Clear();
            }
        }
        private string ExtrairCampo(string texto, string campo)
        {
            // Expressão regular para encontrar o valor do campo
            string padrao = $@"{campo}\s*([^\n\r]*)";
            Match correspondencia = Regex.Match(texto, padrao);

            // Se houver uma correspondência, retorna o valor do campo
            if (correspondencia.Success)
            {
                return correspondencia.Groups[1].Value.Trim();
            }

            // Retorna uma string vazia se o campo não for encontrado
            return "";
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
            resumo1 = textBoxResumo.Text;
            string blocoTexto1 = ($"Nome: {nome1} - {resumo1}\nEntidade: {entidade1}-{sigla1}\nConexão: {conexao1}\nHorario:" +
                $" {tempoInicio1}" +
                $" ~ {tempoFinal1}\nModulo: {modulo1}\nE-mail: {email1}\nDescrição: {descricao1}\n\n------------------------------" +
                $"------------------------------------------\n\n");

            salvarAtendimento(blocoTexto1);

            AtualizarHistorico();
        }

        private void salvarAtendimento(string blocoTexto1)
        {
            string ano = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.ToString("MM.yyyy");
            string dia = DateTime.Now.ToString("dd.MM.yyyy");

            string diretorioBase = @"C:\Users\Embras\Desktop\PinkCode\DestinoAtendimentos";

            // Caminho para o diretório do ano
            string diretorioAno = Path.Combine(diretorioBase, ano);

            // Caminho para o diretório do mês
            string diretorioMes = Path.Combine(diretorioAno, mes);

            // Caminho para o arquivo de bloco de notas do dia
            string caminhoBlocoNotas = Path.Combine(diretorioMes, $"{dia}.txt");

            Directory.CreateDirectory(diretorioBase);
            Directory.CreateDirectory(diretorioAno);
            Directory.CreateDirectory(diretorioMes);

            // Escreve os dados do atendimento no arquivo de bloco de notas
            File.AppendAllText(caminhoBlocoNotas, blocoTexto1);

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
                textBoxTempoInicio.Text = "00:00";
                textBoxTempoTermino.Text = "00:00";
                AtualizarHistorico();
            }
        }
    }
}