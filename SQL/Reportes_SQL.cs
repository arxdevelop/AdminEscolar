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
    internal class Reportes_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Reportes()
        {
            DataTable tablaReportes = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Reportes ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaReportes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaReportes;
            }
        }
        public DataTable Llenar_Grupo(string turno)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where Turno = @Turno";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);

                    adapter.SelectCommand = cmdSelect;
                    cmdSelect.Parameters.AddWithValue("@Turno", turno);
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }

                return tablaClases;
            }
        }
        public DataTable Llenar_Materia(string grupo)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where Grupo = @Grupo";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    cmdSelect.Parameters.AddWithValue("@Grupo", grupo);
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }

                return tablaClases;
            }
        }

    }
}
