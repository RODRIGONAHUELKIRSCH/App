
namespace Team_Dev
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.labelagregarpersonal = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapellido = new System.Windows.Forms.Label();
            this.labelpermiso = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelclave = new System.Windows.Forms.Label();
            this.labelsexo = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbpermiso = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.tbsexo = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnaddpersonal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelagregarpersonal
            // 
            this.labelagregarpersonal.AutoSize = true;
            this.labelagregarpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelagregarpersonal.Location = new System.Drawing.Point(13, 13);
            this.labelagregarpersonal.Name = "labelagregarpersonal";
            this.labelagregarpersonal.Size = new System.Drawing.Size(207, 29);
            this.labelagregarpersonal.TabIndex = 0;
            this.labelagregarpersonal.Text = "Agregar Personal:";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(61, 67);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(32, 24);
            this.labelid.TabIndex = 1;
            this.labelid.Text = "ID:";
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(59, 126);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(84, 24);
            this.labelnombre.TabIndex = 2;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelapellido
            // 
            this.labelapellido.AutoSize = true;
            this.labelapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapellido.Location = new System.Drawing.Point(59, 188);
            this.labelapellido.Name = "labelapellido";
            this.labelapellido.Size = new System.Drawing.Size(84, 24);
            this.labelapellido.TabIndex = 3;
            this.labelapellido.Text = "Apellido:";
            // 
            // labelpermiso
            // 
            this.labelpermiso.AutoSize = true;
            this.labelpermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpermiso.Location = new System.Drawing.Point(61, 261);
            this.labelpermiso.Name = "labelpermiso";
            this.labelpermiso.Size = new System.Drawing.Size(79, 24);
            this.labelpermiso.TabIndex = 4;
            this.labelpermiso.Text = "Permiso";
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(61, 347);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(79, 24);
            this.labeluser.TabIndex = 5;
            this.labeluser.Text = "Usuario:";
            this.labeluser.Click += new System.EventHandler(this.labeluser_Click);
            // 
            // labelclave
            // 
            this.labelclave.AutoSize = true;
            this.labelclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclave.Location = new System.Drawing.Point(59, 423);
            this.labelclave.Name = "labelclave";
            this.labelclave.Size = new System.Drawing.Size(111, 24);
            this.labelclave.TabIndex = 6;
            this.labelclave.Text = "Contraseña:";
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsexo.Location = new System.Drawing.Point(61, 500);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(59, 24);
            this.labelsexo.TabIndex = 7;
            this.labelsexo.Text = "Sexo:";
            // 
            // tbid
            // 
            this.tbid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbid.Location = new System.Drawing.Point(193, 66);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(150, 26);
            this.tbid.TabIndex = 8;
            // 
            // tbnombre
            // 
            this.tbnombre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(193, 125);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(150, 26);
            this.tbnombre.TabIndex = 9;
            // 
            // tbapellido
            // 
            this.tbapellido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbapellido.Location = new System.Drawing.Point(193, 187);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(150, 26);
            this.tbapellido.TabIndex = 10;
            // 
            // tbpermiso
            // 
            this.tbpermiso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbpermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpermiso.Location = new System.Drawing.Point(193, 263);
            this.tbpermiso.Name = "tbpermiso";
            this.tbpermiso.Size = new System.Drawing.Size(150, 26);
            this.tbpermiso.TabIndex = 11;
            // 
            // tbuser
            // 
            this.tbuser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbuser.Location = new System.Drawing.Point(193, 349);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(150, 26);
            this.tbuser.TabIndex = 12;
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbcontraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontraseña.Location = new System.Drawing.Point(193, 423);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.Size = new System.Drawing.Size(150, 26);
            this.tbcontraseña.TabIndex = 13;
            // 
            // tbsexo
            // 
            this.tbsexo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsexo.Location = new System.Drawing.Point(193, 499);
            this.tbsexo.Name = "tbsexo";
            this.tbsexo.Size = new System.Drawing.Size(150, 26);
            this.tbsexo.TabIndex = 14;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btnvolver.FlatAppearance.BorderSize = 2;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(494, 18);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 35);
            this.btnvolver.TabIndex = 15;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnaddpersonal
            // 
            this.btnaddpersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(184)))), ((int)(((byte)(132)))));
            this.btnaddpersonal.FlatAppearance.BorderSize = 2;
            this.btnaddpersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpersonal.Location = new System.Drawing.Point(421, 499);
            this.btnaddpersonal.Name = "btnaddpersonal";
            this.btnaddpersonal.Size = new System.Drawing.Size(190, 35);
            this.btnaddpersonal.TabIndex = 16;
            this.btnaddpersonal.Text = "Agregar Personal";
            this.btnaddpersonal.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 184);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnaddpersonal);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.tbsexo);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbpermiso);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.labelsexo);
            this.Controls.Add(this.labelclave);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labelpermiso);
            this.Controls.Add(this.labelapellido);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelagregarpersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(634, 561);
            this.MinimumSize = new System.Drawing.Size(634, 561);
            this.Name = "Form9";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelagregarpersonal;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapellido;
        private System.Windows.Forms.Label labelpermiso;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelclave;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbpermiso;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.TextBox tbsexo;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnaddpersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}