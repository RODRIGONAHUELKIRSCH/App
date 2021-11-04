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
    public partial class Form3 : Form
    {
        private Form padre;
        public Form3(Form padre)
        {
            InitializeComponent();
            personalizar();
            this.padre = padre;
        }



        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void personalizar()
        {
            panelvesubmenu.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelvesubmenu.Visible == true)
            {
                panelvesubmenu.Visible = false;
            }
        }
        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

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
            panelvistaempleados.Controls.Add(formularioHijo);
            panelvistaempleados.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnmenuempleado_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelvesubmenu);
        }

        private void btnveclientes_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form6());
            ocultarsubmenu();
        } 

        private void panelvesubmenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelvemenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }

        private void btnturnosempleados_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form8());
            ocultarsubmenu();
        }
    }
}
