namespace FeriaDelAgricultor.Views
{
    partial class frmRegistro
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            lblContraseña = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblTitulo.ForeColor = Color.DarkGreen;
            lblTitulo.Location = new Point(12, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(100, 13);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Usuario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(58, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 63);
            txtNombre.MaximumSize = new Size(300, 0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(57, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(118, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(252, 23);
            txtApellido.TabIndex = 4;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreo.Location = new Point(64, 164);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(48, 15);
            lblCorreo.TabIndex = 5;
            lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblContraseña.Location = new Point(40, 206);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(72, 15);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(118, 156);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(252, 23);
            txtCorreo.TabIndex = 7;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(118, 198);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(252, 23);
            txtContraseña.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(0, 120, 0);
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(146, 258);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(82, 32);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrarse";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(255, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 32);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(434, 511);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro - Feria del Agricultor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCorreo;
        private Label lblContraseña;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnRegistrar;
        private Button btnCancelar;
    }
}