namespace Proyecto_Final.Forms
{
    partial class Crear_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Rol = new System.Windows.Forms.ComboBox();
            this.Dgv_Profes = new System.Windows.Forms.DataGridView();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).BeginInit();
            this.Gb_Acciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.textBox2);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.textBox1);
            this.Gb_Datos.Controls.Add(this.Btn_Nombre);
            this.Gb_Datos.Controls.Add(this.Txt_Nombre);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Controls.Add(this.Txt_Rol);
            this.Gb_Datos.Location = new System.Drawing.Point(52, 233);
            this.Gb_Datos.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_Datos.Size = new System.Drawing.Size(308, 105);
            this.Gb_Datos.TabIndex = 21;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 77);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '♥';
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 11;
            // 
            // Btn_Nombre
            // 
            this.Btn_Nombre.AutoSize = true;
            this.Btn_Nombre.Location = new System.Drawing.Point(6, 23);
            this.Btn_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Btn_Nombre.Name = "Btn_Nombre";
            this.Btn_Nombre.Size = new System.Drawing.Size(118, 13);
            this.Btn_Nombre.TabIndex = 0;
            this.Btn_Nombre.Text = "Nombre (p.ej. Arturo D.)";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(9, 38);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(136, 20);
            this.Txt_Nombre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto";
            // 
            // Txt_Rol
            // 
            this.Txt_Rol.FormattingEnabled = true;
            this.Txt_Rol.Items.AddRange(new object[] {
            "Prefecto",
            "Administrador"});
            this.Txt_Rol.Location = new System.Drawing.Point(159, 38);
            this.Txt_Rol.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Rol.Name = "Txt_Rol";
            this.Txt_Rol.Size = new System.Drawing.Size(82, 21);
            this.Txt_Rol.TabIndex = 8;
            // 
            // Dgv_Profes
            // 
            this.Dgv_Profes.AllowUserToAddRows = false;
            this.Dgv_Profes.AllowUserToDeleteRows = false;
            this.Dgv_Profes.AllowUserToOrderColumns = true;
            this.Dgv_Profes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Profes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Profes.Location = new System.Drawing.Point(11, 11);
            this.Dgv_Profes.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_Profes.Name = "Dgv_Profes";
            this.Dgv_Profes.ReadOnly = true;
            this.Dgv_Profes.RowHeadersWidth = 62;
            this.Dgv_Profes.RowTemplate.Height = 28;
            this.Dgv_Profes.Size = new System.Drawing.Size(629, 197);
            this.Dgv_Profes.TabIndex = 20;
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Mod);
            this.Gb_Acciones.Controls.Add(this.Btn_Modificar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.Location = new System.Drawing.Point(374, 220);
            this.Gb_Acciones.Margin = new System.Windows.Forms.Padding(2);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Padding = new System.Windows.Forms.Padding(2);
            this.Gb_Acciones.Size = new System.Drawing.Size(165, 125);
            this.Gb_Acciones.TabIndex = 19;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(83, 83);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(4, 23);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(75, 27);
            this.Btn_Nuevo.TabIndex = 16;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(4, 83);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Location = new System.Drawing.Point(83, 53);
            this.Btn_Mod.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(75, 27);
            this.Btn_Mod.TabIndex = 14;
            this.Btn_Mod.Text = "Actualizar";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(4, 53);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Modificar.TabIndex = 13;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(83, 22);
            this.Btn_Agregar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(75, 27);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Crear_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 356);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Dgv_Profes);
            this.Controls.Add(this.Gb_Acciones);
            this.Name = "Crear_User";
            this.Text = "Crear_User";
            this.Load += new System.EventHandler(this.Crear_User_Load);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Profes)).EndInit();
            this.Gb_Acciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label Btn_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Txt_Rol;
        private System.Windows.Forms.DataGridView Dgv_Profes;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}