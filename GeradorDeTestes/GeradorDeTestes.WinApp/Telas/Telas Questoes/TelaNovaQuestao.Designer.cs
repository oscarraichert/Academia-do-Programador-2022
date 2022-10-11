namespace GeradorDeTestes.WinApp.Telas.Telas_Questoes
{
    partial class TelaNovaQuestao
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
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.textBoxEnunciado = new System.Windows.Forms.TextBox();
            this.labelMateria = new System.Windows.Forms.Label();
            this.textBoxMateria = new System.Windows.Forms.TextBox();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.labelBimestre = new System.Windows.Forms.Label();
            this.comboBoxBimestre = new System.Windows.Forms.ComboBox();
            this.labelAlternativas = new System.Windows.Forms.Label();
            this.listBoxAlternativas = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionarAlternativa = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnunciado.Location = new System.Drawing.Point(12, 9);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(68, 17);
            this.labelEnunciado.TabIndex = 0;
            this.labelEnunciado.Text = "Enunciado";
            // 
            // textBoxEnunciado
            // 
            this.textBoxEnunciado.Location = new System.Drawing.Point(93, 8);
            this.textBoxEnunciado.Multiline = true;
            this.textBoxEnunciado.Name = "textBoxEnunciado";
            this.textBoxEnunciado.Size = new System.Drawing.Size(296, 100);
            this.textBoxEnunciado.TabIndex = 1;
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMateria.Location = new System.Drawing.Point(12, 115);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(53, 17);
            this.labelMateria.TabIndex = 0;
            this.labelMateria.Text = "Materia";
            // 
            // textBoxMateria
            // 
            this.textBoxMateria.Location = new System.Drawing.Point(93, 114);
            this.textBoxMateria.Name = "textBoxMateria";
            this.textBoxMateria.Size = new System.Drawing.Size(296, 23);
            this.textBoxMateria.TabIndex = 2;
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDisciplina.Location = new System.Drawing.Point(12, 144);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(63, 17);
            this.labelDisciplina.TabIndex = 0;
            this.labelDisciplina.Text = "Disciplina";
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
            this.comboBoxDisciplina.Location = new System.Drawing.Point(93, 143);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDisciplina.TabIndex = 3;
            // 
            // labelBimestre
            // 
            this.labelBimestre.AutoSize = true;
            this.labelBimestre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBimestre.Location = new System.Drawing.Point(237, 144);
            this.labelBimestre.Name = "labelBimestre";
            this.labelBimestre.Size = new System.Drawing.Size(58, 17);
            this.labelBimestre.TabIndex = 0;
            this.labelBimestre.Text = "Bimestre";
            // 
            // comboBoxBimestre
            // 
            this.comboBoxBimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBimestre.FormattingEnabled = true;
            this.comboBoxBimestre.Items.AddRange(new object[] {
            "1º",
            "2º",
            "3º",
            "4º"});
            this.comboBoxBimestre.Location = new System.Drawing.Point(301, 143);
            this.comboBoxBimestre.Name = "comboBoxBimestre";
            this.comboBoxBimestre.Size = new System.Drawing.Size(88, 23);
            this.comboBoxBimestre.TabIndex = 3;
            // 
            // labelAlternativas
            // 
            this.labelAlternativas.AutoSize = true;
            this.labelAlternativas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlternativas.Location = new System.Drawing.Point(12, 172);
            this.labelAlternativas.Name = "labelAlternativas";
            this.labelAlternativas.Size = new System.Drawing.Size(75, 17);
            this.labelAlternativas.TabIndex = 0;
            this.labelAlternativas.Text = "Alternativas";
            // 
            // listBoxAlternativas
            // 
            this.listBoxAlternativas.FormattingEnabled = true;
            this.listBoxAlternativas.ItemHeight = 15;
            this.listBoxAlternativas.Location = new System.Drawing.Point(93, 172);
            this.listBoxAlternativas.Name = "listBoxAlternativas";
            this.listBoxAlternativas.Size = new System.Drawing.Size(296, 109);
            this.listBoxAlternativas.TabIndex = 4;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(314, 287);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionarAlternativa
            // 
            this.btnAdicionarAlternativa.Location = new System.Drawing.Point(233, 287);
            this.btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            this.btnAdicionarAlternativa.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarAlternativa.TabIndex = 5;
            this.btnAdicionarAlternativa.Text = "Adicionar";
            this.btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            this.btnAdicionarAlternativa.Click += new System.EventHandler(this.btnAdicionarAlternativa_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(314, 415);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(233, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaNovaQuestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionarAlternativa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.listBoxAlternativas);
            this.Controls.Add(this.comboBoxBimestre);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.textBoxMateria);
            this.Controls.Add(this.textBoxEnunciado);
            this.Controls.Add(this.labelBimestre);
            this.Controls.Add(this.labelAlternativas);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaNovaQuestao";
            this.Text = "Nova Questão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.TextBox textBoxEnunciado;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.TextBox textBoxMateria;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label labelBimestre;
        private System.Windows.Forms.ComboBox comboBoxBimestre;
        private System.Windows.Forms.Label labelAlternativas;
        private System.Windows.Forms.ListBox listBoxAlternativas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionarAlternativa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
    }
}