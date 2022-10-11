namespace TestesDonaMariana.WinApp.Telas.Questoes
{
    partial class TelaCadastroQuestao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.listBoxAlternativas = new System.Windows.Forms.ListBox();
            this.lblAlternativas = new System.Windows.Forms.Label();
            this.btnExcluirAlternativa = new System.Windows.Forms.Button();
            this.btnAdicionarAlternativa = new System.Windows.Forms.Button();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(12, 9);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(77, 21);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(110, 11);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(330, 23);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // listBoxAlternativas
            // 
            this.listBoxAlternativas.FormattingEnabled = true;
            this.listBoxAlternativas.ItemHeight = 15;
            this.listBoxAlternativas.Location = new System.Drawing.Point(110, 98);
            this.listBoxAlternativas.Name = "listBoxAlternativas";
            this.listBoxAlternativas.Size = new System.Drawing.Size(330, 154);
            this.listBoxAlternativas.TabIndex = 2;
            // 
            // lblAlternativas
            // 
            this.lblAlternativas.AutoSize = true;
            this.lblAlternativas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlternativas.Location = new System.Drawing.Point(12, 98);
            this.lblAlternativas.Name = "lblAlternativas";
            this.lblAlternativas.Size = new System.Drawing.Size(92, 21);
            this.lblAlternativas.TabIndex = 0;
            this.lblAlternativas.Text = "Alternativas";
            // 
            // btnExcluirAlternativa
            // 
            this.btnExcluirAlternativa.Location = new System.Drawing.Point(365, 258);
            this.btnExcluirAlternativa.Name = "btnExcluirAlternativa";
            this.btnExcluirAlternativa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAlternativa.TabIndex = 3;
            this.btnExcluirAlternativa.Text = "Excluir";
            this.btnExcluirAlternativa.UseVisualStyleBackColor = true;
            this.btnExcluirAlternativa.Click += new System.EventHandler(this.btnExcluirAlternativa_Click);
            // 
            // btnAdicionarAlternativa
            // 
            this.btnAdicionarAlternativa.Location = new System.Drawing.Point(284, 258);
            this.btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            this.btnAdicionarAlternativa.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAlternativa.TabIndex = 3;
            this.btnAdicionarAlternativa.Text = "Adicionar";
            this.btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            this.btnAdicionarAlternativa.Click += new System.EventHandler(this.btnAdicionarAlternativa_Click);
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(110, 69);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(330, 23);
            this.textBoxMateria.TabIndex = 1;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(12, 67);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(63, 21);
            this.lblMateria.TabIndex = 0;
            this.lblMateria.Text = "Materia";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(365, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(110, 40);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(330, 23);
            this.comboBoxDisciplina.TabIndex = 5;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisciplina.Location = new System.Drawing.Point(12, 38);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(77, 21);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // TelaCadastroQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 430);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAdicionarAlternativa);
            this.Controls.Add(this.btnExcluirAlternativa);
            this.Controls.Add(this.listBoxAlternativas);
            this.Controls.Add(this.textBoxMateria);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.lblAlternativas);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroQuestao";
            this.Text = "Cadastro de Questão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ListBox listBoxAlternativas;
        private System.Windows.Forms.Label lblAlternativas;
        private System.Windows.Forms.Button btnExcluirAlternativa;
        private System.Windows.Forms.Button btnAdicionarAlternativa;
        private System.Windows.Forms.TextBox textBoxMateria;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
    }
}