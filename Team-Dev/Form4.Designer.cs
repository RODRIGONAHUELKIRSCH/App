namespace Team_Dev
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panelvsmenu = new System.Windows.Forms.Panel();
            this.btnvsuserlogged = new System.Windows.Forms.Button();
            this.panelvssubmenu = new System.Windows.Forms.Panel();
            this.btnvspagos = new System.Windows.Forms.Button();
            this.btnvsmenu = new System.Windows.Forms.Button();
            this.panelvistasecretaria = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelvsmenu.SuspendLayout();
            this.panelvssubmenu.SuspendLayout();
            this.panelvistasecretaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelvsmenu
            // 
            this.panelvsmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(157)))), ((int)(((byte)(78)))));
            this.panelvsmenu.Controls.Add(this.btnvsuserlogged);
            this.panelvsmenu.Controls.Add(this.panelvssubmenu);
            this.panelvsmenu.Controls.Add(this.btnvsmenu);
            this.panelvsmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelvsmenu.Location = new System.Drawing.Point(0, 0);
            this.panelvsmenu.Name = "panelvsmenu";
            this.panelvsmenu.Size = new System.Drawing.Size(250, 561);
            this.panelvsmenu.TabIndex = 0;
            // 
            // btnvsuserlogged
            // 
            this.btnvsuserlogged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(157)))), ((int)(((byte)(97)))));
            this.btnvsuserlogged.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnvsuserlogged.FlatAppearance.BorderSize = 0;
            this.btnvsuserlogged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvsuserlogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvsuserlogged.Image = ((System.Drawing.Image)(resources.GetObject("btnvsuserlogged.Image")));
            this.btnvsuserlogged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvsuserlogged.Location = new System.Drawing.Point(0, 516);
            this.btnvsuserlogged.Name = "btnvsuserlogged";
            this.btnvsuserlogged.Size = new System.Drawing.Size(250, 45);
            this.btnvsuserlogged.TabIndex = 2;
            this.btnvsuserlogged.Text = "Secretaria";
            this.btnvsuserlogged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvsuserlogged.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvsuserlogged.UseVisualStyleBackColor = false;
            // 
            // panelvssubmenu
            // 
            this.panelvssubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(207)))), ((int)(((byte)(117)))));
            this.panelvssubmenu.Controls.Add(this.btnvspagos);
            this.panelvssubmenu.Location = new System.Drawing.Point(0, 41);
            this.panelvssubmenu.Name = "panelvssubmenu";
            this.panelvssubmenu.Size = new System.Drawing.Size(250, 350);
            this.panelvssubmenu.TabIndex = 1;
            this.panelvssubmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelvssubmenu_Paint);
            // 
            // btnvspagos
            // 
            this.btnvspagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvspagos.FlatAppearance.BorderSize = 0;
            this.btnvspagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvspagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvspagos.Image = ((System.Drawing.Image)(resources.GetObject("btnvspagos.Image")));
            this.btnvspagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvspagos.Location = new System.Drawing.Point(0, 0);
            this.btnvspagos.Name = "btnvspagos";
            this.btnvspagos.Size = new System.Drawing.Size(250, 40);
            this.btnvspagos.TabIndex = 0;
            this.btnvspagos.Text = "Historial Pagos";
            this.btnvspagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvspagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvspagos.UseVisualStyleBackColor = true;
            this.btnvspagos.Click += new System.EventHandler(this.btnvspagos_Click);
            // 
            // btnvsmenu
            // 
            this.btnvsmenu.AllowDrop = true;
            this.btnvsmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvsmenu.FlatAppearance.BorderSize = 0;
            this.btnvsmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvsmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvsmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnvsmenu.Image")));
            this.btnvsmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvsmenu.Location = new System.Drawing.Point(0, 0);
            this.btnvsmenu.Name = "btnvsmenu";
            this.btnvsmenu.Size = new System.Drawing.Size(250, 45);
            this.btnvsmenu.TabIndex = 0;
            this.btnvsmenu.Text = "Menu";
            this.btnvsmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvsmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvsmenu.UseVisualStyleBackColor = true;
            this.btnvsmenu.Click += new System.EventHandler(this.btnvsmenu_Click);
            // 
            // panelvistasecretaria
            // 
            this.panelvistasecretaria.Controls.Add(this.pictureBox1);
            this.panelvistasecretaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelvistasecretaria.Location = new System.Drawing.Point(250, 0);
            this.panelvistasecretaria.Name = "panelvistasecretaria";
            this.panelvistasecretaria.Size = new System.Drawing.Size(634, 561);
            this.panelvistasecretaria.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelvistasecretaria);
            this.Controls.Add(this.panelvsmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form4";
            this.Text = "Secretaria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelvsmenu.ResumeLayout(false);
            this.panelvssubmenu.ResumeLayout(false);
            this.panelvistasecretaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelvsmenu;
        private System.Windows.Forms.Button btnvsuserlogged;
        private System.Windows.Forms.Panel panelvssubmenu;
        private System.Windows.Forms.Button btnvspagos;
        private System.Windows.Forms.Button btnvsmenu;
        private System.Windows.Forms.Panel panelvistasecretaria;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}