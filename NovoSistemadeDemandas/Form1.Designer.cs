namespace NovoSistemadeDemandas
{
    partial class Program1
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
            textBoxNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEntidade = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxConexao = new TextBox();
            textBoxEmail = new TextBox();
            label6 = new Label();
            comboBoxModulo = new ComboBox();
            comboBoxSigla = new ComboBox();
            textBoxResumo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxTempoInicio = new TextBox();
            label10 = new Label();
            textBoxTempoTermino = new TextBox();
            buttonTemporizador = new Button();
            richTextBoxDescricao = new RichTextBox();
            label11 = new Label();
            buttonSave = new Button();
            buttonClean = new Button();
            label12 = new Label();
            richTextBoxHistorico = new RichTextBox();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Font = new Font("Segoe UI", 12F);
            textBoxNome.Location = new Point(91, 82);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(279, 29);
            textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(373, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Demandas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(400, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 3;
            label3.Text = "Entidade:";
            // 
            // textBoxEntidade
            // 
            textBoxEntidade.Font = new Font("Segoe UI", 12F);
            textBoxEntidade.Location = new Point(479, 82);
            textBoxEntidade.Name = "textBoxEntidade";
            textBoxEntidade.Size = new Size(279, 29);
            textBoxEntidade.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(801, 85);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 5;
            label4.Text = "Sigla:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 136);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 6;
            label5.Text = "Conexão:";
            // 
            // textBoxConexao
            // 
            textBoxConexao.Font = new Font("Segoe UI", 12F);
            textBoxConexao.Location = new Point(91, 133);
            textBoxConexao.Name = "textBoxConexao";
            textBoxConexao.Size = new Size(279, 29);
            textBoxConexao.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(615, 184);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 29);
            textBoxEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(406, 136);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 9;
            label6.Text = "Módulo:";
            // 
            // comboBoxModulo
            // 
            comboBoxModulo.Font = new Font("Segoe UI", 12F);
            comboBoxModulo.FormattingEnabled = true;
            comboBoxModulo.Items.AddRange(new object[] { "SUPWEB", "SUPDESK", "GPAW" });
            comboBoxModulo.Location = new Point(479, 133);
            comboBoxModulo.Name = "comboBoxModulo";
            comboBoxModulo.Size = new Size(93, 29);
            comboBoxModulo.TabIndex = 10;
            // 
            // comboBoxSigla
            // 
            comboBoxSigla.Font = new Font("Segoe UI", 12F);
            comboBoxSigla.FormattingEnabled = true;
            comboBoxSigla.Items.AddRange(new object[] { "PM", "CM", "IP", "SAU", "ETC" });
            comboBoxSigla.Location = new Point(854, 82);
            comboBoxSigla.Name = "comboBoxSigla";
            comboBoxSigla.Size = new Size(74, 29);
            comboBoxSigla.TabIndex = 11;
            // 
            // textBoxResumo
            // 
            textBoxResumo.Font = new Font("Segoe UI", 12F);
            textBoxResumo.Location = new Point(91, 184);
            textBoxResumo.Name = "textBoxResumo";
            textBoxResumo.Size = new Size(424, 29);
            textBoxResumo.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(15, 187);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 13;
            label7.Text = "Resumo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(552, 187);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 14;
            label8.Text = "E-mail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(600, 136);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 15;
            label9.Text = "Tempo:";
            // 
            // textBoxTempoInicio
            // 
            textBoxTempoInicio.Font = new Font("Segoe UI", 12F);
            textBoxTempoInicio.Location = new Point(665, 133);
            textBoxTempoInicio.Name = "textBoxTempoInicio";
            textBoxTempoInicio.Size = new Size(50, 29);
            textBoxTempoInicio.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(721, 136);
            label10.Name = "label10";
            label10.Size = new Size(21, 21);
            label10.TabIndex = 17;
            label10.Text = "~";
            // 
            // textBoxTempoTermino
            // 
            textBoxTempoTermino.Font = new Font("Segoe UI", 12F);
            textBoxTempoTermino.Location = new Point(748, 133);
            textBoxTempoTermino.Name = "textBoxTempoTermino";
            textBoxTempoTermino.Size = new Size(50, 29);
            textBoxTempoTermino.TabIndex = 18;
            // 
            // buttonTemporizador
            // 
            buttonTemporizador.BackColor = SystemColors.ActiveCaption;
            buttonTemporizador.Location = new Point(804, 117);
            buttonTemporizador.Name = "buttonTemporizador";
            buttonTemporizador.Size = new Size(124, 61);
            buttonTemporizador.TabIndex = 19;
            buttonTemporizador.Text = "Temporizador";
            buttonTemporizador.UseVisualStyleBackColor = false;
            // 
            // richTextBoxDescricao
            // 
            richTextBoxDescricao.Location = new Point(91, 234);
            richTextBoxDescricao.Name = "richTextBoxDescricao";
            richTextBoxDescricao.Size = new Size(523, 128);
            richTextBoxDescricao.TabIndex = 20;
            richTextBoxDescricao.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(5, 234);
            label11.Name = "label11";
            label11.Size = new Size(80, 21);
            label11.TabIndex = 21;
            label11.Text = "Descrição:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ActiveCaption;
            buttonSave.Location = new Point(634, 234);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(294, 61);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonClean
            // 
            buttonClean.BackColor = SystemColors.ActiveCaption;
            buttonClean.Location = new Point(634, 301);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(294, 61);
            buttonClean.TabIndex = 23;
            buttonClean.Text = "Limpar Tela";
            buttonClean.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 18F);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(306, 388);
            label12.Name = "label12";
            label12.Size = new Size(363, 32);
            label12.TabIndex = 24;
            label12.Text = "Historico de atendimentos diario";
            // 
            // richTextBoxHistorico
            // 
            richTextBoxHistorico.Location = new Point(91, 440);
            richTextBoxHistorico.Name = "richTextBoxHistorico";
            richTextBoxHistorico.Size = new Size(837, 186);
            richTextBoxHistorico.TabIndex = 25;
            richTextBoxHistorico.Text = "";
            // 
            // Program1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.embras;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(983, 638);
            Controls.Add(richTextBoxHistorico);
            Controls.Add(label12);
            Controls.Add(buttonClean);
            Controls.Add(buttonSave);
            Controls.Add(label11);
            Controls.Add(richTextBoxDescricao);
            Controls.Add(buttonTemporizador);
            Controls.Add(textBoxTempoTermino);
            Controls.Add(label10);
            Controls.Add(textBoxTempoInicio);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxResumo);
            Controls.Add(comboBoxSigla);
            Controls.Add(comboBoxModulo);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxConexao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxEntidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNome);
            Name = "Program1";
            Text = "Sistema de Demandas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEntidade;
        private Label label4;
        private Label label5;
        private TextBox textBoxConexao;
        private TextBox textBoxEmail;
        private Label label6;
        private ComboBox comboBoxModulo;
        private ComboBox comboBoxSigla;
        private TextBox textBoxResumo;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxTempoInicio;
        private Label label10;
        private TextBox textBoxTempoTermino;
        private Button buttonTemporizador;
        private RichTextBox richTextBoxDescricao;
        private Label label11;
        private Button buttonSave;
        private Button buttonClean;
        private Label label12;
        private RichTextBox richTextBoxHistorico;
    }
}
