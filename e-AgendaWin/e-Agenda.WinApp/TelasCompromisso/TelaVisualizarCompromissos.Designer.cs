namespace e_Agenda.WinApp.TelasCompromisso
{
    partial class TelaVisualizarCompromissos
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
            this.lblListaCompromissos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblListaCompromissos
            // 
            this.lblListaCompromissos.AutoSize = true;
            this.lblListaCompromissos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListaCompromissos.Location = new System.Drawing.Point(12, 9);
            this.lblListaCompromissos.Name = "lblListaCompromissos";
            this.lblListaCompromissos.Size = new System.Drawing.Size(175, 21);
            this.lblListaCompromissos.TabIndex = 0;
            this.lblListaCompromissos.Text = "Lista de Compromissos:";
            // 
            // TelaVisualizarCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.lblListaCompromissos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaVisualizarCompromissos";
            this.Text = "Visualizar Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaCompromissos;
    }
}