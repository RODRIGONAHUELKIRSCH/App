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
            
        }

        
        private void tbfechafin_TextChanged(object sender, EventArgs e)
        {
            tbfechafin.Text = fechafin;
            
            try
            {
                f_fin = DateTime.Parse(fechafin);
            }
            catch (Exception)
            {
                MessageBox.Show("Database error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void tbfechainicio_TextChanged(object sender, EventArgs e)
        {

            tbfechainicio.Text = fechainicio;
            
            try
            {
                f_inicio = DateTime.Parse(fechainicio);
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
    }
}
