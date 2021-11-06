
namespace Team_Dev
{
    partial class Form6
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.labelclientes = new System.Windows.Forms.Label();
            this.lj0SNYIAIMDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lj0SNYIAIMDataSet1 = new Team_Dev.lj0SNYIAIMDataSet1();
            this.clientesibfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Team_Dev.lj0SNYIAIMDataSet1TableAdapters.clientesTableAdapter();
            this.sexosTableAdapter = new Team_Dev.lj0SNYIAIMDataSet1TableAdapters.sexosTableAdapter();
            this.lj0SNYIAIMDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sexosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sexosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesibfk1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(204)))), ((int)(((byte)(132)))));
            this.btnvolver.FlatAppearance.BorderSize = 2;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(522, 13);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 36);
            this.btnvolver.TabIndex = 1;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // labelclientes
            // 
            this.labelclientes.AutoSize = true;
            this.labelclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclientes.Location = new System.Drawing.Point(12, 13);
            this.labelclientes.Name = "labelclientes";
            this.labelclientes.Size = new System.Drawing.Size(217, 37);
            this.labelclientes.TabIndex = 3;
            this.labelclientes.Text = "Lista Clientes:";
            // 
            // lj0SNYIAIMDataSet1BindingSource1
            // 
            this.lj0SNYIAIMDataSet1BindingSource1.DataSource = this.lj0SNYIAIMDataSet1;
            this.lj0SNYIAIMDataSet1BindingSource1.Position = 0;
            // 
            // lj0SNYIAIMDataSet1
            // 
            this.lj0SNYIAIMDataSet1.DataSetName = "lj0SNYIAIMDataSet1";
            this.lj0SNYIAIMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesibfk1BindingSource
            // 
            this.clientesibfk1BindingSource.DataMember = "clientes_ibfk_1";
            this.clientesibfk1BindingSource.DataSource = this.sexosBindingSource;
            // 
            // sexosBindingSource
            // 
            this.sexosBindingSource.DataMember = "sexos";
            this.sexosBindingSource.DataSource = this.lj0SNYIAIMDataSet1;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // sexosTableAdapter
            // 
            this.sexosTableAdapter.ClearBeforeFill = true;
            // 
            // lj0SNYIAIMDataSet1BindingSource
            // 
            this.lj0SNYIAIMDataSet1BindingSource.DataSource = this.lj0SNYIAIMDataSet1;
            this.lj0SNYIAIMDataSet1BindingSource.Position = 0;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.lj0SNYIAIMDataSet1BindingSource;
            // 
            // sexosBindingSource1
            // 
            this.sexosBindingSource1.DataMember = "sexos";
            this.sexosBindingSource1.DataSource = this.lj0SNYIAIMDataSet1BindingSource;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.lj0SNYIAIMDataSet1BindingSource1;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "clientes";
            this.clientesBindingSource2.DataSource = this.lj0SNYIAIMDataSet1BindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 79);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(628, 480);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(628, 480);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 480);
            this.dataGridView1.TabIndex = 4;
            // 
            // sexosBindingSource2
            // 
            this.sexosBindingSource2.DataMember = "sexos";
            this.sexosBindingSource2.DataSource = this.lj0SNYIAIMDataSet1BindingSource1;
            // 
            // sexosBindingSource3
            // 
            this.sexosBindingSource3.DataMember = "sexos";
            this.sexosBindingSource3.DataSource = this.lj0SNYIAIMDataSet1BindingSource1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(224)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelclientes);
            this.Controls.Add(this.btnvolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(634, 561);
            this.MinimumSize = new System.Drawing.Size(634, 561);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesibfk1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lj0SNYIAIMDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexosBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label labelclientes;
        private lj0SNYIAIMDataSet1 lj0SNYIAIMDataSet1;
        private lj0SNYIAIMDataSet1TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource sexosBindingSource;
        private lj0SNYIAIMDataSet1TableAdapters.sexosTableAdapter sexosTableAdapter;
        private System.Windows.Forms.BindingSource lj0SNYIAIMDataSet1BindingSource;
        private System.Windows.Forms.BindingSource clientesibfk1BindingSource;
        private System.Windows.Forms.BindingSource lj0SNYIAIMDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource sexosBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sexosBindingSource2;
        private System.Windows.Forms.BindingSource sexosBindingSource3;
    }
}