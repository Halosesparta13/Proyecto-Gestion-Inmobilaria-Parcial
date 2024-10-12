using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormInmobilario : Form
    {
        private InmobiliarioService inmobiliarioService = new InmobiliarioService();
        private Propietario propietario; // Almacena el objeto propietario
        public FormInmobilario(Propietario propietario)
        {
            InitializeComponent();
            this.propietario = propietario;
            lblNombre_Usuario.Text = $"¡Bienvenido {propietario.Nombre_Completo}! | Fecha de último acceso {DateTime.Now}";
            dgInmobiliario.SelectionChanged += dgInmobiliario_SelectionChanged;
        }

        private void MostrarPropiedades(List<Inmobiliario> inmobiliarios)
        {
            dgInmobiliario.DataSource = null;
            if (inmobiliarios.Count == 0)
            {
                return;
            }
            else
            {
                dgInmobiliario.DataSource = inmobiliarios;
                dgInmobiliario.Columns["ImagePath"].Visible = false; // Opcional, si no quieres mostrar la ruta
            }

        }
        private void dgInmobiliario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgInmobiliario.SelectedRows.Count > 0)
            {
                var selectedRow = dgInmobiliario.SelectedRows[0];
                var imagePath = selectedRow.Cells["ImagePath"].Value as string;

                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    try
                    {
                        // Cargar la imagen en el PictureBox
                        pictureBoxInmobiliario.Image = new Bitmap(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede cargar la imagen: " + ex.Message);
                    }
                }
                else
                {
                    // Si no hay imagen, limpiar el PictureBox
                    pictureBoxInmobiliario.Image = null;
                }
            }
        }
        //Prueba de caraga de imagen
        private String imageLocation = "";
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBoxInmobiliario.ImageLocation = imageLocation;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (tbInmueble_Id.Text == "" || tbDireccion.Text == "" || tbDescripcion.Text == "" || cbTipo.Text==""|| tbPagoMensual.Text == "" || tbAgregado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            decimal MontoMensual = 0;
            try
            {
                MontoMensual = decimal.Parse(tbPagoMensual.Text);
                // Verificar si el monto es positivo
                if (MontoMensual <= 0)
                {
                    MessageBox.Show("El Pago Mensual debe ser un valor positivo.");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingresa un valor valido en la casilla Pago Mensual ");
                Console.WriteLine(ex.Message);
                return;
            }
            //Creacion de objetos
            Inmobiliario inmobiliario = new Inmobiliario()
            {
                Inmueble_Id = tbInmueble_Id.Text,
                Ubicación = tbDireccion.Text,
                PagoMensual = MontoMensual,
                DescipciónPropiedad = tbDescripcion.Text,
                TipoInmueble = cbTipo.Text,
                ServicioAgregados = tbAgregado.Text,
                ImagePath = imageLocation,
                Inquilinos = new List<Inquilino>()
            };
            /*
            MessageBox.Show($"Ubicación: {tbDireccion.Text}\n" +
                $"Pago Mensual: {MontoMensual}\n" +
                $"Descripción: {tbDescripcion.Text}\n" +
                $"Tipo de Inmueble: {cbTipo.Text}\n" +
                $"Servicios Agregados: {tbAgregado.Text}\n" +
                $"Image Path: {imageLocation}");
            */
            //No se repite
            bool registrado = inmobiliarioService.Registrar(propietario.DNI,inmobiliario);
            if (!registrado)
            {
                MessageBox.Show("Debe de ingresar un registro diferente");
                return;
            }
            //Mostrar
            MostrarPropiedades(inmobiliarioService.ListarTodo(propietario.DNI));
        }
        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {
            if (dgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("¡Seleccione un registro!");
                return;
            }

            string codigo = dgInmobiliario.SelectedRows[0].Cells[0].Value.ToString();
            string MONTO = tbPagoMensual.Text;
            string DNIPropietario = propietario.DNI;
            FormInquilinos form = new FormInquilinos(codigo, propietario, MONTO);
            form.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbInmueble_Id.Clear();
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbDescripcion.Clear();
            tbAgregado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (dgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            // Obtener el código del inmueble desde la celda correcta
            string codigo = dgInmobiliario.SelectedRows[0].Cells["Inmueble_Id"].Value.ToString();

            // Llamar al servicio para eliminar el inmueble
            inmobiliarioService.Eliminar(propietario.DNI, codigo);

            // Mostrar la lista actualizada de propiedades
            MostrarPropiedades(inmobiliarioService.ListarTodo(propietario.DNI));
        }


    }
}