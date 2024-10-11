using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Repositories;
using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormPagos : Form
    {
        private PagoService pagoService;
        public FormPagos()
        {
            InitializeComponent();
            pagoService = new PagoService();
            CargarPagos();
        }

        private void CargarPagos()
        {
            dgListPagos.DataSource = null;  
            dgListPagos.DataSource = pagoService.ObtenerPagos();

        }

        private void btnRegistarPago_Click(object sender, EventArgs e)
        {
            // Validar los campos de entrada
            if (string.IsNullOrWhiteSpace(txtNombrePago.Text) || string.IsNullOrWhiteSpace(txtMontoPago.Text))
            {
                MessageBox.Show("Por favor, ingresa todos los campos requeridos.");
                return;
            }


            Pago nuevoPago = new Pago
            {
                Nombre = txtNombrePago.Text,
                Monto = decimal.Parse(txtMontoPago.Text),
                MetodoPago = cbMetodoPago.SelectedItem.ToString(),
                Estado = cbEstadoPago.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                PropiedadId = 1
            };


            pagoService.AgregarPago(nuevoPago);
            MessageBox.Show("Pago registrado con éxito.");


            CargarPagos();

            txtNombrePago.Clear();
            txtMontoPago.Clear();
            cbMetodoPago.SelectedIndex = -1;
            cbEstadoPago.SelectedIndex = -1;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
