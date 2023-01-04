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
    public partial class Crear_Prof : Form
    {
        public Crear_Prof()
        {
            InitializeComponent();
        }

        private void Crear_Prof_Load(object sender, EventArgs e)
        {
            Inicio();   
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
            if(Validar())
            {
                Profesores profesores = new Profesores();
                Profesores_SQL profesores_SQL = new Profesores_SQL();

                profesores.Nombre = Txt_Nombre.Text.ToUpper();
                profesores.PApellido = Txt_1Apellido.Text.ToUpper();
                profesores.SApellido = Txt_2Apellido.Text.ToUpper();
                profesores.Turno = CTxt_Turno.Text;
                profesores.Semestre = CTxt_Semestre.Text;

                if (profesores_SQL.validarProf(profesores))
                {
                    string Id = CTxt_Semestre.Text + "01";
                    profesores.Id = Convert.ToString(profesores_SQL.generaIdProf(Convert.ToInt32(Id)));
                    if (profesores_SQL.New_Profesores(profesores))
                    {
                        MessageBox.Show(profesores_SQL.Mensaje);
                        Inicio();
                    }
                    else
                    {
                        MessageBox.Show(profesores_SQL.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show(profesores_SQL.Mensaje);
                }
            }
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            Acciones(false);
            Btn_Mod.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Llenar();
        }
        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            if(Validar())
            {
                if (Mod_Validar())
                {
                    int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
                    Profesores_SQL profesores_SQL = new Profesores_SQL();
                    Profesores profesores = new Profesores();
                    profesores_SQL.Eliminar_Prof(Convert.ToInt32(Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString()));
                    profesores.Id = Convert.ToString(profesores_SQL.generaIdProf(Convert.ToInt32(CTxt_Semestre.Text + "01")));
                    profesores.Nombre = Txt_Nombre.Text;
                    profesores.PApellido = Txt_1Apellido.Text;
                    profesores.SApellido = Txt_2Apellido.Text;
                    profesores.Semestre = CTxt_Semestre.Text;
                    profesores.Turno = CTxt_Turno.Text;
                    profesores.Clase = Convert.ToInt32(Dgv_Profes.Rows[RenglonSeleccionado].Cells[6].Value.ToString());

                    string Mod_Nombre = Txt_Nombre.Text + " " + Txt_1Apellido.Text + " " + Txt_2Apellido.Text,
                        Nombre = Dgv_Profes.Rows[RenglonSeleccionado].Cells[1].Value.ToString() + " " + Dgv_Profes.Rows[RenglonSeleccionado].Cells[2].Value.ToString() + " " + Dgv_Profes.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
                    if (profesores_SQL.Mod_Prof(profesores))
                    {
                        if (Mod_Nombre != Nombre)
                        {
                            Alumno_SQL alumno_SQL = new Alumno_SQL();
                            alumno_SQL.Mod_Prof(Mod_Nombre, Nombre);
                        }
                    }
                    Inicio();
                }
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Profesores_SQL profesores_SQL = new Profesores_SQL();
            int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
            string IdClase = Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
            if (profesores_SQL.validarClases(IdClase))
            {
                if (Dgv_Profes.Rows.Count > 0)
                {

                    RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
                    int Id = Convert.ToInt32(Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
                    DialogResult Resultado = MessageBox.Show("¿Desea eliminar al Profesor con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (Resultado == DialogResult.Yes)
                    {
                        if (profesores_SQL.Eliminar_Prof(Id))
                        {
                            MessageBox.Show(profesores_SQL.Mensaje);
                        }
                        else
                        {
                            MessageBox.Show(profesores_SQL.Mensaje);
                        }
                    }
                    Inicio();
                }
                else
                {
                    MessageBox.Show("No hay datos a eliminar");
                }
            }
            else
            {
                MessageBox.Show(profesores_SQL.Mensaje);
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Mostrar()
        {
            Profesores_SQL profesores_SQL = new Profesores_SQL();
            Dgv_Profes.DataSource = profesores_SQL.Mostrar_Profesores();
        }
        public void Inicio()
        {
            Mostrar();
            Gb_Datos.Enabled = false;
            Acciones(true);
            Btn_Agregar.Enabled = false;
            Btn_Mod.Enabled = false;
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
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
            Txt_Nombre.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            Txt_1Apellido.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
            Txt_2Apellido.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
            CTxt_Semestre.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[4].Value.ToString();
            CTxt_Turno.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
        }
        public bool Mod_Validar()
        {
            int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
            Profesores_SQL profesores_SQL = new Profesores_SQL();
            if ((Dgv_Profes.Rows[RenglonSeleccionado].Cells[4].Value.ToString() != CTxt_Semestre.Text) || Dgv_Profes.Rows[RenglonSeleccionado].Cells[5].Value.ToString() != CTxt_Turno.Text)
            {
                if(profesores_SQL.validarClases(Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString()))
                {
                    return true;
                }
                MessageBox.Show("Debido a que se desea modificarse el Semestre y/o el Turno, debe cerciorase que el numero de clases del profesor este en 0");
                return false;
            }
            else
            {
                return true;
            }
        }
     
    }
}
