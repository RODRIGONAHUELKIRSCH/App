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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private string id_prof;
        private string nombre;
        private string apellido;
        private string permiso;
        private string usuario;
        private string clave;
        private string id_sexo;

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
        private void labeluser_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbid_TextChanged(object sender, EventArgs e)
        {
            tbid.Text = id_prof;
        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {
            tbnombre.Text = nombre;
        }

        private void tbapellido_TextChanged(object sender, EventArgs e)
        {
            tbapellido.Text = apellido;
        }

       

        private void tbpermiso_TextChanged(object sender, EventArgs e)
        {
            tbpermiso.Text = permiso;
        }

        private void tbuser_TextChanged(object sender, EventArgs e)
        {
            tbuser.Text = usuario;
        }

        private void tbcontraseña_TextChanged(object sender, EventArgs e)
        {
            tbcontraseña.Text = clave;
        }

        private void tbsexo_TextChanged(object sender, EventArgs e)
        {
            tbsexo.Text = id_sexo;
        }

        MySqlConnection connection = new MySqlConnection("server=remotemysql.com;user id=lj0SNYIAIM;password=sWxLgSU8ej;persistsecurityinfo=True;database=lj0SNYIAIM");

        private void btnadd_Click(object sender, EventArgs e)
        {
            
        }

        private void addPersonal()
        {
            try
            {
                string sqlcommand = "insert into profesionales (" + id_prof + "," + nombre + "," + apellido + "," + permiso + "," + usuario + "," + clave + "," + id_sexo + ";";
                MySqlCommand comando = new MySqlCommand(sqlcommand, connection);

            }
            catch (Exception)
            {
                MessageBox.Show("Command Error", "Conexion a Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
      
    }
}
