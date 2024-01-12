using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

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
        string caminhoPasta { get; set; }
        public static string caminho2 = "";
        public static string caminhoSetarBloco = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        public static string caminhoArquivo = Path.Combine(caminhoSetarBloco, "caminho_pasta.txt");

        public Program1()
        {
            InitializeComponent();
            SetarPasta();
            AtualizarHistorico();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SetarPasta()
        {
            try
            {
                caminhoSetarBloco = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                // Verificar se o diretório existe, se não, criar
                Directory.CreateDirectory(caminhoSetarBloco);
                // Criar o caminho completo do arquivo dentro da pasta "Documents"
                caminhoArquivo = Path.Combine(caminhoSetarBloco, "caminho_pasta.txt");
                caminho2 = File.ReadAllText(caminhoArquivo);
            }
            catch (UnauthorizedAccessException ex)
            {

                MessageBox.Show($"Erro de permissão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


            string diretorioAno = Path.Combine(caminho2, ano);
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
                    string formatoDesejado = $"{nome} - {modulo} - {entidade} - {conexao} - {horario}";

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

            AtualizarHistorico();
            salvarAtendimento(blocoTexto1);
            limparCampos();

        }

        private void salvarAtendimento(string blocoTexto1)
        {
            string ano = DateTime.Now.Year.ToString();
            string mes = DateTime.Now.ToString("MM.yyyy");
            string dia = DateTime.Now.ToString("dd.MM.yyyy");

            // Caminho para o diretório do ano
            string diretorioAno = Path.Combine(caminho2, ano);

            // Caminho para o diretório do mês
            string diretorioMes = Path.Combine(diretorioAno, mes);

            // Caminho para o arquivo de bloco de notas do dia
            string caminhoBlocoNotas = Path.Combine(diretorioMes, $"{dia}.txt");

            Directory.CreateDirectory(caminho2);
            Directory.CreateDirectory(diretorioAno);
            Directory.CreateDirectory(diretorioMes);

            // Escreve os dados do atendimento no arquivo de bloco de notas
            File.AppendAllText(caminhoBlocoNotas, blocoTexto1);
            AtualizarHistorico();

        }
        private void limparCampos()
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
                    comboBoxModulo.SelectedIndex = -1;
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

        private void buttonClean_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.relogio.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localizarPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"        A pasta destino dos arquivos de demandas é:\n{caminho2}");
        }

        private void setarPastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                // Configurar o diálogo
                dialog.Description = "Escolha um destino";
                dialog.ShowNewFolderButton = true;

                // Exibir o diálogo
                DialogResult resultado = dialog.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    // Obtém o caminho selecionado pelo usuário
                    string novoCaminho = dialog.SelectedPath;

                    // Chama a função para trocar o destino da pasta
                    TrocarPastaDestino(novoCaminho);
                }
            }
        }
        private void TrocarPastaDestino(string novoCaminho)
        {
            try
            {
                // Limpa o conteúdo do arquivo
                File.WriteAllText(caminhoArquivo, string.Empty);

                // Escreve o novo caminho no arquivo
                File.WriteAllText(caminhoArquivo, novoCaminho);

                // Atualiza a variável caminho2
                caminho2 = novoCaminho;

                // Atualiza o histórico
                AtualizarHistorico();

                MessageBox.Show("Pasta destino alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao trocar o destino da pasta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}