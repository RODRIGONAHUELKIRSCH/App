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
    public partial class Form4 : Form
    {
        private Form padre;
        public Form4(Form padre)
        {
            InitializeComponent();
            personalizar();
           this.padre = padre;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void personalizar()
        {
            panelvssubmenu.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelvssubmenu.Visible == true)
            {
                panelvssubmenu.Visible = false;
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
            panelvistasecretaria.Controls.Add(formularioHijo);
            panelvistasecretaria.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnvsmenu_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelvssubmenu);
        }

        private void btnvspagos_Click(object sender, EventArgs e)
        {
            Abrirformulariohijo(new Form5());
            ocultarsubmenu();
        }

        private void panelvssubmenu_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }
    }
}
