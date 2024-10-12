using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using Proyecto_Gestor_Inmobilario.Repositories;
using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormPropietario : Form
    {
        private PropietarioService propietarioService = new PropietarioService();
        public FormPropietario()
        {
            InitializeComponent();
            MostrarPropietarios(propietarioService.ListarTodo());
        }

        private void MostrarPropietarios(List<Propietario> propietarios)
        {
            dgPropietarios.DataSource = null;
            if(propietarios.Count == 0)
            {
                return;
            }
            else
            {
                dgPropietarios.DataSource = propietarios;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
            {
                MessageBox.Show("Rellene todas las casilas");
                return;
            }

            Propietario nuevoPropietario = new Propietario()
            {
                DNI = tbDNI.Text,
                Nombre_Usuario = tbNombreUsuario.Text,
                Nombre_Completo = tbNombreCompleto.Text,
                Correo = tbCorreo.Text,
                Contraseña = tbContraseña.Text,
                Celular = tbCelular.Text,
                Inmobiliarios = new List<Inmobiliario>()
            };

            bool registrar = propietarioService.Registrar(nuevoPropietario);
            if (!registrar)
            {
                MessageBox.Show("No puede haber registros iguales");
            }
            else
            {
                // Crear o abrir el archivo usuarios.txt
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");
                // Limpiar el archivo antes de agregar nuevos registros
                if (File.Exists(path))
                {
                    File.WriteAllText(path, string.Empty); // Limpiar el archivo
                }
                try
                {
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nuevoPropietario.Nombre_Usuario},{nuevoPropietario.Contraseña}");
                    }
                    MessageBox.Show("Propietario registrado exitosamente");
                    MessageBox.Show($"Archivo se creó en: {path}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el archivo: {ex.Message}");
                }

                MostrarPropietarios(propietarioService.ListarTodo());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreCompleto.Clear();
            tbNombreCompleto.Clear();
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgPropietarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un propietario para eliminar");
                return;
            }
            string NombreUsuario = dgPropietarios.SelectedRows[0].Cells[0].Value.ToString();
            propietarioService.Eliminar(NombreUsuario);
            MostrarPropietarios(propietarioService.ListarTodo());
        }

        private void btnRegistrarPropiedad_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
