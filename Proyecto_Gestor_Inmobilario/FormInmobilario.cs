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
    public partial class FormInmobilario : Form
    {
        public FormInmobilario()
        {
            InitializeComponent();
                        MostrarPropiedades(inmobiliarioServicio.ListarTodo());
        }

        private void MostrarPropiedades(List<Inmobiliario> inmobiliarios)
        {
            dtgInmobiliario.DataSource = null;
            if (inmobiliarios.Count == 0)
            {
                return;
            }
            else
            {
                dtgInmobiliario.DataSource = inmobiliarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (txtNombre.Text == "" || txtUbicacion.Text == "" || txtPago.Text == "" || cmbTipo.Text == ""||txtDescripcion.Text == ""||txtAgregados.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            //Creacion de objetos
            Inmobiliario inmobiliario = new Inmobiliario()
            {
                NombrePropiedad = txtNombre.Text,
                Ubicación = txtUbicacion.Text,
                PagoMensual = int.Parse(txtPago.Text),
                DescipciónPropiedad = txtDescripcion.Text,
                TipoInmueble = cmbTipo.Text,
                ServicioAgregados = txtAgregados.Text,
            };
            //No se repite
            bool registrado = inmobiliarioServicio.Registrar(inmobiliario);
            if (!registrado)
            {
                MessageBox.Show("Debe de ingresar un registro diferente");
                return;
            }
            //Mostrar
            MostrarPropiedades(inmobiliarioServicio.ListarTodo());
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validar selección
            if (dtgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            string codigo = dtgInmobiliario.SelectedRows[0].Cells[0].ToString();
            inmobiliarioServicio.Eliminar(codigo);
            MostrarPropiedades(inmobiliarioServicio.ListarTodo());
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar la lista del servicio
            inmobiliarioServicio.LimpiarLista(); 
            MostrarPropiedades(inmobiliarioServicio.ListarTodo());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormInmobilario_Load(object sender, EventArgs e)
        {

        }
    
    }
}
