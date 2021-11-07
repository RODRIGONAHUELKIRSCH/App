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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private string fechainicio;
        private string fechafin;
        private string t_pago;
        DateTime f_fin = new DateTime();
        DateTime f_inicio = new DateTime();
        
        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cbseleccionpago.Text = "Elija una opcion";

            MessageBox.Show("El formato de la para la busqueda de facturas por fechas es: yyyy/mm/dd","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        
        private void tbfechafin_TextChanged(object sender, EventArgs e)
        {
            
            tbfechainicio.Text = fechafin;

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

      

        private void label1_Click(object sender, EventArgs e)
        {
            tbfechainicio.Focus();
        }
        
        private void tbfechainicio_TextChanged(object sender, EventArgs e)
        {
            
            tbfechainicio.Text = fechainicio;
            
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
        private void IntervaloFechasFactura()
        {

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
                MessageBox.Show("Database error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void consultaBusquedaFacturas(DataGridView d1)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sqlcommand= "select * from facturas where fecha_hora_factura between " + f_inicio +"and" + f_fin+";"; 
            MySqlCommand comando = new MySqlCommand(sqlcommand, connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaclientes = new DataTable();
            adaptador.Fill(tablaclientes);
            d1.DataSource = tablaclientes;
            MySqlDataReader reader = comando.ExecuteReader();
            connection.Close();



        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            t_pago = cbseleccionpago.SelectedText;

            if (f_inicio != null && f_fin != null && t_pago!=null)
            {
                try
                {
                    conectar();
                    consultaBusquedaFacturas(dataGridView1);

                }
                catch (Exception)
                {
                    MessageBox.Show("Command Error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
            Pdf();
        }
        private void Pdf()
        {
            if (tbfechainicio != null && tbfechafin != null && cbseleccionpago.SelectedText!=null)
            {
                MessageBox.Show("Hay campos sin completar", "Informe Pdf", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            PdfWriter pdfWriter = new PdfWriter("Document.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documentfactura = new Document(pdf,PageSize.LETTER);
            documentfactura.SetMargins(60,20,55,20);
            //var parrafo = new Paragraph();
            //document.Add(parrafo)
            PdfFont fontcolumnas = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            PdfFont contenido = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN);
            DataTable pdfdata = new DataTable();
            string[] columnas = { "id_factura", "id_turno", "fecha_hora_factura" };
            float[] tamanio = { 2, 4, 2, 2, 4 };
            Table tablapdf = new Table(UnitValue.CreatePercentArray(tamanio));
            tablapdf.SetWidth(UnitValue.CreatePercentValue(100));
            foreach(string columna in columnas)
            {
                tablapdf.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontcolumnas)));
            }

            //string consulta = "select * from facturas where fecha_hora_factura  between " +f_inicio +" and "+f_fin+" ;";
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sqlcommand = "select * from facturas where fecha_hora_factura between " + f_inicio + "and" + f_fin +"and "+cbseleccionpago.SelectedText+ ";";
            MySqlCommand comando = new MySqlCommand(sqlcommand, connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaclientes = new DataTable();
            adaptador.Fill(tablaclientes);
            dataGridView1.DataSource = tablaclientes;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {

                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["id_factura"].ToString()).SetFont(contenido)));
                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["id_turno"].ToString()).SetFont(contenido)));
                tablapdf.AddCell(new Cell().Add(new Paragraph(reader["fecha_hora_factura"].ToString()).SetFont(contenido)));
                
            }

            consultaBusquedaFacturas(dataGridView1);
            documentfactura.Add(tablapdf);
            pdfdata.DataSet.Tables.Add();


            connection.Close();
            documentfactura.Close();
        }

        private void cbseleccionpago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelinformepagos_Click(object sender, EventArgs e)
        {
            btnpdf.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbfechafin.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cbseleccionpago.Focus();
        }
    }
}