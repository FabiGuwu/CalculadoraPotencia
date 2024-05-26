namespace Convertidor
{
    partial class frmConvertidor
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
            menuStrip1 = new MenuStrip();
            convertidorToolStripMenuItem = new ToolStripMenuItem();
            potenciasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { convertidorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // convertidorToolStripMenuItem
            // 
            convertidorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { potenciasToolStripMenuItem });
            convertidorToolStripMenuItem.Name = "convertidorToolStripMenuItem";
            convertidorToolStripMenuItem.Size = new Size(82, 20);
            convertidorToolStripMenuItem.Text = "Convertidor";
            // 
            // potenciasToolStripMenuItem
            // 
            potenciasToolStripMenuItem.Name = "potenciasToolStripMenuItem";
            potenciasToolStripMenuItem.Size = new Size(180, 22);
            potenciasToolStripMenuItem.Text = "Potencias";
            potenciasToolStripMenuItem.Click += potenciasToolStripMenuItem_Click;
            // 
            // frmConvertidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmConvertidor";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem convertidorToolStripMenuItem;
        private ToolStripMenuItem potenciasToolStripMenuItem;
    }
}
