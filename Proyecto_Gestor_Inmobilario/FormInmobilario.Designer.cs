namespace Proyecto_Gestor_Inmobilario
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.imagePicture = new System.Windows.Forms.PictureBox();
            this.btnRegistrarInquilinos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(266, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 34;
            this.label7.Text = "Registro Inmueble";
            // 
            // dgInmobiliario
            // 
            this.dgInmobiliario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmobiliario.Location = new System.Drawing.Point(27, 266);
            this.dgInmobiliario.Name = "dgInmobiliario";
            this.dgInmobiliario.RowHeadersWidth = 51;
            this.dgInmobiliario.RowTemplate.Height = 24;
            this.dgInmobiliario.Size = new System.Drawing.Size(715, 214);
            this.dgInmobiliario.TabIndex = 35;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 92);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(145, 22);
            this.tbNombre.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(134, 120);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(145, 22);
            this.tbDireccion.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Dirección";
            // 
            // tbPagoMensual
            // 
            this.tbPagoMensual.Location = new System.Drawing.Point(134, 148);
            this.tbPagoMensual.Name = "tbPagoMensual";
            this.tbPagoMensual.Size = new System.Drawing.Size(145, 22);
            this.tbPagoMensual.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pago Mensual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Descripción";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(379, 120);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(145, 22);
            this.tbDescripcion.TabIndex = 44;
            // 
            // tbAgregado
            // 
            this.tbAgregado.Location = new System.Drawing.Point(379, 148);
            this.tbAgregado.Name = "tbAgregado";
            this.tbAgregado.Size = new System.Drawing.Size(145, 22);
            this.tbAgregado.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Agregados";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(578, 202);
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
            this.cbTipoInmueble.Location = new System.Drawing.Point(294, 95);
            this.cbTipoInmueble.Name = "cbTipoInmueble";
            this.cbTipoInmueble.Size = new System.Drawing.Size(62, 16);
            this.cbTipoInmueble.TabIndex = 48;
            this.cbTipoInmueble.Text = "Tipo Inm.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(379, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 49;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(27, 202);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 48);
            this.btnRegistrar.TabIndex = 50;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(154, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 48);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(281, 202);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 48);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // imagePicture
            // 
            this.imagePicture.Image = global::Proyecto_Gestor_Inmobilario.Properties.Resources.inmueble;
            this.imagePicture.Location = new System.Drawing.Point(562, 49);
            this.imagePicture.Name = "imagePicture";
            this.imagePicture.Size = new System.Drawing.Size(180, 139);
            this.imagePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePicture.TabIndex = 38;
            this.imagePicture.TabStop = false;
            // 
            // btnRegistrarInquilinos
            // 
            this.btnRegistrarInquilinos.Location = new System.Drawing.Point(408, 202);
            this.btnRegistrarInquilinos.Name = "btnRegistrarInquilinos";
            this.btnRegistrarInquilinos.Size = new System.Drawing.Size(121, 48);
            this.btnRegistrarInquilinos.TabIndex = 53;
            this.btnRegistrarInquilinos.Text = "Registrar Inquilinos";
            this.btnRegistrarInquilinos.UseVisualStyleBackColor = true;
            this.btnRegistrarInquilinos.Click += new System.EventHandler(this.btnRegistrarInquilinos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "label6";
            // 
            // FormInmobilario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 517);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistrarInquilinos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.imagePicture);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgInmobiliario);
            this.Controls.Add(this.label7);
            this.Name = "FormInmobilario";
            this.Text = "Form Inmobilario";
            ((System.ComponentModel.ISupportInitialize)(this.dgInmobiliario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgInmobiliario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagePicture;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrarInquilinos;
        private System.Windows.Forms.Label label6;
    }
}