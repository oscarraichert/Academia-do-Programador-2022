namespace e_Agenda.WinApp.TelasTarefa
{
    partial class TelaVisualizarTarefas
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
            this.lblListaTarefas = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTarefasConcluidas = new System.Windows.Forms.Label();
            this.lblConcluidas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListaTarefas
            // 
            this.lblListaTarefas.AutoSize = true;
            this.lblListaTarefas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaTarefas.Location = new System.Drawing.Point(12, 30);
            this.lblListaTarefas.Name = "lblListaTarefas";
            this.lblListaTarefas.Size = new System.Drawing.Size(31, 21);
            this.lblListaTarefas.TabIndex = 0;
            this.lblListaTarefas.Text = "xxx";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLista.Location = new System.Drawing.Point(12, 9);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(125, 21);
            this.lblLista.TabIndex = 0;
            this.lblLista.Text = "Lista de tarefas:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Location = new System.Drawing.Point(713, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblTarefasConcluidas
            // 
            this.lblTarefasConcluidas.AutoSize = true;
            this.lblTarefasConcluidas.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTarefasConcluidas.Location = new System.Drawing.Point(531, 9);
            this.lblTarefasConcluidas.Name = "lblTarefasConcluidas";
            this.lblTarefasConcluidas.Size = new System.Drawing.Size(150, 21);
            this.lblTarefasConcluidas.TabIndex = 0;
            this.lblTarefasConcluidas.Text = "Tarefas concluídas:";
            // 
            // lblConcluidas
            // 
            this.lblConcluidas.AutoSize = true;
            this.lblConcluidas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConcluidas.Location = new System.Drawing.Point(531, 41);
            this.lblConcluidas.Name = "lblConcluidas";
            this.lblConcluidas.Size = new System.Drawing.Size(31, 21);
            this.lblConcluidas.TabIndex = 0;
            this.lblConcluidas.Text = "xxx";
            // 
            // TelaVisualizarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblTarefasConcluidas);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lblConcluidas);
            this.Controls.Add(this.lblListaTarefas);
            this.Name = "TelaVisualizarTarefas";
            this.Text = "Visualizar Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaTarefas;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTarefasConcluidas;
        private System.Windows.Forms.Label lblConcluidas;
    }
}