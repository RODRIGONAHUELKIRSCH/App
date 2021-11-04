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
    public partial class Form2 : Form
    {
        private Form padre;
        public Form2(Form padre)
        {
            InitializeComponent();
            personalizar();
            this.padre = padre;
            
        }
        private void personalizar()
        {
            panelsubmenu.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
            }
        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible=true;
            }
            else
            {
                submenu.Visible=false;
            }

        }


       /* private void btnmenu_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
        }*/
        
        private void btnpagos_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form5());
            ocultarsubmenu();
        }

        private  void btnclientes_Click(object sender, EventArgs e)
        {
            
            Abrirformulariohijo(new Form6());
            ocultarsubmenu();
        }
     
        private void btnpersonal_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form7());
            ocultarsubmenu();
        }

        

        private void panelsubmenu_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }

        private Form formularioActivo = null;
        private void Abrirformulariohijo(Form formularioHijo)
        {
            if (formularioActivo != null)
               formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelcontenedorVistaAdministrador.Controls.Add(formularioHijo);
            panelcontenedorVistaAdministrador.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form8());
            ocultarsubmenu();

        }

        private void btnaddpersonal_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form9());
            ocultarsubmenu();
        }
    }
}
