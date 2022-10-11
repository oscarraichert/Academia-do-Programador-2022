namespace TestesDonaMariana.WinApp
{
    partial class TelaPrincipal
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
            this.btnMenuTestes = new System.Windows.Forms.Button();
            this.btnQuestoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuTestes
            // 
            this.btnMenuTestes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuTestes.Location = new System.Drawing.Point(12, 12);
            this.btnMenuTestes.Name = "btnMenuTestes";
            this.btnMenuTestes.Size = new System.Drawing.Size(174, 84);
            this.btnMenuTestes.TabIndex = 0;
            this.btnMenuTestes.Text = "Testes";
            this.btnMenuTestes.UseVisualStyleBackColor = true;
            this.btnMenuTestes.Click += new System.EventHandler(this.btnMenuTestes_Click);
            // 
            // btnQuestoes
            // 
            this.btnQuestoes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuestoes.Location = new System.Drawing.Point(192, 12);
            this.btnQuestoes.Name = "btnQuestoes";
            this.btnQuestoes.Size = new System.Drawing.Size(174, 84);
            this.btnQuestoes.TabIndex = 0;
            this.btnQuestoes.Text = "Questões";
            this.btnQuestoes.UseVisualStyleBackColor = true;
            this.btnQuestoes.Click += new System.EventHandler(this.btnQuestoes_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestoes);
            this.Controls.Add(this.btnMenuTestes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Gerador de Testes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuTestes;
        private System.Windows.Forms.Button btnQuestoes;
    }
}
