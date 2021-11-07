using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Dev
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private string fechainicio;
        private string fechafin;
        private string t_pago;
        DateTime f_fin = new DateTime();
        DateTime f_inicio = new DateTime();

        private void tbfin_TextChanged(object sender, EventArgs e)
        {
            
            tbfin.Text = fechafin;

            try
            {
                f_fin = DateTime.Parse(fechafin);
                f_fin.ToString("yyyy/mm/dd");
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbseleccionservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbseleccionservicio.Items.Add();
        }

        private void labelinforme_Click(object sender, EventArgs e)
        {
            btnpdf.Focus();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El formato de la para la busqueda de turnos por fechas es: yyyy/mm/dd", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conectar();
            consultaClientes(dataGridView1);
        }
        MySqlConnection connection = new MySqlConnection("server=remotemysql.com;user id=lj0SNYIAIM;password=sWxLgSU8ej;persistsecurityinfo=True;database=lj0SNYIAIM");
        private void conectar()
        {
            try
            {

                connection.Open();

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database error");
            }
        }
        private void consultaClientes(DataGridView d1)
        {

            MySqlCommand comando = new MySqlCommand("select fecha_hora_turno,id_turno,servicios.nombre, servicios.precio  from turnos inner join servicios on turnos.id_servicio=servicios.id_servicio;", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaclientes = new DataTable();
            adaptador.Fill(tablaclientes);
            d1.DataSource = tablaclientes;


        }

        private void tbinicio_TextChanged(object sender, EventArgs e)
        {
            
            tbinicio.Text = fechainicio;

            try
            {
                f_inicio = DateTime.Parse(fechainicio);
                f_inicio.ToString("yyyy/mm/dd");
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void consultaBusquedaTurnos(DataGridView d1)
        {
            if(f_inicio!=null && f_fin!=null&& cbseleccionservicio.SelectedText != null)
            {
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                string sqlcommand = "select * from turnos where fecha_hora_turno between " + f_inicio + "and" + f_fin + " and " + cbseleccionservicio.SelectedText + ";";
                MySqlCommand comando = new MySqlCommand(sqlcommand, connection);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tablaclientes = new DataTable();
                adaptador.Fill(tablaclientes);
                d1.DataSource = tablaclientes;
                MySqlDataReader reader = comando.ExecuteReader();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Hay campos sin completar", "Busqueda Turnos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
         

        }
        private void Pdf()
        {
            if (tbinicio != null && tbfin != null && cbseleccionservicio.SelectedText != null)
            {
                MessageBox.Show("Hay campos sin completar", "Informe Pdf", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PdfWriter pdfWriter = new PdfWriter("Document.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documentfactura = new Document(pdf, PageSize.LETTER);
            documentfactura.SetMargins(60, 20, 55, 20);
            //var parrafo = new Paragraph();
            //document.Add(parrafo)
            PdfFont fontcolumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            PdfFont contenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            DataTable pdfdata = new DataTable();
            string[] columnas = { "id_turno", "id_usuario", "id_servicio","fecha_hora_turno" };
            float[] tamanio = { 2, 4, 2, 2, 4 };
            Table tablapdf = new Table(UnitValue.CreatePercentArray(tamanio));
            tablapdf.SetWidth(UnitValue.CreatePercentValue(100));
            foreach (string columna in columnas)
            {
                tablapdf.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontcolumnas)));
            }

            //string consulta = "select * from facturas where fecha_hora_factura  between " +f_inicio +" and "+f_fin+" ;";
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sqlcommand = "select * from turnos where fecha_hora_turno between " + f_inicio + "and" + f_fin + "and " + cbseleccionservicio.SelectedText + ";";
            MySqlCommand comando = new MySqlCommand(sqlcommand, connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaclientes = new DataTable();
            adaptador.Fill(tablaclientes);
            dataGridView1.DataSource = tablaclientes;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["id_turno"].ToString()).SetFont(contenido)));
                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["id_usuario"].ToString()).SetFont(contenido)));
                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["id_servicio"].ToString()).SetFont(contenido)));
                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["fecha_hora_turno"].ToString()).SetFont(contenido)));

            }

            consultaBusquedaTurnos(dataGridView1);
            documentfactura.Add(tablapdf);
            pdfdata.DataSet.Tables.Add();


            connection.Close();
            documentfactura.Close();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            Pdf();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            t_pago = cbseleccionservicio.SelectedText;

            if (f_inicio != null && f_fin != null && t_pago != null)
            {
                try
                {
                    conectar();
                    consultaBusquedaTurnos(dataGridView1);

                }
                catch (Exception)
                {
                    MessageBox.Show("Command Error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void labelfin_Click(object sender, EventArgs e)
        {
            tbfin.Focus();
        }

        private void labelinicio_Click(object sender, EventArgs e)
        {
            tbinicio.Focus();
        }

        private void labelseleccionservicio_Click(object sender, EventArgs e)
        {
            cbseleccionservicio.Focus();
        }
    }
}