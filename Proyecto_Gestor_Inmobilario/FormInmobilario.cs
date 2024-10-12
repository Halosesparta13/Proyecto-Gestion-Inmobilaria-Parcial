﻿using Proyecto_Gestor_Inmobilario.Entity;
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
    public partial class FormInmobilario : Form
    {
        private InmobiliarioService inmobiliarioService = new InmobiliarioService();
        private string Nombre_Usuario;
        public FormInmobilario(string Nombre_Usuario)
        {
            InitializeComponent();
            this.Nombre_Usuario = Nombre_Usuario;
            lblNombre_Usuario.Text = $"¡Bienvenido {Nombre_Usuario}! | Fecha de último acceso {DateTime.Now}";
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

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation= dialog.FileName;

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
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbDescripcion.Text == "" || cbTipoInmueble.Text == "" || tbPagoMensual.Text == "" || tbAgregado.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }
            //Creacion de objetos
            Inmobiliario inmobiliario = new Inmobiliario()
            {
                NombrePropiedad = tbNombre.Text,
                Ubicación = tbDireccion.Text,
                PagoMensual = int.Parse(tbPagoMensual.Text),
                DescipciónPropiedad = tbDescripcion.Text,
                TipoInmueble = cbTipoInmueble.Text,
                ServicioAgregados = tbAgregado.Text,
                ImagePath = imageLocation
            };
            //No se repite
            bool registrado = inmobiliarioService.Registrar(inmobiliario);
            if (!registrado)
            {
                MessageBox.Show("Debe de ingresar un registro diferente");
                return;
            }
            //Mostrar
            MostrarPropiedades(inmobiliarioService.ListarTodo());
        }
        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {
            if(dgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("¡Seleccione un registro!");
                return;
            }

            string codigo = dgInmobiliario.SelectedRows[0].Cells[0].Value.ToString();
            FormInquilinos form = new FormInquilinos();
            form.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbDescripcion.Clear();
            tbAgregado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //validar selección
            if (dgInmobiliario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            string codigo = dgInmobiliario.SelectedRows[0].Cells[0].ToString();
            inmobiliarioService.Eliminar(codigo);
            MostrarPropiedades(inmobiliarioService.ListarTodo());
        }

        
    }
}
