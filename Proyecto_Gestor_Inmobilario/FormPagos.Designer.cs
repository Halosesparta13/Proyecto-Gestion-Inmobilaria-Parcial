namespace Proyecto_Gestor_Inmobilario
{
    partial class FormPagos
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
            this.dgListPagos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombrePago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstadoPago = new System.Windows.Forms.ComboBox();
            this.btnRegistarPago = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListPagos
            // 
            this.dgListPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListPagos.Location = new System.Drawing.Point(63, 181);
            this.dgListPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgListPagos.Name = "dgListPagos";
            this.dgListPagos.RowHeadersWidth = 51;
            this.dgListPagos.RowTemplate.Height = 24;
            this.dgListPagos.Size = new System.Drawing.Size(761, 174);
            this.dgListPagos.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Registro Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Gestor_Inmobilario.Properties.Resources.pagos;
            this.pictureBox1.Location = new System.Drawing.Point(535, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(300, 99);
            this.txtMontoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(110, 20);
            this.txtMontoPago.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha y Hora Actual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nombre Propiedad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Propiedad";
            // 
            // txtNombrePago
            // 
            this.txtNombrePago.Location = new System.Drawing.Point(300, 76);
            this.txtNombrePago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombrePago.Name = "txtNombrePago";
            this.txtNombrePago.Size = new System.Drawing.Size(110, 20);
            this.txtNombrePago.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Método de Pago";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Deposito",
            "Efectivo"});
            this.cbMetodoPago.Location = new System.Drawing.Point(300, 122);
            this.cbMetodoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(110, 21);
            this.cbMetodoPago.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Estado";
            // 
            // cbEstadoPago
            // 
            this.cbEstadoPago.FormattingEnabled = true;
            this.cbEstadoPago.Items.AddRange(new object[] {
            "Pagado",
            "No Pagado"});
            this.cbEstadoPago.Location = new System.Drawing.Point(300, 147);
            this.cbEstadoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEstadoPago.Name = "cbEstadoPago";
            this.cbEstadoPago.Size = new System.Drawing.Size(110, 21);
            this.cbEstadoPago.TabIndex = 55;
            // 
            // btnRegistarPago
            // 
            this.btnRegistarPago.Location = new System.Drawing.Point(434, 91);
            this.btnRegistarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistarPago.Name = "btnRegistarPago";
            this.btnRegistarPago.Size = new System.Drawing.Size(89, 33);
            this.btnRegistarPago.TabIndex = 56;
            this.btnRegistarPago.Text = "Registrar";
            this.btnRegistarPago.UseVisualStyleBackColor = true;
            this.btnRegistarPago.Click += new System.EventHandler(this.btnRegistarPago_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(434, 133);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(89, 33);
            this.BtnSalir.TabIndex = 57;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FormPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 366);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnRegistarPago);
            this.Controls.Add(this.cbEstadoPago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbMetodoPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombrePago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgListPagos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPagos";
            this.Text = "Form Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgListPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListPagos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombrePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEstadoPago;
        private System.Windows.Forms.Button btnRegistarPago;
        private System.Windows.Forms.Button BtnSalir;
    }
}