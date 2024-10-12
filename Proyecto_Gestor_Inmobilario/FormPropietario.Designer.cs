namespace Proyecto_Gestor_Inmobilario
{
    partial class FormPropietario
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
            this.dgPropietarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrarPropiedad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPropietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPropietarios
            // 
            this.dgPropietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPropietarios.Location = new System.Drawing.Point(323, 65);
            this.dgPropietarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPropietarios.Name = "dgPropietarios";
            this.dgPropietarios.RowHeadersWidth = 51;
            this.dgPropietarios.RowTemplate.Height = 24;
            this.dgPropietarios.Size = new System.Drawing.Size(403, 352);
            this.dgPropietarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(23, 268);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 44);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(149, 82);
            this.tbNombreCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(145, 22);
            this.tbNombreCompleto.TabIndex = 3;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(149, 110);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(145, 22);
            this.tbNombreUsuario.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(149, 135);
            this.tbDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(145, 22);
            this.tbDNI.TabIndex = 7;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(149, 164);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(145, 22);
            this.tbCorreo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(149, 192);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(145, 22);
            this.tbContraseña.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contraseña";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(149, 220);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(145, 22);
            this.tbCelular.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Celular";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(149, 268);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 44);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(259, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Registro Propietarios";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(83, 368);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 44);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 318);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 44);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrarPropiedad
            // 
            this.btnRegistrarPropiedad.Location = new System.Drawing.Point(149, 318);
            this.btnRegistrarPropiedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarPropiedad.Name = "btnRegistrarPropiedad";
            this.btnRegistrarPropiedad.Size = new System.Drawing.Size(111, 44);
            this.btnRegistrarPropiedad.TabIndex = 18;
            this.btnRegistrarPropiedad.Text = "Registrar Propiedad";
            this.btnRegistrarPropiedad.UseVisualStyleBackColor = true;
            this.btnRegistrarPropiedad.Click += new System.EventHandler(this.btnRegistrarPropiedad_Click);
            // 
            // FormPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 430);
            this.Controls.Add(this.btnRegistrarPropiedad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPropietarios);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPropietario";
            this.Text = "Form Propietarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgPropietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPropietarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrarPropiedad;
    }
}