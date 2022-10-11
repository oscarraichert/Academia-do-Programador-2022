namespace e_Agenda.WinApp.TelasCompromisso
{
    partial class TelaNovoCompromisso
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
            this.lblAssunto = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.textBoxHoraIhrs = new System.Windows.Forms.TextBox();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelHorasI = new System.Windows.Forms.Label();
            this.textBoxHoraImin = new System.Windows.Forms.TextBox();
            this.labelMinutosI = new System.Windows.Forms.Label();
            this.lblHoraFim = new System.Windows.Forms.Label();
            this.lblHorasTermino = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTerminoHrs = new System.Windows.Forms.TextBox();
            this.textBoxMinutosTermino = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAssunto.Location = new System.Drawing.Point(12, 9);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(66, 21);
            this.lblAssunto.TabIndex = 0;
            this.lblAssunto.Text = "Assunto";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(84, 11);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(319, 23);
            this.textBoxAssunto.TabIndex = 1;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(84, 40);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(319, 23);
            this.textBoxLocal.TabIndex = 1;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocal.Location = new System.Drawing.Point(12, 38);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 21);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(84, 69);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(319, 23);
            this.textBoxData.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(12, 67);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 21);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // textBoxHoraIhrs
            // 
            this.textBoxHoraIhrs.Location = new System.Drawing.Point(124, 98);
            this.textBoxHoraIhrs.Name = "textBoxHoraIhrs";
            this.textBoxHoraIhrs.Size = new System.Drawing.Size(42, 23);
            this.textBoxHoraIhrs.TabIndex = 1;
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHorario.Location = new System.Drawing.Point(12, 96);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(106, 21);
            this.labelHorario.TabIndex = 0;
            this.labelHorario.Text = "Hora de Início";
            // 
            // labelHorasI
            // 
            this.labelHorasI.AutoSize = true;
            this.labelHorasI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHorasI.Location = new System.Drawing.Point(172, 96);
            this.labelHorasI.Name = "labelHorasI";
            this.labelHorasI.Size = new System.Drawing.Size(32, 21);
            this.labelHorasI.TabIndex = 0;
            this.labelHorasI.Text = "hrs";
            // 
            // textBoxHoraImin
            // 
            this.textBoxHoraImin.Location = new System.Drawing.Point(210, 98);
            this.textBoxHoraImin.Name = "textBoxHoraImin";
            this.textBoxHoraImin.Size = new System.Drawing.Size(42, 23);
            this.textBoxHoraImin.TabIndex = 1;
            // 
            // labelMinutosI
            // 
            this.labelMinutosI.AutoSize = true;
            this.labelMinutosI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinutosI.Location = new System.Drawing.Point(258, 96);
            this.labelMinutosI.Name = "labelMinutosI";
            this.labelMinutosI.Size = new System.Drawing.Size(40, 21);
            this.labelMinutosI.TabIndex = 0;
            this.labelMinutosI.Text = "min.";
            // 
            // lblHoraFim
            // 
            this.lblHoraFim.AutoSize = true;
            this.lblHoraFim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraFim.Location = new System.Drawing.Point(12, 125);
            this.lblHoraFim.Name = "lblHoraFim";
            this.lblHoraFim.Size = new System.Drawing.Size(66, 21);
            this.lblHoraFim.TabIndex = 0;
            this.lblHoraFim.Text = "Término";
            // 
            // lblHorasTermino
            // 
            this.lblHorasTermino.AutoSize = true;
            this.lblHorasTermino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorasTermino.Location = new System.Drawing.Point(172, 125);
            this.lblHorasTermino.Name = "lblHorasTermino";
            this.lblHorasTermino.Size = new System.Drawing.Size(32, 21);
            this.lblHorasTermino.TabIndex = 0;
            this.lblHorasTermino.Text = "hrs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(258, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "min.";
            // 
            // textBoxTerminoHrs
            // 
            this.textBoxTerminoHrs.Location = new System.Drawing.Point(124, 127);
            this.textBoxTerminoHrs.Name = "textBoxTerminoHrs";
            this.textBoxTerminoHrs.Size = new System.Drawing.Size(42, 23);
            this.textBoxTerminoHrs.TabIndex = 1;
            // 
            // textBoxMinutosTermino
            // 
            this.textBoxMinutosTermino.Location = new System.Drawing.Point(210, 127);
            this.textBoxMinutosTermino.Name = "textBoxMinutosTermino";
            this.textBoxMinutosTermino.Size = new System.Drawing.Size(42, 23);
            this.textBoxMinutosTermino.TabIndex = 1;
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContato.Location = new System.Drawing.Point(12, 184);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(189, 21);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "Contato do Compromisso";
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(12, 208);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(391, 184);
            this.listBoxContatos.TabIndex = 2;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(328, 414);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(247, 414);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaNovoCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 449);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.textBoxMinutosTermino);
            this.Controls.Add(this.textBoxHoraImin);
            this.Controls.Add(this.textBoxTerminoHrs);
            this.Controls.Add(this.textBoxHoraIhrs);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.lblHorasTermino);
            this.Controls.Add(this.labelMinutosI);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblHoraFim);
            this.Controls.Add(this.labelHorasI);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblAssunto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaNovoCompromisso";
            this.Text = "Novo Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox textBoxHoraIhrs;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.Label labelHorasI;
        private System.Windows.Forms.TextBox textBoxHoraImin;
        private System.Windows.Forms.Label labelMinutosI;
        private System.Windows.Forms.Label lblHoraFim;
        private System.Windows.Forms.Label lblHorasTermino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTerminoHrs;
        private System.Windows.Forms.TextBox textBoxMinutosTermino;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
    }
}