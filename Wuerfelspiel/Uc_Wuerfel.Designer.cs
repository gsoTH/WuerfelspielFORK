namespace Wuerfelspiel
{
    partial class Uc_Wuerfel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Uc_Wuerfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Name = "Uc_Wuerfel";
            this.Size = new System.Drawing.Size(174, 170);
            this.Click += new System.EventHandler(this.Uc_Wuerfel_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Uc_Wuerfel_Paint);
            this.DoubleClick += new System.EventHandler(this.Uc_Wuerfel_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
