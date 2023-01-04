using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final;
using Proyecto_Final.Forms;

namespace Proyecto_Final
{
    internal class Iniciar
    {   
        public bool In_Sesion(string Usuer,string Contra)
        {
            DataTable tablaUsuarios = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = @"Select * from Users where Usuario = @idusuario and Contrasena = HASHBYTES('SHA1',@Con);";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@idusuario", Usuer);
                    cmdSelect.Parameters.AddWithValue("@Con", Contra);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaUsuarios);

                    if (tablaUsuarios.Rows.Count > 0)
                    {
                        string nivel = tablaUsuarios.Rows[0]["Nivel_Usuario"].ToString();
                        if (nivel == "0")
                        {
                            Prefecto prefecto = new Prefecto();
                            prefecto.ShowDialog();
                            return true;
                        }
                        if (nivel == "1")
                        {
                            Admin admin = new Admin();
                            admin.ShowDialog();
                            return true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usario y/o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
    }
}
