namespace Proyecto_Final.Forms
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.Btn_Usuarios = new System.Windows.Forms.Button();
            this.Btn_Clases = new System.Windows.Forms.Button();
            this.Btn_Materias = new System.Windows.Forms.Button();
            this.Btn_Prof = new System.Windows.Forms.Button();
            this.Panel_Forms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.Btn_Usuarios);
            this.panel1.Controls.Add(this.Btn_Clases);
            this.panel1.Controls.Add(this.Btn_Materias);
            this.panel1.Controls.Add(this.Btn_Prof);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 870);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Btn_Usuarios
            // 
            this.Btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Usuarios.Location = new System.Drawing.Point(0, 189);
            this.Btn_Usuarios.Name = "Btn_Usuarios";
            this.Btn_Usuarios.Size = new System.Drawing.Size(200, 63);
            this.Btn_Usuarios.TabIndex = 3;
            this.Btn_Usuarios.Text = "Usuarios";
            this.Btn_Usuarios.UseVisualStyleBackColor = true;
            this.Btn_Usuarios.Click += new System.EventHandler(this.Btn_Usuarios_Click);
            // 
            // Btn_Clases
            // 
            this.Btn_Clases.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Clases.Location = new System.Drawing.Point(0, 126);
            this.Btn_Clases.Name = "Btn_Clases";
            this.Btn_Clases.Size = new System.Drawing.Size(200, 63);
            this.Btn_Clases.TabIndex = 2;
            this.Btn_Clases.Text = "Clases";
            this.Btn_Clases.UseVisualStyleBackColor = true;
            this.Btn_Clases.Click += new System.EventHandler(this.Btn_Clases_Click);
            // 
            // Btn_Materias
            // 
            this.Btn_Materias.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Materias.Location = new System.Drawing.Point(0, 63);
            this.Btn_Materias.Name = "Btn_Materias";
            this.Btn_Materias.Size = new System.Drawing.Size(200, 63);
            this.Btn_Materias.TabIndex = 1;
            this.Btn_Materias.Text = "Materias";
            this.Btn_Materias.UseVisualStyleBackColor = true;
            this.Btn_Materias.Click += new System.EventHandler(this.Btn_Materias_Click);
            // 
            // Btn_Prof
            // 
            this.Btn_Prof.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Prof.Location = new System.Drawing.Point(0, 0);
            this.Btn_Prof.Name = "Btn_Prof";
            this.Btn_Prof.Size = new System.Drawing.Size(200, 63);
            this.Btn_Prof.TabIndex = 0;
            this.Btn_Prof.Text = "Profesores";
            this.Btn_Prof.UseVisualStyleBackColor = true;
            this.Btn_Prof.Click += new System.EventHandler(this.Btn_Prof_Click);
            // 
            // Panel_Forms
            // 
            this.Panel_Forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Forms.Location = new System.Drawing.Point(200, 0);
            this.Panel_Forms.Name = "Panel_Forms";
            this.Panel_Forms.Size = new System.Drawing.Size(1855, 870);
            this.Panel_Forms.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2055, 870);
            this.Controls.Add(this.Panel_Forms);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Btn_Usuarios;
        private System.Windows.Forms.Button Btn_Clases;
        private System.Windows.Forms.Button Btn_Materias;
        private System.Windows.Forms.Button Btn_Prof;
        private System.Windows.Forms.Panel Panel_Forms;
    }
}