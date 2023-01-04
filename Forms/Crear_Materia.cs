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
    public partial class Crear_Materia : Form
    {
        public Crear_Materia()
        {
            InitializeComponent();
        }
        private void Crear_Materia_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Mostrar()
        {
            Materias_SQL materias_SQL = new Materias_SQL();
            Dgv_Materias.DataSource = materias_SQL.Mostrar_Materias();
        }
        public void Inicio()
        {
            Mostrar();
            Gb_Datos.Enabled = false;
            Acciones(true);
            Btn_Agregar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Limpiar();
        }
        public void Acciones(bool i)
        {
            foreach (Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled = i;
            }
        }
        public bool Validar()
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                if (c.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                    return false;
                }
            }
            return true;
        }
        public void Limpiar()
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            Acciones(false);
            Btn_Agregar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Materias materias = new Materias();
                Materias_SQL materias_SQL = new Materias_SQL();

                materias.Nombre = Txt_Nombre.Text.ToUpper();
                materias.Semestre = Convert.ToInt32(Txt_Semestre.Text);

                if (materias_SQL.validarMateria(materias))
                {
                    string Id = Txt_Semestre.Text + "01";
                    materias.Id = Convert.ToString(materias_SQL.generaIdMateria(Convert.ToInt32(Id)));
                    if (materias_SQL.New_Materias(materias))
                    {
                        MessageBox.Show(materias_SQL.Mensaje);
                        Inicio();
                    }
                    else
                    {
                        MessageBox.Show(materias_SQL.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show(materias_SQL.Mensaje);
                }
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Materias.Rows.Count > 0)
            {
                Materias_SQL materias_SQL = new Materias_SQL();
                int RenglonSeleccionado = Dgv_Materias.CurrentRow.Index;
                string Id = Dgv_Materias.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
                if(materias_SQL.validarClases(Id))
                {
                    if(Dgv_Materias.Rows.Count > 0)
                    {
                        DialogResult Resultado = MessageBox.Show("¿Deseas eliminar la materia con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (Resultado == DialogResult.Yes)
                        {
                            if (materias_SQL.Eliminar_Materia(Id))
                            {
                                MessageBox.Show(materias_SQL.Mensaje);
                            }
                            else
                            {
                                MessageBox.Show(materias_SQL.Mensaje);
                            }
                        }
                        Inicio();
                    }
                    else
                    {
                        MessageBox.Show("No hay datos a eliminar");
                    }
                }
               
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Inicio();
        }
    }
}
