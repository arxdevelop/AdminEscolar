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
    public partial class Crear_Clase : Form
    {
        public Crear_Clase()
        {
            InitializeComponent();
        }

        private void Crear_Clase_Load(object sender, EventArgs e)
        {
            inicio();
        }
        public void inicio()
        {
            Clases_SQL clases_SQL= new Clases_SQL();
            Dgv_Clases.DataSource =  clases_SQL.Mostrar_Clases();
            Gb_Datos.Enabled = false;
            foreach(Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled= true;
            }
            Btn_Agregar.Enabled = false;
            Btn_Actualizar.Enabled= false;
            Btn_Cancelar.Enabled= false;
            foreach (Control c in this.Gb_Datos.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
            }
            foreach (Control c in this.Gb_Horario.Controls)
            {
                if (c is ComboBox)
                {
                    c.Text = "";
                }
            }
            Lbl_IdMateria.Text = "";
            Lbl_IdProfe.Text = "";
            ChB_Lunes.Checked = false;
            ChB_Martes.Checked = false;
            ChB_Miercoles.Checked = false;
            ChB_Jueves.Checked = false;
            ChB_Viernes.Checked = false;
        }
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Clases.CurrentRow.Index;
            Cb_Semestre.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            Cb_Turno.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
            Cb_Grupo.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[4].Value.ToString();
            Cb_Materia.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
            Cb_Prof.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[6].Value.ToString();
            CB_LunesI.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[7].Value.ToString();
            CB_LunesF.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[8].Value.ToString();
            CB_MartesI.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[9].Value.ToString();
            CB_MartesF.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[10].Value.ToString();
            CB_MiercolesI.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[11].Value.ToString();
            CB_MiercolesF.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[12].Value.ToString();
            CB_JuevesI.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[13].Value.ToString();
            CB_JuevesF.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[14].Value.ToString();
            CB_ViernesI.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[15].Value.ToString();
            CB_ViernesF.Text = Dgv_Clases.Rows[RenglonSeleccionado].Cells[16].Value.ToString();
            IdMateria();
            IdProfe();

        }

        //Eventos para empezar a crear las clases
        private void Txt_Semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PValidar())
            {
                Comobo_Prof_Materias_Grupos();
            }
        }
        private void Txt_Turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PValidar())
            {
                Comobo_Prof_Materias_Grupos();
            }
        }

        //Llena los Combobox de Profesores y de Materias
        public void Comobo_Prof_Materias_Grupos()
        {
            Clase clase = new Clase();
            Clases_SQL clases_SQL = new Clases_SQL();

            //Llenar Combo Profesores
            DataTable TablaProfes = clases_SQL.LlenaComboProfes(Cb_Semestre.Text, Cb_Turno.Text);
            string[] Id = new string[TablaProfes.Rows.Count];
            Cb_Prof.Items.Clear();
            Cb_Prof.Text = "";
            for (int i = 0; i < TablaProfes.Rows.Count; i++)
            {
                Cb_Prof.Items.Add(TablaProfes.Rows[i]["Nombre"].ToString() + " " + TablaProfes.Rows[i]["PApellido"].ToString() + " " + TablaProfes.Rows[i]["SApellido"].ToString());
                Id[i] = TablaProfes.Rows[i]["IdProfe"].ToString();
            }

            //LLenar Combo Materias
            DataTable TablaMateria = clases_SQL.LlenaComboMateria(Cb_Semestre.Text);
            Cb_Materia.Items.Clear();
            Cb_Materia.Text = "";
            for (int i = 0; i < TablaMateria.Rows.Count; i++)
            {
                Cb_Materia.Items.Add(TablaMateria.Rows[i]["Nombre"].ToString());
            }

            //Llenar Combo Grupos
            Cb_Grupo.Items.Clear();
            Cb_Grupo.Text = "";
            for (int i = 1; i <= 20; i++)
            {
                if (Cb_Turno.Text == "Matutino")
                {
                    Cb_Grupo.Items.Add(Cb_Semestre.Text + "IM" + i);
                }
                if (Cb_Turno.Text == "Vespertino")
                {
                    Cb_Grupo.Items.Add(Cb_Semestre.Text + "IV" + i);
                }
            }
        }
        
        //Valida si hay datos en el semestre y en el turno para despues buscar los profesores y las materias
        public bool PValidar()
        {
            if(Cb_Semestre.Text != "" && Cb_Turno.Text != "")
            {
                foreach(Control c in this.Gb_Datos.Controls)
                {
                    c.Enabled = true;
                }
                foreach(Control c in this.Gb_Horario.Controls)
                {
                    c.Enabled = false;
                    if(c is CheckBox || c is Label)
                    {
                        c.Enabled = true;
                    }
                }
                Lbl_IdMateria.Text = "";
                Lbl_IdProfe.Text = "";

                return true;
            }
            Lbl_IdMateria.Text = "";
            Lbl_IdProfe.Text = "";
            return false;
        }
        public bool SValidar()
        {
            foreach(Control c in this.Gb_Datos.Controls)
            {
                if(c is ComboBox)
                {
                    if(c.Text == "")
                    {
                        MessageBox.Show("Faltan campos a rellenar");
                        return false;
                    }
                }
            }
            return true;
        }
        public bool TValidar()
        {
            int i = 0;
            if(ChB_Lunes.Checked)
            {
                if (CB_LunesI.Text == "" || CB_LunesF.Text == "")
                {
                    MessageBox.Show("Faltar por llenar las horas del dia Lunes");
                    return false;
                }
            }
            else
            {
                i++;
            }
            if (ChB_Martes.Checked)
            {
                if (CB_MartesI.Text == "" || CB_MartesF.Text == "")
                {
                    MessageBox.Show("Faltar por llenar las horas del dia Martes");
                    return false;
                } 
            }
            else
            {
                i++;
            }
            if (ChB_Miercoles.Checked)
            {
                if (CB_MiercolesI.Text == "" || CB_MiercolesF.Text == "")
                {
                    MessageBox.Show("Faltar por llenar las horas del dia Miercoles");
                    return false;
                }
            }
            else
            {
                i++;
            }
            if (ChB_Jueves.Checked)
            {
                if (CB_JuevesI.Text == "" || CB_JuevesF.Text == "")
                {
                    MessageBox.Show("Faltar por llenar las horas del dia Jueves");
                    return false;
                }
            }
            else
            {
                i++;
            }
            if (ChB_Viernes.Checked)
            {
                if (CB_ViernesI.Text == "" || CB_ViernesF.Text == "")
                {
                    MessageBox.Show("Faltar por llenar las horas del dia Viernes");
                    return false;
                }
            }
            else
            {
                i++;
            }
            if(i == 5)
            {
                MessageBox.Show("No puedes registrar la clase, por que no hay por lo menos un dia seleccionado");
                return false;
            }
            return true;
        }
        public void Habilitar_Check()
        {
            if(CB_LunesI.Text != "" && CB_LunesF.Text != "")
            {
                ChB_Lunes.Checked = true;
            }
            if (CB_MartesI.Text != "" && CB_MartesF.Text != "")
            {
                ChB_Martes.Checked = true;
            }
            if (CB_MiercolesI.Text != "" && CB_MiercolesF.Text != "")
            {
                ChB_Miercoles.Checked = true;
            }
            if (CB_JuevesI.Text != "" && CB_JuevesF.Text != "")
            {
                ChB_Jueves.Checked = true;
            }
            if (CB_ViernesI.Text != "" && CB_ViernesF.Text != "")
            {
                ChB_Viernes.Checked = true;
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled = false;
            }
            Btn_Agregar.Enabled = true;
            Btn_Cancelar.Enabled = true;
            Gb_Datos.Enabled = true;
            foreach (Control c in this.Gb_Datos.Controls)
            {
                c.Enabled = false;
            }
            label4.Enabled = true;
            label5.Enabled = true;
            Cb_Semestre.Enabled = true;
            Cb_Turno.Enabled = true;
            Lbl_IdMateria.Text = "";
        }
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase();
            Clases_SQL clases_SQL = new Clases_SQL();
            try
            {
                clase.Semestre = Convert.ToInt32(Cb_Semestre.Text);
            }
            catch
            {
                clase.Semestre = 0;
            }
            clase.Turno = Cb_Turno.Text;
            clase.Materia = Cb_Materia.Text;
            clase.Profesor = Cb_Prof.Text;
            clase.Grupo = Cb_Grupo.Text;
            if(SValidar())
            {
                if (clases_SQL.ValidarDatos(clase))
                {
                    if(TValidar())
                    {
                        string[] hora = new string[10];
                        string[] dia = new string[] { "LunesI", "LunesF", "MartesI", "MartesF", "MiercolesI", "MiercolesF", "JuevesI", "JuevesF", "ViernesI", "ViernesF" };
                        int i = 9;
                        foreach (Control c in this.Gb_Horario.Controls)
                        {
                            if (c is ComboBox)
                            {
                                if (c.Text == "")
                                {
                                    hora[i] = "0";
                                }
                                else
                                {
                                    hora[i] = c.Text;
                                }
                                i--;
                            }
                        }
                        i = 9;
                        while (i >= 0)
                        {
                            clase.Hora = hora[i];
                            clase.Dia = dia[i];
                            if (clases_SQL.ValidarHorario(clase))
                            {
                                i--;
                            }
                            else
                            {
                                i = -2;
                            }
                        }
                        if(i != -2)
                        {
                            clase.IdClase = clase.Grupo + Lbl_IdMateria.Text;
                            clase.LunesI = CB_LunesI.Text;
                            clase.LunesF = CB_LunesF.Text;
                            clase.MartesI = CB_MartesI.Text;
                            clase.MartesF = CB_MartesF.Text;
                            clase.MiercolesI =CB_MiercolesI.Text;
                            clase.MiercolesF = CB_MiercolesF.Text;
                            clase.JuevesI = CB_JuevesI.Text;
                            clase.JuevesF = CB_JuevesF.Text;
                            clase.ViernesI = CB_ViernesI.Text;
                            clase.ViernesF = CB_ViernesF.Text;
                            clase.NumGrupo = Convert.ToString(Cb_Materia.SelectedIndex + 1);
                            if(clases_SQL.Registrar_Horario(clase))
                            {
                                MessageBox.Show(clases_SQL.Mensaje);
                                Profesores_SQL profesores_SQL = new Profesores_SQL();
                                Profesores profesores = new Profesores();
                                profesores.Id = Lbl_IdProfe.Text;
                                DataTable TablaProf = profesores_SQL.Buscar_Clase(profesores);
                                int C = Convert.ToInt32(TablaProf.Rows[0]["Clases"].ToString());
                                profesores.Clase = C + 1;
                                profesores_SQL.Sumar_Restar_Clase(profesores);

                                Materias materias = new Materias();
                                Materias_SQL materias_SQL = new Materias_SQL();
                                materias.Nombre = Cb_Materia.Text;
                                DataTable data = materias_SQL.Buscar_Clase(materias);
                                C = Convert.ToInt32(data.Rows[0]["Clases"].ToString());
                                C++;
                                materias.Clase = C;
                                materias_SQL.Sumar_Restar_Clase(materias);

                                inicio();
                            }
                            else
                            {
                                MessageBox.Show(clases_SQL.Mensaje);
                            }
                            
                        }
                    }
                }
            }
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Dgv_Clases.Rows.Count > 0)
            {
                Llenar();
                Gb_Datos.Enabled = true;
                foreach (Control c in this.Gb_Acciones.Controls)
                {
                    c.Enabled = false;
                }
                Btn_Actualizar.Enabled = true;
                Btn_Cancelar.Enabled = true;
                Habilitar_Check();
            }
            else
            {
                MessageBox.Show("No hay datos a modificar");
            }
        }
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Clases_SQL clases_SQL = new Clases_SQL();
            Clase clase = new Clase();
            int RenglonSeleccionado = Dgv_Clases.CurrentRow.Index;
            string Id = Dgv_Clases.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
            if (clases_SQL.Eliminar_Clase(Id))
            {
                try
                {
                    clase.Semestre = Convert.ToInt32(Cb_Semestre.Text);
                }
                catch
                {
                    clase.Semestre = 0;
                }
                clase.Turno = Cb_Turno.Text;
                clase.Materia = Cb_Materia.Text;
                clase.Profesor = Cb_Prof.Text;
                clase.Grupo = Cb_Grupo.Text;
                if (SValidar())
                {
                    if (clases_SQL.ValidarDatos(clase))
                    {
                        if (TValidar())
                        {
                            string[] hora = new string[10];
                            string[] dia = new string[] { "LunesI", "LunesF", "MartesI", "MartesF", "MiercolesI", "MiercolesF", "JuevesI", "JuevesF", "ViernesI", "ViernesF" };
                            int i = 9;
                            foreach (Control c in this.Gb_Horario.Controls)
                            {
                                if (c is ComboBox)
                                {
                                    if (c.Text == "")
                                    {
                                        hora[i] = "0";
                                    }
                                    else
                                    {
                                        hora[i] = c.Text;
                                    }
                                    i--;
                                }
                            }
                            i = 9;
                            while (i >= 0)
                            {
                                clase.Hora = hora[i];
                                clase.Dia = dia[i];
                                if (clases_SQL.ValidarHorario(clase))
                                {
                                    i--;
                                }
                                else
                                {
                                    i = -2;
                                }
                            }
                            if (i != -2)
                            {
                                clase.IdClase = clase.Grupo + Lbl_IdMateria.Text;
                                clase.LunesI = CB_LunesI.Text;
                                clase.LunesF = CB_LunesF.Text;
                                clase.MartesI = CB_MartesI.Text;
                                clase.MartesF = CB_MartesF.Text;
                                clase.MiercolesI = CB_MiercolesI.Text;
                                clase.MiercolesF = CB_MiercolesF.Text;
                                clase.JuevesI = CB_JuevesI.Text;
                                clase.JuevesF = CB_JuevesF.Text;
                                clase.ViernesI = CB_ViernesI.Text;
                                clase.ViernesF = CB_ViernesF.Text;
                                clase.NumGrupo = Convert.ToString(Cb_Materia.SelectedIndex + 1);
                                if(Dgv_Clases.Rows[RenglonSeleccionado].Cells[6].Value.ToString() != clase.Profesor)
                                {
                                    Profesores profesores = new Profesores();
                                    DataTable data = clases_SQL.LlenaComboProfes(Dgv_Clases.Rows[RenglonSeleccionado].Cells[1].Value.ToString(), Dgv_Clases.Rows[RenglonSeleccionado].Cells[2].Value.ToString());
                                    for (i = 0; i < data.Rows.Count; i++)
                                    {
                                        string nombre = data.Rows[i]["Nombre"].ToString() + " " + data.Rows[i]["PApellido"].ToString() + " " + data.Rows[i]["SApellido"].ToString();
                                        if (Dgv_Clases.Rows[RenglonSeleccionado].Cells[6].Value.ToString() == nombre)
                                        {
                                            profesores.Id = data.Rows[i]["IdProfe"].ToString();
                                        }
                                    }
                                    Profesores_SQL profesores_SQL = new Profesores_SQL();
                                    DataTable TablaProf = profesores_SQL.Buscar_Clase(profesores);
                                    int C = Convert.ToInt32(TablaProf.Rows[0]["Clases"].ToString());
                                    C--;
                                    profesores.Clase = C;
                                    profesores_SQL.Sumar_Restar_Clase(profesores);

                                    profesores.Id = Lbl_IdProfe.Text;
                                    TablaProf = profesores_SQL.Buscar_Clase(profesores);
                                    C = Convert.ToInt32(TablaProf.Rows[0]["Clases"].ToString());
                                    profesores.Clase = C + 1;
                                    profesores_SQL.Sumar_Restar_Clase(profesores);

                                }
                                if(Dgv_Clases.Rows[RenglonSeleccionado].Cells[5].Value.ToString() != clase.Materia)
                                {
                                    Materias materias = new Materias();
                                    Materias_SQL materias_SQL = new Materias_SQL();
                                    materias.Nombre = Dgv_Clases.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
                                    DataTable data = materias_SQL.Buscar_Clase(materias);
                                    int C = Convert.ToInt32(data.Rows[0]["Clases"].ToString());
                                    C--;
                                    materias.Clase = C;
                                    materias_SQL.Sumar_Restar_Clase(materias);

                                    materias.Nombre = Cb_Materia.Text;
                                    data = materias_SQL.Buscar_Clase(materias);
                                    C = Convert.ToInt32(data.Rows[0]["Clases"].ToString());
                                    C++;
                                    materias.Clase = C;
                                    materias_SQL.Sumar_Restar_Clase(materias);
                                }
                                if (clases_SQL.Registrar_Horario(clase))
                                {
                                    MessageBox.Show("Clase modificada correctamente");
                                    inicio();
                                }
                                else
                                {
                                    MessageBox.Show(clases_SQL.Mensaje);
                                }

                            }
                        }
                    }
                }
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Dgv_Clases.Rows.Count > 0)
            {
                Clases_SQL clases_SQL = new Clases_SQL();
                int RenglonSeleccionado = Dgv_Clases.CurrentRow.Index;
                string Id = Dgv_Clases.Rows[RenglonSeleccionado].Cells[0].Value.ToString();
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar la Clase con Id " + Id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    Profesores profesores = new Profesores();
                    DataTable data = clases_SQL.LlenaComboProfes(Dgv_Clases.Rows[RenglonSeleccionado].Cells[1].Value.ToString(), Dgv_Clases.Rows[RenglonSeleccionado].Cells[2].Value.ToString());
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        string nombre = data.Rows[i]["Nombre"].ToString() + " " + data.Rows[i]["PApellido"].ToString() + " " + data.Rows[i]["SApellido"].ToString();
                        if (Dgv_Clases.Rows[RenglonSeleccionado].Cells[6].Value.ToString() == nombre)
                        {
                            profesores.Id = data.Rows[i]["IdProfe"].ToString();
                        }
                    }
                    Profesores_SQL profesores_SQL = new Profesores_SQL();
                    DataTable TablaProf = profesores_SQL.Buscar_Clase(profesores);
                    int C = Convert.ToInt32(TablaProf.Rows[0]["Clases"].ToString());
                    C--;
                    profesores.Clase = C;
                    profesores_SQL.Sumar_Restar_Clase(profesores);

                    Materias materias = new Materias();
                    Materias_SQL materias_SQL = new Materias_SQL();
                    materias.Nombre = Dgv_Clases.Rows[RenglonSeleccionado].Cells[5].Value.ToString();
                    data = materias_SQL.Buscar_Clase(materias);
                    C = Convert.ToInt32(data.Rows[0]["Clases"].ToString());
                    C--;
                    materias.Clase = C;
                    materias_SQL.Sumar_Restar_Clase(materias);

                    if (clases_SQL.Eliminar_Clase(Id))
                    {
                        MessageBox.Show(clases_SQL.Mensaje);
                        inicio();
                    }
                    else
                    {
                        MessageBox.Show(clases_SQL.Mensaje);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos a eliminar");
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void Cb_Materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdMateria();
        }
        private void Cb_Prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdProfe();
        }
        public void IdMateria()
        {
            Clases_SQL clases_SQL = new Clases_SQL();
            DataTable TablaMateria = clases_SQL.LlenaComboMateria(Cb_Semestre.Text);
            Lbl_IdMateria.Text = TablaMateria.Rows[Cb_Materia.SelectedIndex]["IdMateria"].ToString();
        }
        public void IdProfe()
        {
            Clases_SQL clases_SQL = new Clases_SQL();
            DataTable TablaProfes = clases_SQL.LlenaComboProfes(Cb_Semestre.Text, Cb_Turno.Text);
            Lbl_IdProfe.Text = TablaProfes.Rows[Cb_Prof.SelectedIndex]["IdProfe"].ToString();
        }
        private void ChB_Lunes_CheckedChanged(object sender, EventArgs e)
        {
            if(ChB_Lunes.Checked)
            {
                CB_LunesI.Enabled = true;
                CB_LunesF.Enabled = true;
                LlenarComboDias(CB_LunesI,CB_LunesF);
            }
            else
            {
                CB_LunesI.Enabled = false;
                CB_LunesF.Enabled = false;
            }
        }
        private void ChB_Martes_CheckedChanged(object sender, EventArgs e)
        {
            if(ChB_Martes.Checked)
            {
                CB_MartesI.Enabled = true;
                CB_MartesF.Enabled = true;
                LlenarComboDias(CB_MartesI, CB_MartesF);
            }
            else
            {
                CB_MartesI.Enabled = false;
                CB_MartesF.Enabled = false;
            }
        }
        private void ChB_Miercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_Miercoles.Checked)
            {
                CB_MiercolesI.Enabled = true;
                CB_MiercolesF.Enabled = true;
                LlenarComboDias(CB_MiercolesI, CB_MiercolesF);
            }
            else
            {
                CB_MiercolesI.Enabled = false;
                CB_MiercolesF.Enabled = false;
            }
        }
        private void ChB_Jueves_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_Jueves.Checked)
            {
                CB_JuevesI.Enabled = true;
                CB_JuevesF.Enabled = true;
                LlenarComboDias(CB_JuevesI, CB_JuevesF);
            }
            else
            {
                CB_JuevesI.Enabled = false;
                CB_JuevesF.Enabled = false;
            }
        }
        private void ChB_Viernes_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_Viernes.Checked)
            {
                CB_ViernesI.Enabled = true;
                CB_ViernesF.Enabled = true;
                LlenarComboDias(CB_ViernesI, CB_ViernesF);
            }
            else
            {
                CB_ViernesI.Enabled = false;
                CB_ViernesF.Enabled = false;
            }
        }
        public void LlenarComboDias(ComboBox comboBoxI,ComboBox comboBoxF)
        {
            comboBoxI.Items.Clear();
            comboBoxF.Items.Clear();
            if(Cb_Turno.Text == "Matutino")
            {
                int p = 7, f = 8;
                for (int i = 0; i < 7; i++)
                {
                    comboBoxI.Items.Add(p+ ":00");
                    comboBoxF.Items.Add(f + ":00");
                    p++;
                    f++;
                }
            }
            if (Cb_Turno.Text == "Vespertino")
            {
                int p = 15, f = 16;
                for (int i = 0; i < 7; i++)
                {
                    comboBoxI.Items.Add(p + ":00");
                    comboBoxF.Items.Add(f + ":00");
                    p++;
                    f++;
                }
            }
        }
    }
}
