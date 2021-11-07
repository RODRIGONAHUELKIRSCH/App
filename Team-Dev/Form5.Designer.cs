
namespace Team_Dev
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btnvolver = new System.Windows.Forms.Button();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lj0SNYIAIMDataSet = new Team_Dev.lj0SNYIAIMDataSet();
            this.facturasTableAdapter = new Team_Dev.lj0SNYIAIMDataSetTableAdapters.facturasTableAdapter();
            this.labelpagos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfechainicio = new System.Windows.Forms.TextBox();
            this.tbfechafin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelinformepagos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idfacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahorafacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idturnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lj0SNYIAIMDataSet1 = new Team_Dev.lj0SNYIAIMDataSet();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbseleccionpago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btnvolver.FlatAppearance.BorderSize = 2;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(523, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 35);
            this.btnvolver.TabIndex = 1;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "facturas";
            this.facturasBindingSource.DataSource = this.lj0SNYIAIMDataSet;
            // 
            // lj0SNYIAIMDataSet
            // 
            this.lj0SNYIAIMDataSet.DataSetName = "lj0SNYIAIMDataSet";
            this.lj0SNYIAIMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // labelpagos
            // 
            this.labelpagos.AutoSize = true;
            this.labelpagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpagos.Location = new System.Drawing.Point(12, 9);
            this.labelpagos.Name = "labelpagos";
            this.labelpagos.Size = new System.Drawing.Size(166, 24);
            this.labelpagos.TabIndex = 3;
            this.labelpagos.Text = "Historial de Pagos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Fin";
            // 
            // tbfechainicio
            // 
            this.tbfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfechainicio.Location = new System.Drawing.Point(3, 518);
            this.tbfechainicio.Name = "tbfechainicio";
            this.tbfechainicio.Size = new System.Drawing.Size(92, 31);
            this.tbfechainicio.TabIndex = 6;
            this.tbfechainicio.TextChanged += new System.EventHandler(this.tbfechainicio_TextChanged);
            // 
            // tbfechafin
            // 
            this.tbfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfechafin.Location = new System.Drawing.Point(101, 517);
            this.tbfechafin.Name = "tbfechafin";
            this.tbfechafin.Size = new System.Drawing.Size(94, 31);
            this.tbfechafin.TabIndex = 7;
            this.tbfechafin.TextChanged += new System.EventHandler(this.tbfechafin_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione Metodo de Pago";
            // 
            // labelinformepagos
            // 
            this.labelinformepagos.AutoSize = true;
            this.labelinformepagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinformepagos.Location = new System.Drawing.Point(518, 492);
            this.labelinformepagos.Name = "labelinformepagos";
            this.labelinformepagos.Size = new System.Drawing.Size(104, 16);
            this.labelinformepagos.TabIndex = 11;
            this.labelinformepagos.Text = "Generar Informe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfacturaDataGridViewTextBoxColumn,
            this.fechahorafacturaDataGridViewTextBoxColumn,
            this.preciototalDataGridViewTextBoxColumn,
            this.idturnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 53);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(628, 420);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(628, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 420);
            this.dataGridView1.TabIndex = 12;
            // 
            // idfacturaDataGridViewTextBoxColumn
            // 
            this.idfacturaDataGridViewTextBoxColumn.DataPropertyName = "id_factura";
            this.idfacturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.idfacturaDataGridViewTextBoxColumn.MinimumWidth = 145;
            this.idfacturaDataGridViewTextBoxColumn.Name = "idfacturaDataGridViewTextBoxColumn";
            this.idfacturaDataGridViewTextBoxColumn.Width = 145;
            // 
            // fechahorafacturaDataGridViewTextBoxColumn
            // 
            this.fechahorafacturaDataGridViewTextBoxColumn.DataPropertyName = "fecha_hora_factura";
            this.fechahorafacturaDataGridViewTextBoxColumn.HeaderText = "f&hFactura";
            this.fechahorafacturaDataGridViewTextBoxColumn.MinimumWidth = 145;
            this.fechahorafacturaDataGridViewTextBoxColumn.Name = "fechahorafacturaDataGridViewTextBoxColumn";
            this.fechahorafacturaDataGridViewTextBoxColumn.Width = 145;
            // 
            // preciototalDataGridViewTextBoxColumn
            // 
            this.preciototalDataGridViewTextBoxColumn.DataPropertyName = "precio_total";
            this.preciototalDataGridViewTextBoxColumn.HeaderText = "Precio Total";
            this.preciototalDataGridViewTextBoxColumn.MinimumWidth = 145;
            this.preciototalDataGridViewTextBoxColumn.Name = "preciototalDataGridViewTextBoxColumn";
            this.preciototalDataGridViewTextBoxColumn.Width = 145;
            // 
            // idturnoDataGridViewTextBoxColumn
            // 
            this.idturnoDataGridViewTextBoxColumn.DataPropertyName = "id_turno";
            this.idturnoDataGridViewTextBoxColumn.HeaderText = "Turno";
            this.idturnoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.idturnoDataGridViewTextBoxColumn.Name = "idturnoDataGridViewTextBoxColumn";
            this.idturnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // lj0SNYIAIMDataSet1
            // 
            this.lj0SNYIAIMDataSet1.DataSetName = "lj0SNYIAIMDataSet";
            this.lj0SNYIAIMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(186)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(388, 515);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbseleccionpago
            // 
            this.cbseleccionpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbseleccionpago.FormattingEnabled = true;
            this.cbseleccionpago.Items.AddRange(new object[] {
            "Credito ",
            "Debito"});
            this.cbseleccionpago.Location = new System.Drawing.Point(201, 521);
            this.cbseleccionpago.Name = "cbseleccionpago";
            this.cbseleccionpago.Size = new System.Drawing.Size(152, 28);
            this.cbseleccionpago.TabIndex = 14;
            this.cbseleccionpago.Text = "Elija una opcion";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.cbseleccionpago);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelinformepagos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbfechafin);
            this.Controls.Add(this.tbfechainicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelpagos);
            this.Controls.Add(this.btnvolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(634, 561);
            this.MinimumSize = new System.Drawing.Size(634, 561);
            this.Name = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvolver;
        private lj0SNYIAIMDataSet lj0SNYIAIMDataSet;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private lj0SNYIAIMDataSetTableAdapters.facturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.Label labelpagos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfechainicio;
        private System.Windows.Forms.TextBox tbfechafin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelinformepagos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private lj0SNYIAIMDataSet lj0SNYIAIMDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahorafacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbseleccionpago;
    }
}