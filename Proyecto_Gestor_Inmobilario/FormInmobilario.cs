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
        public FormInmobilario()
        {
            InitializeComponent();

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
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validación de campos
            if (tbNombre.Text == "" || tbDireccion.Text == "" || tbDescripcion.Text == "" || cbTipoInmueble.Text == ""||tbPagoMensual.Text == ""||tbAgregado.Text == "")
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
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbPagoMensual.Clear();
            tbDescripcion.Clear();
            tbAgregado.Clear();
        }

        //Prueba de caraga de imagen
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation= dialog.FileName;

                    imagePicture.ImageLocation = imageLocation;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la carga", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarInquilinos_Click(object sender, EventArgs e)
        {
            FormInquilinos form = new FormInquilinos();
            form.Show();
        }
    }
}
