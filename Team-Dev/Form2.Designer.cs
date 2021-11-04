namespace Team_Dev
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.buttonmenu = new System.Windows.Forms.Button();
            this.btnuserlogged = new System.Windows.Forms.Button();
            this.panelsubmenu = new System.Windows.Forms.Panel();
            this.btnpersonal = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnpagos = new System.Windows.Forms.Button();
            this.panelcontenedorVistaAdministrador = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnaddpersonal = new System.Windows.Forms.Button();
            this.panelmenu.SuspendLayout();
            this.panelsubmenu.SuspendLayout();
            this.panelcontenedorVistaAdministrador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(167)))), ((int)(((byte)(78)))));
            this.panelmenu.Controls.Add(this.buttonmenu);
            this.panelmenu.Controls.Add(this.btnuserlogged);
            this.panelmenu.Controls.Add(this.panelsubmenu);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 561);
            this.panelmenu.TabIndex = 0;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // buttonmenu
            // 
            this.buttonmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonmenu.FlatAppearance.BorderSize = 0;
            this.buttonmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonmenu.Image")));
            this.buttonmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmenu.Location = new System.Drawing.Point(0, 0);
            this.buttonmenu.Name = "buttonmenu";
            this.buttonmenu.Size = new System.Drawing.Size(250, 45);
            this.buttonmenu.TabIndex = 0;
            this.buttonmenu.Text = "Menu";
            this.buttonmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonmenu.UseVisualStyleBackColor = true;
            this.buttonmenu.Click += new System.EventHandler(this.buttonmenu_Click);
            // 
            // btnuserlogged
            // 
            this.btnuserlogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.btnuserlogged.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnuserlogged.FlatAppearance.BorderSize = 0;
            this.btnuserlogged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuserlogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserlogged.Image = ((System.Drawing.Image)(resources.GetObject("btnuserlogged.Image")));
            this.btnuserlogged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuserlogged.Location = new System.Drawing.Point(0, 516);
            this.btnuserlogged.Name = "btnuserlogged";
            this.btnuserlogged.Size = new System.Drawing.Size(250, 45);
            this.btnuserlogged.TabIndex = 2;
            this.btnuserlogged.Text = "Dra. Feliz";
            this.btnuserlogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuserlogged.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuserlogged.UseVisualStyleBackColor = false;
            // 
            // panelsubmenu
            // 
            this.panelsubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(207)))), ((int)(((byte)(117)))));
            this.panelsubmenu.Controls.Add(this.btnaddpersonal);
            this.panelsubmenu.Controls.Add(this.btnTurnos);
            this.panelsubmenu.Controls.Add(this.btnpersonal);
            this.panelsubmenu.Controls.Add(this.btnclientes);
            this.panelsubmenu.Controls.Add(this.btnpagos);
            this.panelsubmenu.Location = new System.Drawing.Point(0, 43);
            this.panelsubmenu.MaximumSize = new System.Drawing.Size(250, 350);
            this.panelsubmenu.MinimumSize = new System.Drawing.Size(250, 350);
            this.panelsubmenu.Name = "panelsubmenu";
            this.panelsubmenu.Size = new System.Drawing.Size(250, 350);
            this.panelsubmenu.TabIndex = 1;
            this.panelsubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsubmenu_Paint);
            // 
            // btnpersonal
            // 
            this.btnpersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpersonal.FlatAppearance.BorderSize = 0;
            this.btnpersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnpersonal.Image")));
            this.btnpersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpersonal.Location = new System.Drawing.Point(0, 80);
            this.btnpersonal.Name = "btnpersonal";
            this.btnpersonal.Size = new System.Drawing.Size(250, 40);
            this.btnpersonal.TabIndex = 2;
            this.btnpersonal.Text = "Personal Spa";
            this.btnpersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpersonal.UseVisualStyleBackColor = true;
            this.btnpersonal.Click += new System.EventHandler(this.btnpersonal_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(0, 40);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(250, 40);
            this.btnclientes.TabIndex = 1;
            this.btnclientes.Text = "Lista Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnpagos
            // 
            this.btnpagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpagos.FlatAppearance.BorderSize = 0;
            this.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagos.Image = ((System.Drawing.Image)(resources.GetObject("btnpagos.Image")));
            this.btnpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.Location = new System.Drawing.Point(0, 0);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(250, 40);
            this.btnpagos.TabIndex = 0;
            this.btnpagos.Text = "Historial Pagos";
            this.btnpagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpagos.UseVisualStyleBackColor = true;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // panelcontenedorVistaAdministrador
            // 
            this.panelcontenedorVistaAdministrador.BackColor = System.Drawing.Color.Cyan;
            this.panelcontenedorVistaAdministrador.Controls.Add(this.pictureBox1);
            this.panelcontenedorVistaAdministrador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedorVistaAdministrador.Location = new System.Drawing.Point(250, 0);
            this.panelcontenedorVistaAdministrador.MaximumSize = new System.Drawing.Size(634, 561);
            this.panelcontenedorVistaAdministrador.MinimumSize = new System.Drawing.Size(634, 561);
            this.panelcontenedorVistaAdministrador.Name = "panelcontenedorVistaAdministrador";
            this.panelcontenedorVistaAdministrador.Size = new System.Drawing.Size(634, 561);
            this.panelcontenedorVistaAdministrador.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTurnos
            // 
            this.btnTurnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnos.Image = ((System.Drawing.Image)(resources.GetObject("btnTurnos.Image")));
            this.btnTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnos.Location = new System.Drawing.Point(0, 120);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Size = new System.Drawing.Size(250, 40);
            this.btnTurnos.TabIndex = 3;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTurnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurnos.UseVisualStyleBackColor = true;
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnaddpersonal
            // 
            this.btnaddpersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaddpersonal.FlatAppearance.BorderSize = 0;
            this.btnaddpersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddpersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnaddpersonal.Image")));
            this.btnaddpersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddpersonal.Location = new System.Drawing.Point(0, 160);
            this.btnaddpersonal.Name = "btnaddpersonal";
            this.btnaddpersonal.Size = new System.Drawing.Size(250, 40);
            this.btnaddpersonal.TabIndex = 4;
            this.btnaddpersonal.Text = "Agregar Personal";
            this.btnaddpersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddpersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaddpersonal.UseVisualStyleBackColor = true;
            this.btnaddpersonal.Click += new System.EventHandler(this.btnaddpersonal_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelcontenedorVistaAdministrador);
            this.Controls.Add(this.panelmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form2";
            this.Text = "Administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panelmenu.ResumeLayout(false);
            this.panelsubmenu.ResumeLayout(false);
            this.panelcontenedorVistaAdministrador.ResumeLayout(false);
            this.panelcontenedorVistaAdministrador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelsubmenu;
        private System.Windows.Forms.Button btnuserlogged;
        private System.Windows.Forms.Button btnpersonal;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnpagos;
        private System.Windows.Forms.Button buttonmenu;
        private System.Windows.Forms.Panel panelcontenedorVistaAdministrador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnaddpersonal;
        private System.Windows.Forms.Button btnTurnos;
    }
}