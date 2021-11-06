
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
            this.labelfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfin.Location = new System.Drawing.Point(134, 492);
            this.labelfin.Name = "labelfin";
            this.labelfin.Size = new System.Drawing.Size(75, 20);
            this.labelfin.TabIndex = 4;
            this.labelfin.Text = "Fecha fin";
            // 
            // labelseleccionservicio
            // 
            this.labelseleccionservicio.AutoSize = true;
            this.labelseleccionservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseleccionservicio.Location = new System.Drawing.Point(256, 492);
            this.labelseleccionservicio.Name = "labelseleccionservicio";
            this.labelseleccionservicio.Size = new System.Drawing.Size(150, 20);
            this.labelseleccionservicio.TabIndex = 5;
            this.labelseleccionservicio.Text = "Seleccione Servicio:";
            // 
            // tbinicio
            // 
            this.tbinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbinicio.Location = new System.Drawing.Point(13, 524);
            this.tbinicio.Name = "tbinicio";
            this.tbinicio.Size = new System.Drawing.Size(100, 22);
            this.tbinicio.TabIndex = 6;
            // 
            // tbfin
            // 
            this.tbfin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfin.Location = new System.Drawing.Point(128, 524);
            this.tbfin.Name = "tbfin";
            this.tbfin.Size = new System.Drawing.Size(100, 22);
            this.tbfin.TabIndex = 7;
            this.tbfin.TextChanged += new System.EventHandler(this.tbfin_TextChanged);
            // 
            // cbseleccionservicio
            // 
            this.cbseleccionservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseleccionservicio.FormattingEnabled = true;
            this.cbseleccionservicio.Location = new System.Drawing.Point(256, 522);
            this.cbseleccionservicio.Name = "cbseleccionservicio";
            this.cbseleccionservicio.Size = new System.Drawing.Size(150, 24);
            this.cbseleccionservicio.TabIndex = 8;
            this.cbseleccionservicio.SelectedIndexChanged += new System.EventHandler(this.cbseleccionservicio_SelectedIndexChanged);
            // 
            // labelinicio
            // 
            this.labelinicio.AutoSize = true;
            this.labelinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinicio.Location = new System.Drawing.Point(10, 492);
            this.labelinicio.Name = "labelinicio";
            this.labelinicio.Size = new System.Drawing.Size(93, 20);
            this.labelinicio.TabIndex = 9;
            this.labelinicio.Text = "Fecha inicio";
            // 
            // labelinforme
            // 
            this.labelinforme.AutoSize = true;
            this.labelinforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinforme.Location = new System.Drawing.Point(457, 492);
            this.labelinforme.Name = "labelinforme";
            this.labelinforme.Size = new System.Drawing.Size(131, 20);
            this.labelinforme.TabIndex = 10;
            this.labelinforme.Text = "Generar Informe:";
            this.labelinforme.Click += new System.EventHandler(this.labelinforme_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
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
    }
}