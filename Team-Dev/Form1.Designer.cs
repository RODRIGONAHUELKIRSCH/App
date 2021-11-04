namespace Team_Dev
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labeliniciesesion = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelcontraseña = new System.Windows.Forms.Label();
            this.labelextravio = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labeliniciesesion
            // 
            this.labeliniciesesion.AutoSize = true;
            this.labeliniciesesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeliniciesesion.Location = new System.Drawing.Point(116, 9);
            this.labeliniciesesion.Name = "labeliniciesesion";
            this.labeliniciesesion.Size = new System.Drawing.Size(181, 33);
            this.labeliniciesesion.TabIndex = 0;
            this.labeliniciesesion.Text = "Inicie Sesion";
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(149, 70);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(96, 29);
            this.labelusuario.TabIndex = 1;
            this.labelusuario.Text = "Usuario";
            // 
            // labelcontraseña
            // 
            this.labelcontraseña.AutoSize = true;
            this.labelcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcontraseña.Location = new System.Drawing.Point(142, 185);
            this.labelcontraseña.Name = "labelcontraseña";
            this.labelcontraseña.Size = new System.Drawing.Size(136, 29);
            this.labelcontraseña.TabIndex = 2;
            this.labelcontraseña.Text = "Contraseña";
            this.labelcontraseña.Click += new System.EventHandler(this.labelcontraseña_Click);
            // 
            // labelextravio
            // 
            this.labelextravio.AutoSize = true;
            this.labelextravio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelextravio.Location = new System.Drawing.Point(135, 354);
            this.labelextravio.Name = "labelextravio";
            this.labelextravio.Size = new System.Drawing.Size(155, 13);
            this.labelextravio.TabIndex = 3;
            this.labelextravio.Text = "¿Ha extraviado su contraseña?";
            // 
            // tbusuario
            // 
            this.tbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuario.Location = new System.Drawing.Point(138, 123);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(140, 31);
            this.tbusuario.TabIndex = 4;
            this.tbusuario.TextChanged += new System.EventHandler(this.tbusuario_TextChanged);
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontraseña.Location = new System.Drawing.Point(138, 231);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.PasswordChar = '*';
            this.tbcontraseña.Size = new System.Drawing.Size(140, 31);
            this.tbcontraseña.TabIndex = 5;
            this.tbcontraseña.TextChanged += new System.EventHandler(this.tbcontraseña_TextChanged);
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(138, 290);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(140, 35);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 386);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.labelextravio);
            this.Controls.Add(this.labelcontraseña);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.labeliniciesesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 425);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 425);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeliniciesesion;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelcontraseña;
        private System.Windows.Forms.Label labelextravio;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.Button btningresar;
    }
}

