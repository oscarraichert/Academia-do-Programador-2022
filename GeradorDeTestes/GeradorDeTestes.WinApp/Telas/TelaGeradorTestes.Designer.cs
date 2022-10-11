namespace GeradorDeTestes.WinApp
{
    partial class TelaGeradorTestes
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
            this.btnQuestoes = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.lblNumeroQuestoes = new System.Windows.Forms.Label();
            this.textBoxNumeroQuestoes = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerarTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestoes
            // 
            this.btnQuestoes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuestoes.Location = new System.Drawing.Point(190, 12);
            this.btnQuestoes.Name = "btnQuestoes";
            this.btnQuestoes.Size = new System.Drawing.Size(132, 57);
            this.btnQuestoes.TabIndex = 0;
            this.btnQuestoes.Text = "Questoes";
            this.btnQuestoes.UseVisualStyleBackColor = true;
            this.btnQuestoes.Click += new System.EventHandler(this.btnQuestoes_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorico.Location = new System.Drawing.Point(12, 12);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(132, 57);
            this.btnHistorico.TabIndex = 0;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisciplina.Location = new System.Drawing.Point(12, 99);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(75, 20);
            this.lblDisciplina.TabIndex = 1;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Items.AddRange(new object[] {
            "Matemática",
            "Português",
            "História",
            "Geografia",
            "Ciências"});
            this.comboBoxDisciplina.Location = new System.Drawing.Point(133, 100);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(189, 23);
            this.comboBoxDisciplina.TabIndex = 2;
            // 
            // lblNumeroQuestoes
            // 
            this.lblNumeroQuestoes.AutoSize = true;
            this.lblNumeroQuestoes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroQuestoes.Location = new System.Drawing.Point(12, 146);
            this.lblNumeroQuestoes.Name = "lblNumeroQuestoes";
            this.lblNumeroQuestoes.Size = new System.Drawing.Size(115, 20);
            this.lblNumeroQuestoes.TabIndex = 1;
            this.lblNumeroQuestoes.Text = "Nº de Questões";
            // 
            // textBoxNumeroQuestoes
            // 
            this.textBoxNumeroQuestoes.Location = new System.Drawing.Point(133, 146);
            this.textBoxNumeroQuestoes.Name = "textBoxNumeroQuestoes";
            this.textBoxNumeroQuestoes.Size = new System.Drawing.Size(189, 23);
            this.textBoxNumeroQuestoes.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(190, 195);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(132, 35);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerarTeste
            // 
            this.btnGerarTeste.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarTeste.Location = new System.Drawing.Point(12, 195);
            this.btnGerarTeste.Name = "btnGerarTeste";
            this.btnGerarTeste.Size = new System.Drawing.Size(132, 35);
            this.btnGerarTeste.TabIndex = 0;
            this.btnGerarTeste.Text = "Gerar Teste";
            this.btnGerarTeste.UseVisualStyleBackColor = true;
            this.btnGerarTeste.Click += new System.EventHandler(this.btnGerarTeste_Click);
            // 
            // TelaGeradorTestes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 240);
            this.Controls.Add(this.textBoxNumeroQuestoes);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.lblNumeroQuestoes);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.btnGerarTeste);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnQuestoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaGeradorTestes";
            this.Text = "Gerador de Testes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestoes;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label lblNumeroQuestoes;
        private System.Windows.Forms.TextBox textBoxNumeroQuestoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGerarTeste;
    }
}
