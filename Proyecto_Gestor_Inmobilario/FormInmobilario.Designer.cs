﻿namespace Proyecto_Gestor_Inmobilario
{
    partial class FormInmobilario
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
            this.label7 = new System.Windows.Forms.Label();
            this.dgInmobiliario = new System.Windows.Forms.DataGridView();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPagoMensual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbAgregado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.cbTipoInmueble = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBoxInmobiliario = new System.Windows.Forms.PictureBox();
            this.btnRegistrarInquilinos = new System.Windows.Forms.Button();
            this.lblNombre_Usuario = new System.Windows.Forms.Label();
            this.tbInmueble_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Registro Inmueble";
            // 
            // dgInmobiliario
            // 
            this.dgInmobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmobiliario.Location = new System.Drawing.Point(22, 290);
            this.dgInmobiliario.Name = "dgInmobiliario";
            this.dgInmobiliario.RowHeadersWidth = 51;
            this.dgInmobiliario.RowTemplate.Height = 24;
            this.dgInmobiliario.Size = new System.Drawing.Size(815, 214);
            this.dgInmobiliario.TabIndex = 35;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(129, 144);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(172, 22);
            this.tbDireccion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dirección";
            // 
            // tbPagoMensual
            // 
            this.tbPagoMensual.Location = new System.Drawing.Point(129, 172);
            this.tbPagoMensual.Name = "tbPagoMensual";
            this.tbPagoMensual.Size = new System.Drawing.Size(172, 22);
            this.tbPagoMensual.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pago Mensual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(422, 144);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(172, 22);
            this.tbDescripcion.TabIndex = 44;
            // 
            // tbAgregado
            // 
            this.tbAgregado.Location = new System.Drawing.Point(422, 172);
            this.tbAgregado.Name = "tbAgregado";
            this.tbAgregado.Size = new System.Drawing.Size(172, 22);
            this.tbAgregado.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Agregados";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(673, 226);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(145, 48);
            this.btnCargarImagen.TabIndex = 47;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // cbTipoInmueble
            // 
            this.cbTipoInmueble.AutoSize = true;
            this.cbTipoInmueble.Location = new System.Drawing.Point(337, 119);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(62, 16);
            this.cbTipoInmueble.TabIndex = 48;
            this.cbTipoInmueble.Text = "Tipo Inm.";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Casa",
            "Departamento",
            "Terreno"});
            this.cbTipo.Location = new System.Drawing.Point(422, 114);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(172, 24);
            this.cbTipo.TabIndex = 49;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(36, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrar.TabIndex = 50;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(149, 226);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 48);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(262, 226);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 48);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBoxInmobiliario
            // 
            this.pictureBoxInmobiliario.Image = global::Proyecto_Gestor_Inmobilario.Properties.Resources.inmueble;
            this.pictureBoxInmobiliario.Location = new System.Drawing.Point(657, 71);
            this.pictureBoxInmobiliario.Name = "pictureBoxInmobiliario";
            this.pictureBoxInmobiliario.Size = new System.Drawing.Size(180, 139);
            this.pictureBoxInmobiliario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInmobiliario.TabIndex = 38;
            this.pictureBoxInmobiliario.TabStop = false;
            // 
            // btnRegistrarInquilinos
            // 
            this.btnRegistrarInquilinos.Location = new System.Drawing.Point(374, 226);
            this.btnRegistrarInquilinos.Name = "btnRegistrarInquilinos";
            this.btnRegistrarInquilinos.Size = new System.Drawing.Size(107, 48);
            this.btnRegistrarInquilinos.TabIndex = 53;
            this.btnRegistrarInquilinos.Text = "Registrar Inquilinos";
            this.btnRegistrarInquilinos.UseVisualStyleBackColor = true;
            this.btnRegistrarInquilinos.Click += new System.EventHandler(this.btnRegistrarInquilinos_Click);
            // 
            // lblNombre_Usuario
            // 
            this.lblNombre_Usuario.AutoSize = true;
            this.lblNombre_Usuario.Location = new System.Drawing.Point(22, 511);
            this.lblNombre_Usuario.Name = "lblNombre_Usuario";
            this.lblNombre_Usuario.Size = new System.Drawing.Size(110, 16);
            this.lblNombre_Usuario.TabIndex = 54;
            this.lblNombre_Usuario.Text = "Nombre_Usuario";
            // 
            // tbInmueble_Id
            // 
            this.tbInmueble_Id.Location = new System.Drawing.Point(129, 116);
            this.tbInmueble_Id.Name = "tbInmueble_Id";
            this.tbInmueble_Id.Size = new System.Drawing.Size(172, 22);
            this.tbInmueble_Id.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Inmueble Id";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(487, 226);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(107, 48);
            this.btnReportes.TabIndex = 57;
            this.btnReportes.Text = "Ver Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FormInmobilario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 535);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.tbInmueble_Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNombre_Usuario);
            this.Controls.Add(this.btnRegistrarInquilinos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbTipoInmueble);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.tbAgregado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPagoMensual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxInmobiliario);
            this.Controls.Add(this.dgInmobiliario);
            this.Controls.Add(this.label7);
            this.Name = "FormInmobilario";
            this.Text = "Form Inmobilario";
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInmobiliario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgInmobiliario;
        private System.Windows.Forms.PictureBox pictureBoxInmobiliario;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPagoMensual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbAgregado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Label cbTipoInmueble;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrarInquilinos;
        private System.Windows.Forms.Label lblNombre_Usuario;
        private System.Windows.Forms.TextBox tbInmueble_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReportes;
    }
}