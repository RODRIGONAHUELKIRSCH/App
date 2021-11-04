namespace Team_Dev
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panelvemenu = new System.Windows.Forms.Panel();
            this.btnveuserlogged = new System.Windows.Forms.Button();
            this.panelvesubmenu = new System.Windows.Forms.Panel();
            this.btnturnosempleados = new System.Windows.Forms.Button();
            this.btnveclientes = new System.Windows.Forms.Button();
            this.btnmenuempleado = new System.Windows.Forms.Button();
            this.panelvistaempleados = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelvemenu.SuspendLayout();
            this.panelvesubmenu.SuspendLayout();
            this.panelvistaempleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelvemenu
            // 
            this.panelvemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.panelvemenu.Controls.Add(this.btnveuserlogged);
            this.panelvemenu.Controls.Add(this.panelvesubmenu);
            this.panelvemenu.Controls.Add(this.btnmenuempleado);
            this.panelvemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelvemenu.Location = new System.Drawing.Point(0, 0);
            this.panelvemenu.Name = "panelvemenu";
            this.panelvemenu.Size = new System.Drawing.Size(250, 561);
            this.panelvemenu.TabIndex = 0;
            this.panelvemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvemenu_Paint);
            // 
            // btnveuserlogged
            // 
            this.btnveuserlogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.btnveuserlogged.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnveuserlogged.FlatAppearance.BorderSize = 0;
            this.btnveuserlogged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnveuserlogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveuserlogged.Image = ((System.Drawing.Image)(resources.GetObject("btnveuserlogged.Image")));
            this.btnveuserlogged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveuserlogged.Location = new System.Drawing.Point(0, 516);
            this.btnveuserlogged.Name = "btnveuserlogged";
            this.btnveuserlogged.Size = new System.Drawing.Size(250, 45);
            this.btnveuserlogged.TabIndex = 2;
            this.btnveuserlogged.Text = "Empleado";
            this.btnveuserlogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveuserlogged.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnveuserlogged.UseVisualStyleBackColor = false;
            // 
            // panelvesubmenu
            // 
            this.panelvesubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(207)))), ((int)(((byte)(117)))));
            this.panelvesubmenu.Controls.Add(this.btnturnosempleados);
            this.panelvesubmenu.Controls.Add(this.btnveclientes);
            this.panelvesubmenu.Location = new System.Drawing.Point(0, 42);
            this.panelvesubmenu.Name = "panelvesubmenu";
            this.panelvesubmenu.Size = new System.Drawing.Size(250, 350);
            this.panelvesubmenu.TabIndex = 1;
            this.panelvesubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvesubmenu_Paint);
            // 
            // btnturnosempleados
            // 
            this.btnturnosempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnturnosempleados.FlatAppearance.BorderSize = 0;
            this.btnturnosempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnturnosempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnturnosempleados.Image = ((System.Drawing.Image)(resources.GetObject("btnturnosempleados.Image")));
            this.btnturnosempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnturnosempleados.Location = new System.Drawing.Point(0, 40);
            this.btnturnosempleados.Name = "btnturnosempleados";
            this.btnturnosempleados.Size = new System.Drawing.Size(250, 40);
            this.btnturnosempleados.TabIndex = 2;
            this.btnturnosempleados.Text = "Turnos";
            this.btnturnosempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnturnosempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnturnosempleados.UseVisualStyleBackColor = true;
            this.btnturnosempleados.Click += new System.EventHandler(this.btnturnosempleados_Click);
            // 
            // btnveclientes
            // 
            this.btnveclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnveclientes.FlatAppearance.BorderSize = 0;
            this.btnveclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnveclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnveclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnveclientes.Image")));
            this.btnveclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveclientes.Location = new System.Drawing.Point(0, 0);
            this.btnveclientes.Name = "btnveclientes";
            this.btnveclientes.Size = new System.Drawing.Size(250, 40);
            this.btnveclientes.TabIndex = 0;
            this.btnveclientes.Text = "Lista Clientes";
            this.btnveclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnveclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnveclientes.UseVisualStyleBackColor = true;
            this.btnveclientes.Click += new System.EventHandler(this.btnveclientes_Click);
            // 
            // btnmenuempleado
            // 
            this.btnmenuempleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenuempleado.FlatAppearance.BorderSize = 0;
            this.btnmenuempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmenuempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenuempleado.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuempleado.Image")));
            this.btnmenuempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuempleado.Location = new System.Drawing.Point(0, 0);
            this.btnmenuempleado.Name = "btnmenuempleado";
            this.btnmenuempleado.Size = new System.Drawing.Size(250, 45);
            this.btnmenuempleado.TabIndex = 0;
            this.btnmenuempleado.Text = "Menu";
            this.btnmenuempleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmenuempleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmenuempleado.UseVisualStyleBackColor = true;
            this.btnmenuempleado.Click += new System.EventHandler(this.btnmenuempleado_Click);
            // 
            // panelvistaempleados
            // 
            this.panelvistaempleados.Controls.Add(this.pictureBox1);
            this.panelvistaempleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvistaempleados.Location = new System.Drawing.Point(250, 0);
            this.panelvistaempleados.Name = "panelvistaempleados";
            this.panelvistaempleados.Size = new System.Drawing.Size(634, 561);
            this.panelvistaempleados.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelvistaempleados);
            this.Controls.Add(this.panelvemenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form3";
            this.Text = "Empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelvemenu.ResumeLayout(false);
            this.panelvesubmenu.ResumeLayout(false);
            this.panelvistaempleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelvemenu;
        private System.Windows.Forms.Button btnveuserlogged;
        private System.Windows.Forms.Panel panelvesubmenu;
        private System.Windows.Forms.Button btnveclientes;
        private System.Windows.Forms.Button btnmenuempleado;
        private System.Windows.Forms.Button btnturnosempleados;
        private System.Windows.Forms.Panel panelvistaempleados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}