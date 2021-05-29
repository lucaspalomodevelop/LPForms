
namespace Test
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lpFormPanel1 = new LPForms.LPFormPanel(this.components);
            this.SuspendLayout();
            // 
            // lpFormPanel1
            // 
            this.lpFormPanel1.AutoScroll = true;
            this.lpFormPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lpFormPanel1.Location = new System.Drawing.Point(0, 0);
            this.lpFormPanel1.Name = "lpFormPanel1";
            this.lpFormPanel1.Size = new System.Drawing.Size(800, 450);
            this.lpFormPanel1.TabIndex = 0;
            this.lpFormPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.lpFormPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lpFormPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LPForms.LPFormPanel lpFormPanel1;
    }
}

