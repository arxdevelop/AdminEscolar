using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using Proyecto_Final.Clases;

namespace Proyecto_Final.SQL
{
    internal class Clases_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Clases()
        {
            DataTable tablaClases = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
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
        public bool ValidarDatos(Clase clase)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where Semestre = @Sem and Turno = @Turno and Materia = @Materia and Grupo = @Grupo";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Sem", clase.Semestre);
                    cmdSelect.Parameters.AddWithValue("@Turno", clase.Turno);
                    cmdSelect.Parameters.AddWithValue("@Materia", clase.Materia);
                    cmdSelect.Parameters.AddWithValue("@Grupo", clase.Grupo);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaClases);
                    
                    if (tablaClases.Rows.Count > 0)
                    {
                        MessageBox.Show("Esta clase ya esta registrada");
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }
        public bool ValidarHorario(Clase clase)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where "+clase.Dia+" = @Hora and Grupo = @Grupo";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Hora", clase.Hora);
                    cmdSelect.Parameters.AddWithValue("@Grupo", clase.Grupo);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaClases);

                    if (tablaClases.Rows.Count > 0)
                    {
                        MessageBox.Show("El dia "+clase.Dia+" a la hora "+clase.Hora+" ya esta registrada");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }
        }

        public DataTable LlenaComboProfes(string Sem,string Turno)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaProfes = new DataTable();
               
                string sentencia = "select IdProfe,Nombre,PApellido,SApellido from Profesores where Semestre = @Sem and Turno = @Turno";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Sem", Sem);
                    cmdSelect.Parameters.AddWithValue("@Turno", Turno);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaProfes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return TablaProfes;
            }
        }
        public DataTable LlenaComboMateria(string Sem)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaMaterias = new DataTable();

                string sentencia = "select IdMateria,Nombre from Materias where Semestre = @Sem";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Sem", Sem);
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
        public bool Registrar_Horario(Clase clase)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into Clases Values (@IdClase,@Semestre,@Turno,@NumGrupo,@Grupo,@Materia,@Profesor,@LunesI,@LunesF,@MartesI,@MartesF,@MiercolesI,@MiercolesF,@JuevesI,@JuevesF,@ViernesI,@ViernesF)";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@IdClase", clase.IdClase);
                Consulta.Parameters.AddWithValue("@Semestre", clase.Semestre);
                Consulta.Parameters.AddWithValue("@Turno", clase.Turno);
                Consulta.Parameters.AddWithValue("@NumGrupo", clase.NumGrupo);
                Consulta.Parameters.AddWithValue("@Grupo", clase.Grupo);
                Consulta.Parameters.AddWithValue("@Materia", clase.Materia);
                Consulta.Parameters.AddWithValue("@Profesor", clase.Profesor);
                Consulta.Parameters.AddWithValue("@LunesI", clase.LunesI);
                Consulta.Parameters.AddWithValue("@LunesF", clase.LunesF);
                Consulta.Parameters.AddWithValue("@MartesI", clase.MartesI);
                Consulta.Parameters.AddWithValue("@MartesF", clase.MartesF);
                Consulta.Parameters.AddWithValue("@MiercolesI", clase.MiercolesI);
                Consulta.Parameters.AddWithValue("@MiercolesF", clase.MiercolesF);
                Consulta.Parameters.AddWithValue("@JuevesI", clase.JuevesI);
                Consulta.Parameters.AddWithValue("@JuevesF", clase.JuevesF);
                Consulta.Parameters.AddWithValue("@ViernesI", clase.ViernesI);
                Consulta.Parameters.AddWithValue("@ViernesF", clase.ViernesF);

                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Clase registrada correctamente";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }
        public bool Eliminar_Clase(string IdClases)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Clases where IdClases = @IdClases";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@IdClases", IdClases);
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Clase elimidada exitosamente";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }
    }
}
