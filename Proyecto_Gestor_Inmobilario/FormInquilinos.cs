using Proyecto_Gestor_Inmobilario.Entities;
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
    public partial class FormInquilinos : Form
    {
        private InquilinoService inquilinoService = new InquilinoService();
        private string codigoInmueble;
        private Propietario propietario;
        private string Monto;
        public FormInquilinos(string codigoInmueble, Propietario propietario, string Monto )
        {
            InitializeComponent();
            MostrarInquilinos(inquilinoService.ListarTodo(propietario.DNI, codigoInmueble));
            this.codigoInmueble = codigoInmueble;
            this.propietario = propietario;
            this.Monto = Monto;
            lblmonto_Total.Text = $"{Monto}";
            lblNombre_Usuario.Text = $"¡Bienvenido {propietario.Nombre_Completo}! | Inmueble: {codigoInmueble} | Fecha de último acceso {DateTime.Now}";
        }

        private void MostrarInquilinos(List<Inquilino> inquilinoss)
        {
            dgInquilinos.DataSource = null;
            if (inquilinoss.Count == 0)
            {
                return;
            }
            else
            {
                dgInquilinos.DataSource = inquilinoss;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string NombreCompleto = tbNombreCompleto.Text;
            string Celular = tbCelular.Text;
            string Dni = tbDNI.Text;
            string Correo = tbCorreo.Text;
            if(NombreCompleto ==""|| Celular ==""||Dni==""||Correo == "" || dpFechaPago.Text == "" || dpFechaFin.Text == "")
            {
                MessageBox.Show("Rellene todas las casillas");
                return;
            }
            Inquilino inquilino = new Inquilino()
            {
                DNI = Dni,
                Nombre_Completo = NombreCompleto,
                Correo = Correo,
                Celular = Celular,
                Fecha_Inicio_Alquiler = DateTime.Now,
                Fecha_Pago_Mensual = dpFechaPago.Value,
                Fecha_Fin_Alquiler = dpFechaFin.Value
            };
            bool registrar = inquilinoService.Registrar(propietario.DNI, codigoInmueble,inquilino);
            if (!registrar)
            {
                MessageBox.Show("No puede ver registros repetidos");
                return;
            }

            MostrarInquilinos(inquilinoService.ListarTodo(propietario.DNI,codigoInmueble));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreCompleto.Clear();
            tbDNI.Clear();
            tbCelular.Clear();
            tbCorreo.Clear();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgInquilinos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            string codigo = dgInquilinos.SelectedRows[0].Cells[0].Value.ToString();
            inquilinoService.Eliminar(propietario.DNI,codigoInmueble,codigo);
            MostrarInquilinos(inquilinoService.ListarTodo(propietario.DNI,codigoInmueble));
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FormPagos form = new FormPagos();
            form.Show();
        }
    }
}
