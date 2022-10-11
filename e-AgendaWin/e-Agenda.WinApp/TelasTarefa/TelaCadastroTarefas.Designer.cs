namespace e_Agenda.WinApp.TelasTarefa
{
    partial class TelaCadastroTarefa
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.txtboxTitulo = new System.Windows.Forms.TextBox();
            this.txtboxDescricao = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.radiobtnAlta = new System.Windows.Forms.RadioButton();
            this.radiobtnNormal = new System.Windows.Forms.RadioButton();
            this.radiobtnBaixa = new System.Windows.Forms.RadioButton();
            this.panelPrioridade = new System.Windows.Forms.Panel();
            this.panelPrioridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(144, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título da tarefa:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescricao.Location = new System.Drawing.Point(12, 66);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(98, 25);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Descrição:";
            // 
            // txtboxTitulo
            // 
            this.txtboxTitulo.Location = new System.Drawing.Point(162, 11);
            this.txtboxTitulo.Name = "txtboxTitulo";
            this.txtboxTitulo.Size = new System.Drawing.Size(327, 23);
            this.txtboxTitulo.TabIndex = 1;
            // 
            // txtboxDescricao
            // 
            this.txtboxDescricao.Location = new System.Drawing.Point(162, 66);
            this.txtboxDescricao.Name = "txtboxDescricao";
            this.txtboxDescricao.Size = new System.Drawing.Size(327, 23);
            this.txtboxDescricao.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(414, 233);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(333, 233);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrioridade.Location = new System.Drawing.Point(12, 119);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(104, 25);
            this.labelPrioridade.TabIndex = 0;
            this.labelPrioridade.Text = "Prioridade:";
            // 
            // radiobtnAlta
            // 
            this.radiobtnAlta.AutoSize = true;
            this.radiobtnAlta.Location = new System.Drawing.Point(6, 3);
            this.radiobtnAlta.Name = "radiobtnAlta";
            this.radiobtnAlta.Size = new System.Drawing.Size(46, 19);
            this.radiobtnAlta.TabIndex = 6;
            this.radiobtnAlta.TabStop = true;
            this.radiobtnAlta.Text = "Alta";
            this.radiobtnAlta.UseVisualStyleBackColor = true;
            // 
            // radiobtnNormal
            // 
            this.radiobtnNormal.AutoSize = true;
            this.radiobtnNormal.Location = new System.Drawing.Point(106, 3);
            this.radiobtnNormal.Name = "radiobtnNormal";
            this.radiobtnNormal.Size = new System.Drawing.Size(65, 19);
            this.radiobtnNormal.TabIndex = 6;
            this.radiobtnNormal.TabStop = true;
            this.radiobtnNormal.Text = "Normal";
            this.radiobtnNormal.UseVisualStyleBackColor = true;
            // 
            // radiobtnBaixa
            // 
            this.radiobtnBaixa.AutoSize = true;
            this.radiobtnBaixa.Location = new System.Drawing.Point(206, 3);
            this.radiobtnBaixa.Name = "radiobtnBaixa";
            this.radiobtnBaixa.Size = new System.Drawing.Size(53, 19);
            this.radiobtnBaixa.TabIndex = 6;
            this.radiobtnBaixa.TabStop = true;
            this.radiobtnBaixa.Text = "Baixa";
            this.radiobtnBaixa.UseVisualStyleBackColor = true;
            // 
            // panelPrioridade
            // 
            this.panelPrioridade.Controls.Add(this.radiobtnAlta);
            this.panelPrioridade.Controls.Add(this.radiobtnBaixa);
            this.panelPrioridade.Controls.Add(this.radiobtnNormal);
            this.panelPrioridade.Location = new System.Drawing.Point(162, 119);
            this.panelPrioridade.Name = "panelPrioridade";
            this.panelPrioridade.Size = new System.Drawing.Size(310, 28);
            this.panelPrioridade.TabIndex = 7;
            // 
            // TelaCadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 268);
            this.Controls.Add(this.panelPrioridade);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtboxDescricao);
            this.Controls.Add(this.txtboxTitulo);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelTitulo);
            this.Name = "TelaCadastroTarefa";
            this.Text = "Cadastrar Tarefa";
            this.panelPrioridade.ResumeLayout(false);
            this.panelPrioridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox txtboxTitulo;
        private System.Windows.Forms.TextBox txtboxDescricao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.RadioButton radiobtnAlta;
        private System.Windows.Forms.RadioButton radiobtnNormal;
        private System.Windows.Forms.RadioButton radiobtnBaixa;
        private System.Windows.Forms.Panel panelPrioridade;
    }
}