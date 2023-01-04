namespace Proyecto_Final.Forms
{
    partial class Alumno
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
            this.Dgv_Horario = new System.Windows.Forms.DataGridView();
            this.Turno = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_Semestre = new System.Windows.Forms.ComboBox();
            this.Rb_Vespertino = new System.Windows.Forms.RadioButton();
            this.Rb_Matutino = new System.Windows.Forms.RadioButton();
            this.Cb_Grupo = new System.Windows.Forms.CheckBox();
            this.Cb_Materia = new System.Windows.Forms.CheckBox();
            this.Cb_Profesor = new System.Windows.Forms.CheckBox();
            this.Ctxt_Grupo = new System.Windows.Forms.ComboBox();
            this.Ctxt_Materia = new System.Windows.Forms.ComboBox();
            this.Ctxt_Profesor = new System.Windows.Forms.ComboBox();
            this.Cb_Filtros = new System.Windows.Forms.CheckBox();
            this.Gb_Filtros = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).BeginInit();
            this.Turno.SuspendLayout();
            this.Gb_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Horario
            // 
            this.Dgv_Horario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_Horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Horario.Location = new System.Drawing.Point(12, 325);
            this.Dgv_Horario.Name = "Dgv_Horario";
            this.Dgv_Horario.RowHeadersWidth = 62;
            this.Dgv_Horario.RowTemplate.Height = 28;
            this.Dgv_Horario.Size = new System.Drawing.Size(1362, 453);
            this.Dgv_Horario.TabIndex = 0;
            // 
            // Turno
            // 
            this.Turno.Controls.Add(this.label1);
            this.Turno.Controls.Add(this.Cb_Semestre);
            this.Turno.Controls.Add(this.Rb_Vespertino);
            this.Turno.Controls.Add(this.Rb_Matutino);
            this.Turno.Location = new System.Drawing.Point(22, 12);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(226, 194);
            this.Turno.TabIndex = 1;
            this.Turno.TabStop = false;
            this.Turno.Text = "Turno y Semestre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Semestre";
            // 
            // Cb_Semestre
            // 
            this.Cb_Semestre.FormattingEnabled = true;
            this.Cb_Semestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.Cb_Semestre.Location = new System.Drawing.Point(22, 141);
            this.Cb_Semestre.Name = "Cb_Semestre";
            this.Cb_Semestre.Size = new System.Drawing.Size(174, 28);
            this.Cb_Semestre.TabIndex = 2;
            this.Cb_Semestre.SelectedIndexChanged += new System.EventHandler(this.Cb_Semestre_SelectedIndexChanged);
            // 
            // Rb_Vespertino
            // 
            this.Rb_Vespertino.AutoSize = true;
            this.Rb_Vespertino.Location = new System.Drawing.Point(17, 81);
            this.Rb_Vespertino.Name = "Rb_Vespertino";
            this.Rb_Vespertino.Size = new System.Drawing.Size(111, 24);
            this.Rb_Vespertino.TabIndex = 1;
            this.Rb_Vespertino.TabStop = true;
            this.Rb_Vespertino.Text = "Vespertino";
            this.Rb_Vespertino.UseVisualStyleBackColor = true;
            this.Rb_Vespertino.CheckedChanged += new System.EventHandler(this.Rb_Vespertino_CheckedChanged);
            // 
            // Rb_Matutino
            // 
            this.Rb_Matutino.AutoSize = true;
            this.Rb_Matutino.Location = new System.Drawing.Point(17, 50);
            this.Rb_Matutino.Name = "Rb_Matutino";
            this.Rb_Matutino.Size = new System.Drawing.Size(96, 24);
            this.Rb_Matutino.TabIndex = 0;
            this.Rb_Matutino.TabStop = true;
            this.Rb_Matutino.Text = "Matutino";
            this.Rb_Matutino.UseVisualStyleBackColor = true;
            this.Rb_Matutino.CheckedChanged += new System.EventHandler(this.Rb_Matutino_CheckedChanged);
            // 
            // Cb_Grupo
            // 
            this.Cb_Grupo.AutoSize = true;
            this.Cb_Grupo.Location = new System.Drawing.Point(17, 30);
            this.Cb_Grupo.Name = "Cb_Grupo";
            this.Cb_Grupo.Size = new System.Drawing.Size(80, 24);
            this.Cb_Grupo.TabIndex = 2;
            this.Cb_Grupo.Text = "Grupo";
            this.Cb_Grupo.UseVisualStyleBackColor = true;
            this.Cb_Grupo.CheckedChanged += new System.EventHandler(this.Cb_Grupo_CheckedChanged);
            // 
            // Cb_Materia
            // 
            this.Cb_Materia.AutoSize = true;
            this.Cb_Materia.Location = new System.Drawing.Point(17, 104);
            this.Cb_Materia.Name = "Cb_Materia";
            this.Cb_Materia.Size = new System.Drawing.Size(88, 24);
            this.Cb_Materia.TabIndex = 3;
            this.Cb_Materia.Text = "Materia";
            this.Cb_Materia.UseVisualStyleBackColor = true;
            this.Cb_Materia.CheckedChanged += new System.EventHandler(this.Cb_Materia_CheckedChanged);
            // 
            // Cb_Profesor
            // 
            this.Cb_Profesor.AutoSize = true;
            this.Cb_Profesor.Location = new System.Drawing.Point(17, 181);
            this.Cb_Profesor.Name = "Cb_Profesor";
            this.Cb_Profesor.Size = new System.Drawing.Size(95, 24);
            this.Cb_Profesor.TabIndex = 4;
            this.Cb_Profesor.Text = "Profesor";
            this.Cb_Profesor.UseVisualStyleBackColor = true;
            this.Cb_Profesor.CheckedChanged += new System.EventHandler(this.Cb_Profesor_CheckedChanged);
            // 
            // Ctxt_Grupo
            // 
            this.Ctxt_Grupo.FormattingEnabled = true;
            this.Ctxt_Grupo.Location = new System.Drawing.Point(17, 60);
            this.Ctxt_Grupo.Name = "Ctxt_Grupo";
            this.Ctxt_Grupo.Size = new System.Drawing.Size(313, 28);
            this.Ctxt_Grupo.TabIndex = 5;
            // 
            // Ctxt_Materia
            // 
            this.Ctxt_Materia.FormattingEnabled = true;
            this.Ctxt_Materia.Location = new System.Drawing.Point(17, 134);
            this.Ctxt_Materia.Name = "Ctxt_Materia";
            this.Ctxt_Materia.Size = new System.Drawing.Size(313, 28);
            this.Ctxt_Materia.TabIndex = 6;
            // 
            // Ctxt_Profesor
            // 
            this.Ctxt_Profesor.FormattingEnabled = true;
            this.Ctxt_Profesor.Location = new System.Drawing.Point(17, 211);
            this.Ctxt_Profesor.Name = "Ctxt_Profesor";
            this.Ctxt_Profesor.Size = new System.Drawing.Size(313, 28);
            this.Ctxt_Profesor.TabIndex = 7;
            // 
            // Cb_Filtros
            // 
            this.Cb_Filtros.AutoSize = true;
            this.Cb_Filtros.Location = new System.Drawing.Point(332, 14);
            this.Cb_Filtros.Name = "Cb_Filtros";
            this.Cb_Filtros.Size = new System.Drawing.Size(78, 24);
            this.Cb_Filtros.TabIndex = 8;
            this.Cb_Filtros.Text = "Filtros";
            this.Cb_Filtros.UseVisualStyleBackColor = true;
            this.Cb_Filtros.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);
            // 
            // Gb_Filtros
            // 
            this.Gb_Filtros.Controls.Add(this.Ctxt_Grupo);
            this.Gb_Filtros.Controls.Add(this.Cb_Grupo);
            this.Gb_Filtros.Controls.Add(this.Ctxt_Profesor);
            this.Gb_Filtros.Controls.Add(this.Cb_Profesor);
            this.Gb_Filtros.Controls.Add(this.Ctxt_Materia);
            this.Gb_Filtros.Controls.Add(this.Cb_Materia);
            this.Gb_Filtros.Location = new System.Drawing.Point(290, 44);
            this.Gb_Filtros.Name = "Gb_Filtros";
            this.Gb_Filtros.Size = new System.Drawing.Size(358, 257);
            this.Gb_Filtros.TabIndex = 9;
            this.Gb_Filtros.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(500, 12);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(120, 36);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 790);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Gb_Filtros);
            this.Controls.Add(this.Cb_Filtros);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.Dgv_Horario);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Horario)).EndInit();
            this.Turno.ResumeLayout(false);
            this.Turno.PerformLayout();
            this.Gb_Filtros.ResumeLayout(false);
            this.Gb_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Horario;
        private System.Windows.Forms.GroupBox Turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_Semestre;
        private System.Windows.Forms.RadioButton Rb_Vespertino;
        private System.Windows.Forms.RadioButton Rb_Matutino;
        private System.Windows.Forms.CheckBox Cb_Grupo;
        private System.Windows.Forms.CheckBox Cb_Materia;
        private System.Windows.Forms.CheckBox Cb_Profesor;
        private System.Windows.Forms.ComboBox Ctxt_Grupo;
        private System.Windows.Forms.ComboBox Ctxt_Materia;
        private System.Windows.Forms.ComboBox Ctxt_Profesor;
        private System.Windows.Forms.CheckBox Cb_Filtros;
        private System.Windows.Forms.GroupBox Gb_Filtros;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}