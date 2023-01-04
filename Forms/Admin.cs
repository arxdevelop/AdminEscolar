using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Forms
{
    public partial class Admin : Form
    {
        private Form FormularioSec = null;
        public Admin()
        {
            InitializeComponent();
        }

        private void Btn_Prof_Click(object sender, EventArgs e)
        {
            NewForm(new Crear_Prof());
        }
        public void NewForm(Form Formulario
            )
        {
            if (FormularioSec != null)
            {
                FormularioSec.Close();
            }
            else
            {
                FormularioSec = Formulario;
                Formulario.TopLevel = false;
                Formulario.FormBorderStyle = FormBorderStyle.None;
                Formulario.Dock = DockStyle.Fill;
                Panel_Forms.Controls.Add(Formulario);
                Panel_Forms.Tag = Formulario;
                Formulario.BringToFront();
                Formulario.Show();
                FormularioSec = null;
            }
        }

        private void Btn_Materias_Click(object sender, EventArgs e)
        {
            NewForm(new Crear_Materia());
        }

        private void Btn_Clases_Click(object sender, EventArgs e)
        {
            NewForm(new Crear_Clase());
        }

        private void Btn_Usuarios_Click(object sender, EventArgs e)
        {
            NewForm(new Crear_User());
        }
    }
}
