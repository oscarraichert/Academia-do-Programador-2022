namespace GeradorDeTestes.WinApp.Telas.Telas_Questoes
{
    partial class TelaMenuQuestoes
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
            this.btnAdicionarQuestao = new System.Windows.Forms.Button();
            this.btnEditarQuestao = new System.Windows.Forms.Button();
            this.btnExcluirQuestao = new System.Windows.Forms.Button();
            this.listBoxQuestoes = new System.Windows.Forms.ListBox();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarQuestao
            // 
            this.btnAdicionarQuestao.Location = new System.Drawing.Point(12, 12);
            this.btnAdicionarQuestao.Name = "btnAdicionarQuestao";
            this.btnAdicionarQuestao.Size = new System.Drawing.Size(70, 25);
            this.btnAdicionarQuestao.TabIndex = 0;
            this.btnAdicionarQuestao.Text = "Nova";
            this.btnAdicionarQuestao.UseVisualStyleBackColor = true;
            this.btnAdicionarQuestao.Click += new System.EventHandler(this.btnAdicionarQuestao_Click);
            // 
            // btnEditarQuestao
            // 
            this.btnEditarQuestao.Location = new System.Drawing.Point(88, 12);
            this.btnEditarQuestao.Name = "btnEditarQuestao";
            this.btnEditarQuestao.Size = new System.Drawing.Size(70, 25);
            this.btnEditarQuestao.TabIndex = 0;
            this.btnEditarQuestao.Text = "Editar";
            this.btnEditarQuestao.UseVisualStyleBackColor = true;
            this.btnEditarQuestao.Click += new System.EventHandler(this.btnEditarQuestao_Click);
            // 
            // btnExcluirQuestao
            // 
            this.btnExcluirQuestao.Location = new System.Drawing.Point(164, 12);
            this.btnExcluirQuestao.Name = "btnExcluirQuestao";
            this.btnExcluirQuestao.Size = new System.Drawing.Size(70, 25);
            this.btnExcluirQuestao.TabIndex = 0;
            this.btnExcluirQuestao.Text = "Excluir";
            this.btnExcluirQuestao.UseVisualStyleBackColor = true;
            this.btnExcluirQuestao.Click += new System.EventHandler(this.btnExcluirQuestao_Click);
            // 
            // listBoxQuestoes
            // 
            this.listBoxQuestoes.FormattingEnabled = true;
            this.listBoxQuestoes.ItemHeight = 15;
            this.listBoxQuestoes.Location = new System.Drawing.Point(12, 43);
            this.listBoxQuestoes.Name = "listBoxQuestoes";
            this.listBoxQuestoes.Size = new System.Drawing.Size(298, 124);
            this.listBoxQuestoes.TabIndex = 1;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Location = new System.Drawing.Point(240, 12);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(70, 25);
            this.btnDetalhes.TabIndex = 0;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // TelaMenuQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.listBoxQuestoes);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnExcluirQuestao);
            this.Controls.Add(this.btnEditarQuestao);
            this.Controls.Add(this.btnAdicionarQuestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaMenuQuestoes";
            this.Text = "Questões";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarQuestao;
        private System.Windows.Forms.Button btnEditarQuestao;
        private System.Windows.Forms.Button btnExcluirQuestao;
        private System.Windows.Forms.ListBox listBoxQuestoes;
        private System.Windows.Forms.Button btnDetalhes;
    }
}