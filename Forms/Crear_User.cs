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
    public partial class Crear_User : Form
    {
        public Crear_User()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            Acciones(false);
            Btn_Agregar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        public void Mostrar()
        {
            Usuario_SQL usuario_SQL = new Usuario_SQL();
            Dgv_Profes.DataSource = usuario_SQL.Mostrar_Usuario();
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

        private void Crear_User_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Validar())
                if (ValidarRol())
                {
                    Usuario usuarios = new Usuario();
                    Usuario_SQL usuarios_SQL = new Usuario_SQL();

                    usuarios.Name = Txt_Nombre.Text;
                    usuarios.UserLevel = Txt_Rol.SelectedIndex;
                    usuarios.UserName = textBox1.Text;
                    usuarios.Password = textBox2.Text;


                    if (usuarios_SQL.validarUser(usuarios)) {                     
                        usuarios.Id = usuarios_SQL.generaIdUsuario(1);
                    if (usuarios_SQL.NewUser(usuarios))
                    {
                        MessageBox.Show(usuarios_SQL.Mensaje);
                        Inicio();
                    }
                    else
                    {
                        MessageBox.Show(usuarios_SQL.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show(usuarios_SQL.Mensaje);
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
            if (ValidarMod())
            {
                int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
                Usuario_SQL usuario_SQL = new Usuario_SQL();
                Usuario usuario = new Usuario();
                usuario.Id = Convert.ToInt32(Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
                usuario.Name = Txt_Nombre.Text;
                usuario.UserLevel = Txt_Rol.SelectedIndex;
                usuario.UserName = textBox1.Text;
                usuario.Password = textBox2.Text;

                if (ValidarRol())
                {
                    usuario_SQL.UserUpdate(usuario);
                    MessageBox.Show(usuario_SQL.Mensaje);
                    Inicio();

                }
            }
        }
        public void Llenar()
        {
            int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
            Txt_Nombre.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[3].Value.ToString();
            Txt_Rol.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[2].Value.ToString();
            if (Txt_Rol.Text == "1")
                Txt_Rol.Text = "Administrador";
            if (Txt_Rol.Text == "0")
                Txt_Rol.Text = "Prefecto";
            textBox1.Text = Dgv_Profes.Rows[RenglonSeleccionado].Cells[1].Value.ToString();
            
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Usuario_SQL usuario = new Usuario_SQL();
            int RenglonSeleccionado = Dgv_Profes.CurrentRow.Index;
            int id = Convert.ToInt32(Dgv_Profes.Rows[RenglonSeleccionado].Cells[0].Value.ToString());
            DialogResult Resultado = MessageBox.Show("¿Deseas eliminar el usuario con Id " + id + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resultado == DialogResult.Yes)
            {
                if (usuario.Eliminar_Tabla(id))
                {
                    MessageBox.Show(usuario.Mensaje);
                }
                else
                {
                    MessageBox.Show(usuario.Mensaje);
                }
            }
            Inicio();


        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        public bool ValidarMod()
        {
            if (Txt_Nombre.Text == "" || textBox1.Text == "" || Txt_Rol.Text == "" )
            {
                    MessageBox.Show("Faltan campos por llenar");
                    return false;
            }
           
            return true;
        }

        public bool ValidarRol()
        {
            if (Txt_Rol.Text != "Administrador" && Txt_Rol.Text != "Prefecto")
            { 
                MessageBox.Show("El puesto seleccionado no es válido");
                return false;
            }
            return true;
        }
    }
    
}
