﻿
namespace Team_Dev
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.labelturnos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvolver = new System.Windows.Forms.Button();
            this.labelfin = new System.Windows.Forms.Label();
            this.labelseleccionservicio = new System.Windows.Forms.Label();
            this.tbinicio = new System.Windows.Forms.TextBox();
            this.tbfin = new System.Windows.Forms.TextBox();
            this.cbseleccionservicio = new System.Windows.Forms.ComboBox();
            this.labelinicio = new System.Windows.Forms.Label();
            this.labelinforme = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnpdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelturnos
            // 
            this.labelturnos.AutoSize = true;
            this.labelturnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelturnos.Location = new System.Drawing.Point(13, 13);
            this.labelturnos.Name = "labelturnos";
            this.labelturnos.Size = new System.Drawing.Size(75, 24);
            this.labelturnos.TabIndex = 0;
            this.labelturnos.Text = "Turnos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(628, 420);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(628, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btnvolver.FlatAppearance.BorderSize = 2;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(522, 10);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 35);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // labelfin
            // 
            this.labelfin.AutoSize = true;
            this.labelfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfin.Location = new System.Drawing.Point(119, 492);
            this.labelfin.Name = "labelfin";
            this.labelfin.Size = new System.Drawing.Size(67, 16);
            this.labelfin.TabIndex = 4;
            this.labelfin.Text = "Fecha Fin";
            this.labelfin.Click += new System.EventHandler(this.labelfin_Click);
            // 
            // labelseleccionservicio
            // 
            this.labelseleccionservicio.AutoSize = true;
            this.labelseleccionservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseleccionservicio.Location = new System.Drawing.Point(224, 492);
            this.labelseleccionservicio.Name = "labelseleccionservicio";
            this.labelseleccionservicio.Size = new System.Drawing.Size(131, 16);
            this.labelseleccionservicio.TabIndex = 5;
            this.labelseleccionservicio.Text = "Seleccione Servicio:";
            this.labelseleccionservicio.Click += new System.EventHandler(this.labelseleccionservicio_Click);
            // 
            // tbinicio
            // 
            this.tbinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbinicio.Location = new System.Drawing.Point(3, 524);
            this.tbinicio.Name = "tbinicio";
            this.tbinicio.Size = new System.Drawing.Size(100, 22);
            this.tbinicio.TabIndex = 6;
            this.tbinicio.TextChanged += new System.EventHandler(this.tbinicio_TextChanged);
            // 
            // tbfin
            // 
            this.tbfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfin.Location = new System.Drawing.Point(109, 524);
            this.tbfin.Name = "tbfin";
            this.tbfin.Size = new System.Drawing.Size(100, 22);
            this.tbfin.TabIndex = 7;
            this.tbfin.TextChanged += new System.EventHandler(this.tbfin_TextChanged);
            // 
            // cbseleccionservicio
            // 
            this.cbseleccionservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseleccionservicio.FormattingEnabled = true;
            this.cbseleccionservicio.Location = new System.Drawing.Point(215, 522);
            this.cbseleccionservicio.Name = "cbseleccionservicio";
            this.cbseleccionservicio.Size = new System.Drawing.Size(150, 24);
            this.cbseleccionservicio.TabIndex = 8;
            this.cbseleccionservicio.SelectedIndexChanged += new System.EventHandler(this.cbseleccionservicio_SelectedIndexChanged);
            // 
            // labelinicio
            // 
            this.labelinicio.AutoSize = true;
            this.labelinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinicio.Location = new System.Drawing.Point(-1, 492);
            this.labelinicio.Name = "labelinicio";
            this.labelinicio.Size = new System.Drawing.Size(80, 16);
            this.labelinicio.TabIndex = 9;
            this.labelinicio.Text = "Fecha Inicio";
            this.labelinicio.Click += new System.EventHandler(this.labelinicio_Click);
            // 
            // labelinforme
            // 
            this.labelinforme.AutoSize = true;
            this.labelinforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinforme.Location = new System.Drawing.Point(515, 492);
            this.labelinforme.Name = "labelinforme";
            this.labelinforme.Size = new System.Drawing.Size(107, 16);
            this.labelinforme.TabIndex = 10;
            this.labelinforme.Text = "Generar Informe:";
            this.labelinforme.Click += new System.EventHandler(this.labelinforme_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(186)))), ((int)(((byte)(78)))));
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(397, 513);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(103, 32);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnpdf
            // 
            this.btnpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(182)))), ((int)(((byte)(112)))));
            this.btnpdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnpdf.Image")));
            this.btnpdf.Location = new System.Drawing.Point(541, 511);
            this.btnpdf.Name = "btnpdf";
            this.btnpdf.Size = new System.Drawing.Size(57, 35);
            this.btnpdf.TabIndex = 12;
            this.btnpdf.UseVisualStyleBackColor = false;
            this.btnpdf.Click += new System.EventHandler(this.btnpdf_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.btnpdf);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.labelinforme);
            this.Controls.Add(this.labelinicio);
            this.Controls.Add(this.cbseleccionservicio);
            this.Controls.Add(this.tbfin);
            this.Controls.Add(this.tbinicio);
            this.Controls.Add(this.labelseleccionservicio);
            this.Controls.Add(this.labelfin);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelturnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(634, 561);
            this.MinimumSize = new System.Drawing.Size(634, 561);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelturnos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label labelfin;
        private System.Windows.Forms.Label labelseleccionservicio;
        private System.Windows.Forms.TextBox tbinicio;
        private System.Windows.Forms.TextBox tbfin;
        private System.Windows.Forms.ComboBox cbseleccionservicio;
        private System.Windows.Forms.Label labelinicio;
        private System.Windows.Forms.Label labelinforme;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnpdf;
    }
}