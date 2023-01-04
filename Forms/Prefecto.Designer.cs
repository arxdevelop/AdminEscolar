namespace Proyecto_Final.Forms
{
    partial class Prefecto
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
            this.Dgv_Reportes = new System.Windows.Forms.DataGridView();
            this.Gb_Acciones = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Gb_Datos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cb_Grupo = new System.Windows.Forms.ComboBox();
            this.Cb_Turno = new System.Windows.Forms.ComboBox();
            this.Cb_Materia = new System.Windows.Forms.ComboBox();
            this.Dtp_DiaReporte = new System.Windows.Forms.DateTimePicker();
            this.Txt_Reporte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reportes)).BeginInit();
            this.Gb_Acciones.SuspendLayout();
            this.Gb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Reportes
            // 
            this.Dgv_Reportes.AllowUserToAddRows = false;
            this.Dgv_Reportes.AllowUserToDeleteRows = false;
            this.Dgv_Reportes.AllowUserToOrderColumns = true;
            this.Dgv_Reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Reportes.Location = new System.Drawing.Point(12, 12);
            this.Dgv_Reportes.Name = "Dgv_Reportes";
            this.Dgv_Reportes.ReadOnly = true;
            this.Dgv_Reportes.RowHeadersWidth = 62;
            this.Dgv_Reportes.RowTemplate.Height = 28;
            this.Dgv_Reportes.Size = new System.Drawing.Size(1279, 367);
            this.Dgv_Reportes.TabIndex = 18;
            // 
            // Gb_Acciones
            // 
            this.Gb_Acciones.Controls.Add(this.Btn_Cancelar);
            this.Gb_Acciones.Controls.Add(this.Btn_Nuevo);
            this.Gb_Acciones.Controls.Add(this.Btn_Eliminar);
            this.Gb_Acciones.Controls.Add(this.Btn_Agregar);
            this.Gb_Acciones.Location = new System.Drawing.Point(1043, 400);
            this.Gb_Acciones.Name = "Gb_Acciones";
            this.Gb_Acciones.Size = new System.Drawing.Size(248, 139);
            this.Gb_Acciones.TabIndex = 19;
            this.Gb_Acciones.TabStop = false;
            this.Gb_Acciones.Text = "Acciones";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(125, 81);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Cancelar.TabIndex = 17;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(6, 35);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(113, 41);
            this.Btn_Nuevo.TabIndex = 16;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(6, 82);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Eliminar.TabIndex = 15;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(125, 34);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(113, 41);
            this.Btn_Agregar.TabIndex = 12;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Gb_Datos
            // 
            this.Gb_Datos.Controls.Add(this.label4);
            this.Gb_Datos.Controls.Add(this.Txt_Reporte);
            this.Gb_Datos.Controls.Add(this.Dtp_DiaReporte);
            this.Gb_Datos.Controls.Add(this.Cb_Materia);
            this.Gb_Datos.Controls.Add(this.Cb_Turno);
            this.Gb_Datos.Controls.Add(this.Cb_Grupo);
            this.Gb_Datos.Controls.Add(this.label2);
            this.Gb_Datos.Controls.Add(this.label1);
            this.Gb_Datos.Controls.Add(this.label3);
            this.Gb_Datos.Controls.Add(this.label5);
            this.Gb_Datos.Location = new System.Drawing.Point(12, 400);
            this.Gb_Datos.Name = "Gb_Datos";
            this.Gb_Datos.Size = new System.Drawing.Size(979, 288);
            this.Gb_Datos.TabIndex = 20;
            this.Gb_Datos.TabStop = false;
            this.Gb_Datos.Text = "Datos del Reporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dia de Reporte";
            // 
            // Cb_Grupo
            // 
            this.Cb_Grupo.FormattingEnabled = true;
            this.Cb_Grupo.Location = new System.Drawing.Point(184, 59);
            this.Cb_Grupo.Name = "Cb_Grupo";
            this.Cb_Grupo.Size = new System.Drawing.Size(165, 28);
            this.Cb_Grupo.TabIndex = 17;
            this.Cb_Grupo.SelectedIndexChanged += new System.EventHandler(this.Cb_Grupo_SelectedIndexChanged);
            // 
            // Cb_Turno
            // 
            this.Cb_Turno.FormattingEnabled = true;
            this.Cb_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino"});
            this.Cb_Turno.Location = new System.Drawing.Point(13, 59);
            this.Cb_Turno.Name = "Cb_Turno";
            this.Cb_Turno.Size = new System.Drawing.Size(165, 28);
            this.Cb_Turno.TabIndex = 18;
            this.Cb_Turno.SelectedIndexChanged += new System.EventHandler(this.Cb_Turno_SelectedIndexChanged);
            // 
            // Cb_Materia
            // 
            this.Cb_Materia.FormattingEnabled = true;
            this.Cb_Materia.Location = new System.Drawing.Point(355, 59);
            this.Cb_Materia.Name = "Cb_Materia";
            this.Cb_Materia.Size = new System.Drawing.Size(165, 28);
            this.Cb_Materia.TabIndex = 19;
            this.Cb_Materia.SelectedIndexChanged += new System.EventHandler(this.Cb_Clase_SelectedIndexChanged);
            // 
            // Dtp_DiaReporte
            // 
            this.Dtp_DiaReporte.Location = new System.Drawing.Point(13, 128);
            this.Dtp_DiaReporte.Name = "Dtp_DiaReporte";
            this.Dtp_DiaReporte.Size = new System.Drawing.Size(336, 26);
            this.Dtp_DiaReporte.TabIndex = 21;
            // 
            // Txt_Reporte
            // 
            this.Txt_Reporte.Location = new System.Drawing.Point(569, 48);
            this.Txt_Reporte.Multiline = true;
            this.Txt_Reporte.Name = "Txt_Reporte";
            this.Txt_Reporte.Size = new System.Drawing.Size(385, 223);
            this.Txt_Reporte.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reporte";
            // 
            // Prefecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 700);
            this.Controls.Add(this.Gb_Datos);
            this.Controls.Add(this.Gb_Acciones);
            this.Controls.Add(this.Dgv_Reportes);
            this.Name = "Prefecto";
            this.Text = "Prefecto";
            this.Load += new System.EventHandler(this.Prefecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Reportes)).EndInit();
            this.Gb_Acciones.ResumeLayout(false);
            this.Gb_Datos.ResumeLayout(false);
            this.Gb_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Reportes;
        private System.Windows.Forms.GroupBox Gb_Acciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.GroupBox Gb_Datos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cb_Materia;
        private System.Windows.Forms.ComboBox Cb_Turno;
        private System.Windows.Forms.ComboBox Cb_Grupo;
        private System.Windows.Forms.DateTimePicker Dtp_DiaReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Reporte;
    }
}