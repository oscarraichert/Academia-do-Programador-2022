namespace TestesDonaMariana.WinApp.Telas
{
    partial class TelaMenuBase<T>
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
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnEditarCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.listBoxCadastros = new System.Windows.Forms.ListBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Location = new System.Drawing.Point(12, 12);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(110, 46);
            this.btnNovoCadastro.TabIndex = 0;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnEditarCadastro
            // 
            this.btnEditarCadastro.Location = new System.Drawing.Point(128, 12);
            this.btnEditarCadastro.Name = "btnEditarCadastro";
            this.btnEditarCadastro.Size = new System.Drawing.Size(110, 46);
            this.btnEditarCadastro.TabIndex = 0;
            this.btnEditarCadastro.Text = "Editar Cadastro";
            this.btnEditarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.Location = new System.Drawing.Point(244, 12);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(110, 46);
            this.btnExcluirCadastro.TabIndex = 0;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = true;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // listBoxCadastros
            // 
            this.listBoxCadastros.FormattingEnabled = true;
            this.listBoxCadastros.ItemHeight = 15;
            this.listBoxCadastros.Location = new System.Drawing.Point(12, 64);
            this.listBoxCadastros.Name = "listBoxCadastros";
            this.listBoxCadastros.Size = new System.Drawing.Size(458, 379);
            this.listBoxCadastros.TabIndex = 1;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(360, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(110, 46);
            this.btnVisualizar.TabIndex = 0;
            this.btnVisualizar.Text = "Visualizar Cadastros";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // TelaMenuBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.listBoxCadastros);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluirCadastro);
            this.Controls.Add(this.btnEditarCadastro);
            this.Controls.Add(this.btnNovoCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaMenuBase";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnEditarCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.ListBox listBoxCadastros;
        private System.Windows.Forms.Button btnVisualizar;
    }
}