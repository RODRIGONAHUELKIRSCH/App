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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
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

            MySqlCommand comando = new MySqlCommand("select id_profesional,profesionales.nombre,apellido,permiso,usuario,clave, sexos.nombre from profesionales inner join sexos on profesionales.id_sexo=sexos.id_sexo;", connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tablaclientes = new DataTable();
            adaptador.Fill(tablaclientes);
            d1.DataSource = tablaclientes;

            
        }
    }
}
