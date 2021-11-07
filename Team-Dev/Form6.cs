using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Team_Dev
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        $servidor = "remotemysql.com";
        $usuario = "lj0SNYIAIM";
        $clave = "sWxLgSU8ej";
        $baseDeDatos = "lj0SNYIAIM";
        */
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lj0SNYIAIMDataSet1.sexos' Puede moverla o quitarla según sea necesario.
            //this.sexosTableAdapter.Fill(this.lj0SNYIAIMDataSet1.sexos);
            // TODO: esta línea de código carga datos en la tabla 'lj0SNYIAIMDataSet1.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill((lj0SNYIAIMDataSet1.clientesDataTable)this.consultaClientes(dataGridView1));
            // TODO: esta línea de código carga datos en la tabla 'lj0SNYIAIMDataSet1.sexos' Puede moverla o quitarla según sea necesario.
            //var consulta= lj0SNYIAIMDataSet1.clientes.Join<lj0SNYIAIMDataSet1.sexos[Select new { }],>
            //this.clientesTableAdapter.Fill(consulta);

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
                MessageBox.Show("Database error","Conexion a Database",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private  void consultaClientes(DataGridView d1)
        {
            
                MySqlCommand comando = new MySqlCommand("select id_cliente,clientes.nombre,apellido,dni,telefono,email,clave,cuit,provincia,ciudad,codigopostal,sexos.nombre from clientes inner join sexos on clientes.id_sexo=sexos.id_sexo;", connection);
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tablaclientes = new DataTable();
                adaptador.Fill(tablaclientes);
                d1.DataSource =  tablaclientes;

                connection.Close();

           

        }

        /* var consulta = from c in lj0SNYIAIMDataSet1.clientes join s in lj0SNYIAIMDataSet1.sexos on lj0SNYIAIMDataSet1.clientes.id_sexoColumn equals lj0SNYIAIMDataSet1.sexos.id_sexoColumn select new{ lj0SNYIAIMDataSet1.clientes.id_clienteColumn , lj0SNYIAIMDataSet1.sexos.nombreColumn };
         dataGridView1.DataSource = consulta.ToList();*/



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    }

