namespace e_Agenda.WinApp.TelasTarefa
{
    partial class TelaItensTarefa
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
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            this.listBoxItens = new System.Windows.Forms.ListBox();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnConcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.Location = new System.Drawing.Point(12, 9);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(65, 21);
            this.labelTituloTarefa.TabIndex = 0;
            this.labelTituloTarefa.Text = "Tarefa: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(83, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(31, 15);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "xxxx";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItens.Location = new System.Drawing.Point(12, 49);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(51, 21);
            this.lblItens.TabIndex = 0;
            this.lblItens.Text = "Itens:";
            // 
            // listBoxItens
            // 
            this.listBoxItens.FormattingEnabled = true;
            this.listBoxItens.ItemHeight = 15;
            this.listBoxItens.Location = new System.Drawing.Point(72, 57);
            this.listBoxItens.Name = "listBoxItens";
            this.listBoxItens.Size = new System.Drawing.Size(241, 169);
            this.listBoxItens.TabIndex = 2;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Location = new System.Drawing.Point(238, 232);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirItem.TabIndex = 3;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.UseVisualStyleBackColor = true;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnConcluirItem
            // 
            this.btnConcluirItem.Location = new System.Drawing.Point(157, 232);
            this.btnConcluirItem.Name = "btnConcluirItem";
            this.btnConcluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnConcluirItem.TabIndex = 3;
            this.btnConcluirItem.Text = "Concluir";
            this.btnConcluirItem.UseVisualStyleBackColor = true;
            this.btnConcluirItem.Click += new System.EventHandler(this.btnConcluirItem_Click);
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(76, 232);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarItem.TabIndex = 3;
            this.btnAdicionarItem.Text = "Adicionar";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(238, 430);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(157, 430);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 465);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarItem);
            this.Controls.Add(this.btnConcluirItem);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.listBoxItens);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.labelTituloTarefa);
            this.Name = "TelaItensTarefa";
            this.Text = "Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblItens;
        private System.Windows.Forms.ListBox listBoxItens;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnConcluirItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
    }
}