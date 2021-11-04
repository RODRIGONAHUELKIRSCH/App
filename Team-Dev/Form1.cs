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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int usuario = 0;
        private int contraseña = 0;
        private void labelcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbusuario.Text, out usuario);
        }

        private void tbcontraseña_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbcontraseña.Text, out contraseña);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (usuario == 1 && contraseña == 1)
            {

                Form2 form2 = new Form2(this);
                form2.Show();
                this.Hide();
            }
            if (usuario == 2 && contraseña == 2)
            {
                Form3 form3 = new Form3(this);
                form3.Show();
                this.Hide();
            }
            if(usuario == 3 && contraseña == 3)
            {
                
                Form4 form4 = new Form4(this);
                form4.Show();
                this.Hide();
            }
        }
    }
}
