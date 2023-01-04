using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Clases;

namespace Proyecto_Final.SQL
{
    internal class Alumno_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Horario(Alumnos alumnos)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select Grupo,Materia,Profesor,LunesI,LunesF,MartesI,MartesF,MiercolesI,MiercolesF,JuevesI,JuevesF,ViernesI,ViernesF from Clases where Turno = @Turno and Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Turno", alumnos.Turno);
                    cmdSelect.Parameters.AddWithValue("@Semestre", alumnos.Semestre);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return tablaClases;
            }
        }
        public DataTable Buscar_Horario(Alumnos alumnos)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select Grupo,Materia,Profesor,LunesI,LunesF,MartesI,MartesF,MiercolesI,MiercolesF,JuevesI,JuevesF,ViernesI,ViernesF from Clases where Turno = @Turno and Semestre = @Semestre " + alumnos.Sentencia;
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Turno", alumnos.Turno);
                    cmdSelect.Parameters.AddWithValue("@Semestre", alumnos.Semestre);
                    if(alumnos.Grupo != "")
                    {
                        cmdSelect.Parameters.AddWithValue("@Grupo", alumnos.Grupo);
                    }
                    if(alumnos.Materia != "")
                    {
                        cmdSelect.Parameters.AddWithValue("@Materia", alumnos.Materia);
                    }
                    if(alumnos.Profesor != "")
                    {
                        cmdSelect.Parameters.AddWithValue("@Profesor", alumnos.Profesor);
                    }                                      
 
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return tablaClases;
            }
        }
        public DataTable LlenaComboMaterias(string semestre)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaMaterias = new DataTable();
                string sentencia = "Select Nombre from Materias Where Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Semestre", semestre);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaMaterias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return TablaMaterias;
            }
        }
        public string[] LlenaComboProfes(string semestre)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                string[] arra = new string[0];
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaRoles = new DataTable();
                string sentencia = "Select Nombre,PApellido,SApellido from Profesores Where Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Semestre", semestre);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaRoles);
                    string[] array = new string[TablaRoles.Rows.Count];

                    for (int i = 0; i <= TablaRoles.Rows.Count - 1; i++)
                    {
                        array[i] = TablaRoles.Rows[i]["Nombre"].ToString() + " " + TablaRoles.Rows[i]["PApellido"].ToString() + " " + TablaRoles.Rows[i]["SApellido"].ToString();
                    }
                    return array;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return arra;
            }
        }
        public string[] LlenaComboGrupo(Alumnos alumnos)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                string[] arra = new string[0];
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaGrupo = new DataTable();
                string sentencia = "Select Grupo from Clases Where Semestre = @Semestre and Turno = @Turno";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Semestre", alumnos.Semestre);
                    cmdSelect.Parameters.AddWithValue("@Turno", alumnos.Turno);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaGrupo);

                    string[] array = new string[TablaGrupo.Rows.Count];

                    for (int i = 0; i <= TablaGrupo.Rows.Count - 1; i++)
                    {
                        array[i] = TablaGrupo.Rows[i]["Grupo"].ToString();
                    }
                    return array;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return arra;
            }
        }
        public void Mod_Prof(string Profesor, string Profe)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaMaterias = new DataTable();
                string sentencia = "update Clases set Profesor = @Profesor where Profesor = @Profe";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Profesor", Profesor);
                    cmdSelect.Parameters.AddWithValue("@Profe", Profe);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaMaterias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
