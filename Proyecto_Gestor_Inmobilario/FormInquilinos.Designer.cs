namespace Proyecto_Gestor_Inmobilario
{
    partial class FormInquilinos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgInquilinos = new System.Windows.Forms.DataGridView();
            this.dpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblNombre_Usuario = new System.Windows.Forms.Label();
            this.lblmonto_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInquilinos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(195, 295);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 46);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(195, 347);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(111, 46);
            this.btnPagos.TabIndex = 34;
            this.btnPagos.Text = "Ver Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 29);
            this.label7.TabIndex = 33;
            this.label7.Text = "Registro Inquilinos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(69, 347);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 46);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Celular";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(173, 134);
            this.tbCelular.MaxLength = 9;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(145, 22);
            this.tbCelular.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Correo";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(174, 162);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(145, 22);
            this.tbCorreo.TabIndex = 26;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(174, 77);
            this.tbDNI.MaxLength = 8;
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(145, 22);
            this.tbDNI.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "DNI";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(174, 104);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(145, 22);
            this.tbNombreCompleto.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(69, 295);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(111, 46);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrarse";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Completo";
            // 
            // dgInquilinos
            // 
            this.dgInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInquilinos.Location = new System.Drawing.Point(347, 71);
            this.dgInquilinos.Name = "dgInquilinos";
            this.dgInquilinos.RowHeadersWidth = 51;
            this.dgInquilinos.RowTemplate.Height = 24;
            this.dgInquilinos.Size = new System.Drawing.Size(419, 333);
            this.dgInquilinos.TabIndex = 18;
            // 
            // dpFechaPago
            // 
            this.dpFechaPago.Location = new System.Drawing.Point(174, 197);
            this.dpFechaPago.Name = "dpFechaPago";
            this.dpFechaPago.Size = new System.Drawing.Size(146, 22);
            this.dpFechaPago.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha Pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Monto";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(175, 256);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(23, 16);
            this.lbMonto.TabIndex = 39;
            this.lbMonto.Text = "S/.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Fecha Fin";
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Location = new System.Drawing.Point(174, 225);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(146, 22);
            this.dpFechaFin.TabIndex = 40;
            // 
            // lblNombre_Usuario
            // 
            this.lblNombre_Usuario.AutoSize = true;
            this.lblNombre_Usuario.Location = new System.Drawing.Point(53, 417);
            this.lblNombre_Usuario.Name = "lblNombre_Usuario";
            this.lblNombre_Usuario.Size = new System.Drawing.Size(110, 16);
            this.lblNombre_Usuario.TabIndex = 55;
            this.lblNombre_Usuario.Text = "Nombre_Usuario";
            // 
            // lblmonto_Total
            // 
            this.lblmonto_Total.AutoSize = true;
            this.lblmonto_Total.Location = new System.Drawing.Point(204, 255);
            this.lblmonto_Total.Name = "lblmonto_Total";
            this.lblmonto_Total.Size = new System.Drawing.Size(82, 16);
            this.lblmonto_Total.TabIndex = 56;
            this.lblmonto_Total.Text = "monto_Total";
            // 
            // FormInquilinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.lblmonto_Total);
            this.Controls.Add(this.lblNombre_Usuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpFechaPago);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgInquilinos);
            this.Name = "FormInquilinos";
            this.Text = "Form Inquilinos";
            ((System.ComponentModel.ISupportInitialize)(this.dgInquilinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgInquilinos;
        private System.Windows.Forms.DateTimePicker dpFechaPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.Label lblNombre_Usuario;
        private System.Windows.Forms.Label lblmonto_Total;
    }
}