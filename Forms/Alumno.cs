using Microsoft.Win32;
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
using System.Data.SqlClient;
using Proyecto_Final.Clases;

namespace Proyecto_Final.Forms
{
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void Filtros_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Filtros.Checked)
            {
                Ctxt_Grupo.Items.Clear();
                Ctxt_Materia.Items.Clear();
                Ctxt_Profesor.Items.Clear();

                Gb_Filtros.Enabled = true;
                foreach (Control c in this.Gb_Filtros.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Enabled = false;
                    }
                }

                DataTable data;
                Alumno_SQL alumno_SQL = new Alumno_SQL();

                data = alumno_SQL.LlenaComboMaterias(Cb_Semestre.Text);
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    Ctxt_Materia.Items.Add(data.Rows[i]["Nombre"].ToString());
                }

                string[] prof = alumno_SQL.LlenaComboProfes(Cb_Semestre.Text);
                
                for(int i = 0; i <= prof.Length-1; i++)
                {
                    Ctxt_Profesor.Items.Add(prof[i]);
                }
                Alumnos alumnos = new Alumnos();
                alumnos.Semestre = Cb_Semestre.Text;
                if(Rb_Matutino.Checked)
                {
                    alumnos.Turno = Rb_Matutino.Text;
                }
                if (Rb_Vespertino.Checked)
                {
                    alumnos.Turno = Rb_Vespertino.Text;
                }
                string[] Grupo = alumno_SQL.LlenaComboGrupo(alumnos);
                string[] Grup = new string[Grupo.Length];
                for (int i = 0; i < Grupo.Length; i++)
                {
                    int j;
                    for (j = 0; j < Grupo.Length; j++)
                    {
                        if (Grup[j] == Grupo[i])
                        {
                            j = Grupo.Length;
                        }
                    }
                    if(j != Grupo.Length + 1)
                    {
                        Ctxt_Grupo.Items.Add(Grupo[i]);
                        Grup[i] = Grupo[i];
                    }
                }
            }   

            else
            {
                Inicio();
                Cb_Filtros.Enabled = true;
            }
        }
        private void Cb_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_Grupo.Checked)
            {
                Ctxt_Grupo.Enabled = true;
            }
            else
            {
                Ctxt_Grupo.Enabled = false;
                Ctxt_Grupo.Text = "";
            }
        }
        private void Cb_Materia_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Materia.Checked)
            {
                Ctxt_Materia.Enabled = true;
            }
            else
            {
                Ctxt_Materia.Enabled = false;
                Ctxt_Materia.Text = "";
            }
        }
        private void Cb_Profesor_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Profesor.Checked)
            {
                Ctxt_Profesor.Enabled = true;
            }
            else
            {
                Ctxt_Profesor.Enabled = false;
                Ctxt_Profesor.Text = "";
            }
        }
        public void Inicio()
        {
            Btn_Buscar.Enabled = false;
            Cb_Filtros.Enabled = false;
            Cb_Filtros.Checked = false;
            Gb_Filtros.Enabled = false;
            Cb_Grupo.Checked = false;
            Ctxt_Grupo.Text = "";
            Cb_Materia.Checked = false;            
            Ctxt_Materia.Text = "";
            Cb_Profesor.Checked = false;
            Ctxt_Profesor.Text = "";

        }
        public void Buscar()
        {
            Inicio();
            if ((Rb_Matutino.Checked || Rb_Vespertino.Checked) && Cb_Semestre.Text != "")
            {
                Alumnos alumnos = new Alumnos();
                if (Rb_Matutino.Checked)
                {
                    alumnos.Turno = Rb_Matutino.Text;
                }
                if (Rb_Vespertino.Checked)
                {
                    alumnos.Turno = Rb_Vespertino.Text;
                }
                alumnos.Semestre = Cb_Semestre.Text;
                
                Alumno_SQL alumno_SQL = new Alumno_SQL();               
                Dgv_Horario.DataSource = alumno_SQL.Mostrar_Horario(alumnos);
                Dgv_Horario.AutoSize = true;
                Cb_Filtros.Enabled = true;
                Btn_Buscar.Enabled = true;
            }
        }

        private void Rb_Matutino_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Rb_Vespertino_CheckedChanged(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Cb_Semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if(Validar_Filtros())
            {
                string sentencia = "";
                int i = 0;
                Alumnos alumnos = new Alumnos();
                alumnos.Grupo = "";
                alumnos.Materia = "";
                alumnos.Profesor = "";

                if (Cb_Grupo.Checked)
                {
                    alumnos.Grupo = Ctxt_Grupo.Text;
                    sentencia = "and Grupo = @Grupo ";
                    i = 1;
                }
                if(Cb_Materia.Checked)
                {
                    alumnos.Materia = Ctxt_Materia.Text;
                    if(i == 1)
                    {
                        sentencia += "and Materia = @Materia ";
                    }
                    else
                    {
                        sentencia = "and Materia = @Materia ";
                    }
                    i = 1;
                }
                if(Cb_Profesor.Checked)
                {
                    alumnos.Profesor = Ctxt_Profesor.Text;
                    if (i == 1)
                    {
                        sentencia += "and Profesor = @Profesor";
                    }
                    else
                    {
                        sentencia = "and Profesor = @Profesor ";
                    }
                }
                alumnos.Sentencia = sentencia;
                if (Rb_Matutino.Checked)
                {
                    alumnos.Turno = Rb_Matutino.Text;
                }
                if (Rb_Vespertino.Checked)
                {
                    alumnos.Turno = Rb_Vespertino.Text;
                }
                alumnos.Semestre = Cb_Semestre.Text;
                Alumno_SQL alumno_SQL = new Alumno_SQL();
                Dgv_Horario.DataSource = alumno_SQL.Buscar_Horario(alumnos);
            }
            else
            {
                MessageBox.Show("Estan marcados filtros que no tienen datos");
            }
        }
        public bool Validar_Filtros()
        {
            if (Cb_Grupo.Checked && Ctxt_Grupo.Text == "")
            {
                return false;
            }
            if (Cb_Materia.Checked && Ctxt_Materia.Text == "")
            {
                return false;
            }
            if (Cb_Profesor.Checked && Ctxt_Profesor.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
