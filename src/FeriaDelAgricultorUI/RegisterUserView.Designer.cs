using System.Drawing;
using System.Windows.Forms;

namespace FeriaDelAgricultorUI
{
    partial class RegisterUserView
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.Location = new Point(24, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new Size(173, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de usuario";
            // 
            // RegisterUserView
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(640, 420);
            this.Controls.Add(this.lblTitulo);
            this.Name = "RegisterUserView";
            this.Text = "Registro de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
