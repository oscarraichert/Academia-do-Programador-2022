namespace GeradorDeTestes.WinApp.Telas.Telas_Questoes
{
    partial class TelaDetalhesQuestao
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
            this.lblQuestao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestao
            // 
            this.lblQuestao.AutoEllipsis = true;
            this.lblQuestao.AutoSize = true;
            this.lblQuestao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestao.Location = new System.Drawing.Point(12, 9);
            this.lblQuestao.MaximumSize = new System.Drawing.Size(470, 0);
            this.lblQuestao.Name = "lblQuestao";
            this.lblQuestao.Size = new System.Drawing.Size(57, 19);
            this.lblQuestao.TabIndex = 0;
            this.lblQuestao.Text = "questao";
            // 
            // TelaDetalhesQuestao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(472, 449);
            this.Controls.Add(this.lblQuestao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaDetalhesQuestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestao;
    }
}