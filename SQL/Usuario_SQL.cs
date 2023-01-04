using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Clases;
using Proyecto_Final.Forms;

namespace Proyecto_Final.SQL
{
    internal class Usuario_SQL
    {
        public string Mensaje { get; set; }

        public bool ReadAll(string Usuarios)
        {
            DataTable tablaUsuarios = new DataTable();
            bool consulta = false;

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Users where Usuario = @Usuario;";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Usuario", Usuarios);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaUsuarios);

                    if (tablaUsuarios.Rows.Count > 0)
                    {
                        Mensaje = "Usuario ya registrado";
                    }
                    else
                    {
                        consulta = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return consulta;
        }
        public bool NewUser(Usuario usuarios)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into Users Values (@Id,@User,HASHBYTES('SHA1',@Contra),@Level,@Nombre);";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", usuarios.Id);
                Consulta.Parameters.AddWithValue("@User", usuarios.UserName);
                Consulta.Parameters.AddWithValue("@Contra", usuarios.Password);
                Consulta.Parameters.AddWithValue("@Level", usuarios.UserLevel);
                Consulta.Parameters.AddWithValue("@Nombre", usuarios.Name);

                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Usuario registrado correctamente";
                        Operacion = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Operacion;
        }
        public bool UserUpdate(Usuario usuarios)
        {
            bool x = false;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;

                int filasafectadas;
                    if(usuarios.Password != "")
                    { 
                        string sentencia = @"update Users set Usuario = @User, Contrasena = HASHBYTES('SHA1',@Contra), Nivel_Usuario = @Nivel,Nombre = @NOMBRE where IdUsuario = @Id";
                        cmdCreate = new SqlCommand(sentencia, conexion);
                    }
                    else
                    {
                        string sentencia = @"update Users set Usuario = @User, Nivel_Usuario = @Nivel,Nombre = @NOMBRE where IdUsuario = @Id";
                        cmdCreate = new SqlCommand(sentencia, conexion);
                    }
                    
                    cmdCreate.Parameters.AddWithValue("@User", usuarios.UserName);
                    cmdCreate.Parameters.AddWithValue("@Contra", usuarios.Password);
                    cmdCreate.Parameters.AddWithValue("@Nivel", usuarios.UserLevel);
                    cmdCreate.Parameters.AddWithValue("@NOMBRE", usuarios.Name);
                    cmdCreate.Parameters.AddWithValue("@Id", usuarios.Id);


                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Usuario actualizado exitosamente";
                        x = true;
                    }

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return x;
        }
        public bool Eliminar_Tabla(int i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Users where IdUsuario = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", i);
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Usuario eliminado exitosamente";
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
        public DataTable Mostrar_Usuario()
        {
            DataTable tablaUsuarios = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select IdUsuario,Usuario,Nivel_Usuario,Nombre from Users";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaUsuarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaUsuarios;
            }
        }

        
        public int generaIdUsuario(int Id)
        {
            int i = 0;
            while (i == 0)
            {
                DataTable tablaUsers = new DataTable();
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    SqlCommand cmdSelect;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sentencia = @"Select * from Users where IdUsuario = @Id";
                    try
                    {
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@Id", Id);
                        adapter.SelectCommand = cmdSelect;
                        conexion.Open();
                        adapter.Fill(tablaUsers);

                        if (tablaUsers.Rows.Count > 0)
                        {
                            Id++;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return Id;
        }
        public bool validarUser(Usuario user)
        {
            DataTable tablaUsers = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = @"Select * from Users where Nombre = @Nombre and Usuario = @User";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Nombre", user.Name);
                    cmdSelect.Parameters.AddWithValue("@User", user.UserName);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaUsers);

                    if (tablaUsers.Rows.Count > 0)
                    {
                        Mensaje = "Este usuario ya esta registrado";
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
            }
            return false;
        }
    }
}
