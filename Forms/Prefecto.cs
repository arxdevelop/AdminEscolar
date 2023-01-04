using Proyecto_Final.Clases;
using Proyecto_Final.SQL;
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
    public partial class Prefecto : Form
    {
        public Prefecto()
        {
            InitializeComponent();
        }
        Reportes reportes = new Reportes();
        Reportes_SQL reportes_SQL = new Reportes_SQL();
        DataTable clases;
        private void Prefecto_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        public void Inicio()
        {
            Reportes_SQL reportes_SQL = new Reportes_SQL();
            Dgv_Reportes.DataSource = reportes_SQL.Mostrar_Reportes();
            foreach(Control c in this.Gb_Datos.Controls)
            {
                if(c is ComboBox || c is TextBox)
                {
                    c.Text = "";
                }
            }
            Gb_Datos.Enabled = false;
            Gb_Acciones.Enabled = true;
            foreach(Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled = false;
            }
            Btn_Nuevo.Enabled = true;
            Btn_Eliminar.Enabled = true;
        }
        public bool Validar()
        {
            foreach(Control c in this.Gb_Datos.Controls)
            {
                if(c.Text == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            foreach(Control c in this.Gb_Datos.Controls)
            {
                c.Enabled = false;
            }
            label1.Enabled = true;
            Cb_Turno.Enabled = true;

            foreach(Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled = true;
            }
            Btn_Nuevo.Enabled = false;
            Btn_Eliminar.Enabled = false;
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                //reportes.
            }
            else
            {
                MessageBox.Show("Faltan Campos a llenar");
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        private void Cb_Turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                c.Enabled = false;
            }
            label1.Enabled = true;
            Cb_Turno.Enabled = true;
            label2.Enabled = true;
            Cb_Grupo.Enabled = true;
            Cb_Grupo.Text = "";
            Cb_Materia.Text = "";
            clases = reportes_SQL.Llenar_Grupo(Cb_Turno.Text);
            Cb_Grupo.Items.Clear();
            for(int i = 0; i < clases.Rows.Count; i++)
            {
                Cb_Grupo.Items.Add(clases.Rows[i]["Grupo"].ToString());
            }
        }
        private void Cb_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                c.Enabled = false;
            }
            label1.Enabled = true;
            Cb_Turno.Enabled = true;
            label2.Enabled = true;
            Cb_Grupo.Enabled = true;
            label3.Enabled = true;
            Cb_Materia.Enabled = true;
            Cb_Materia.Text = "";
            clases = reportes_SQL.Llenar_Materia(Cb_Grupo.Text);
            Cb_Materia.Items.Clear();
            for (int i = 0; i < clases.Rows.Count; i++)
            {
                Cb_Materia.Items.Add(clases.Rows[i]["Materia"].ToString());
            }
        }
        private void Cb_Clase_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Enabled = true;
            Txt_Reporte.Enabled = true;
            label5.Enabled = true;
            Dtp_DiaReporte.Enabled = true;
        }
    }
}
