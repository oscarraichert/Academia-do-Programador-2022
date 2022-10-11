namespace TestesDonaMariana.WinApp.Telas.Questoes
{
    partial class TelaCadastroAlternativas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonErrada = new System.Windows.Forms.RadioButton();
            this.radioButtonCerta = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.textBoxDescricao.Location = new System.Drawing.Point(95, 11);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(149, 23);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonErrada);
            this.panel1.Controls.Add(this.radioButtonCerta);
            this.panel1.Location = new System.Drawing.Point(95, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 24);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonErrada
            // 
            this.radioButtonErrada.AutoSize = true;
            this.radioButtonErrada.Location = new System.Drawing.Point(91, 3);
            this.radioButtonErrada.Name = "radioButtonErrada";
            this.radioButtonErrada.Size = new System.Drawing.Size(58, 19);
            this.radioButtonErrada.TabIndex = 0;
            this.radioButtonErrada.TabStop = true;
            this.radioButtonErrada.Text = "Errada";
            this.radioButtonErrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonCerta
            // 
            this.radioButtonCerta.AutoSize = true;
            this.radioButtonCerta.Location = new System.Drawing.Point(3, 3);
            this.radioButtonCerta.Name = "radioButtonCerta";
            this.radioButtonCerta.Size = new System.Drawing.Size(53, 19);
            this.radioButtonCerta.TabIndex = 0;
            this.radioButtonCerta.TabStop = true;
            this.radioButtonCerta.Text = "Certa";
            this.radioButtonCerta.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(171, 70);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdicionar.Location = new System.Drawing.Point(90, 70);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // TelaCadastroAlternativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 103);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroAlternativas";
            this.Text = "Cadastro de Alternativas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonErrada;
        private System.Windows.Forms.RadioButton radioButtonCerta;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdicionar;
    }
}