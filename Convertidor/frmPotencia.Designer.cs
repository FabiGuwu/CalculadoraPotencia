namespace Convertidor
{
    partial class frmPotencia
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblPotencia = new Label();
            txtElevar = new TextBox();
            btnPotencia = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.Location = new Point(12, 32);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(61, 23);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(97, 29);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblPotencia
            // 
            lblPotencia.Location = new Point(12, 73);
            lblPotencia.Name = "lblPotencia";
            lblPotencia.Size = new Size(154, 23);
            lblPotencia.TabIndex = 2;
            lblPotencia.Text = "Numero al que se va elevar";
            // 
            // txtElevar
            // 
            txtElevar.Location = new Point(172, 73);
            txtElevar.Name = "txtElevar";
            txtElevar.Size = new Size(100, 23);
            txtElevar.TabIndex = 3;
            // 
            // btnPotencia
            // 
            btnPotencia.Location = new Point(12, 108);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(75, 23);
            btnPotencia.TabIndex = 4;
            btnPotencia.Text = "OK";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = SystemColors.ButtonShadow;
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(12, 149);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(307, 76);
            lblResultado.TabIndex = 5;
            // 
            // frmPotencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 234);
            Controls.Add(lblResultado);
            Controls.Add(btnPotencia);
            Controls.Add(txtElevar);
            Controls.Add(lblPotencia);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "frmPotencia";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblPotencia;
        private TextBox txtElevar;
        private Button btnPotencia;
        private Label lblResultado;
    }
}