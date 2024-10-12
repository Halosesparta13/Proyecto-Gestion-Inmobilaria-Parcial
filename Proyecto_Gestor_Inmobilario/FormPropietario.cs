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
        private List<Propietario> usuariosRegistrados;
        public FormPropietario(List<Propietario> propietarios) 
        {
            InitializeComponent();
            usuariosRegistrados = propietarios;
            MostrarPropietarios(propietarioService.ListarTodo());
        }

        private void MostrarPropietarios(List<Propietario> propietarios)
        {
            dgPropietarios.DataSource = null;
            if (propietarios.Count == 0)
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
            string dni = tbDNI.Text;
            string celular = tbCelular.Text;
            string correo = tbCorreo.Text;
            string ruc = tbRUC.Text;

            if (tbRUC.Text==""||  tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
            {
                MessageBox.Show("Rellene todas las casilas");
                return;
            }
            // Validación de longitud del DNI
            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener 8 dígitos numéricos.");
                return;
            }

            // Validación del número de celular
            if (celular.Length < 9 || !celular.All(char.IsDigit))
            {
                MessageBox.Show("El número de celular debe tener al menos 9 dígitos y solo contener números.");
                return;
            }

            // Validación del formato de correo electrónico
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                MessageBox.Show("Ingrese un correo electrónico válido.");
                return;
            }

            // Validación del RUC (asumiendo 11 dígitos)
            if (ruc.Length != 11 || !ruc.All(char.IsDigit))
            {
                MessageBox.Show("El RUC debe contener 11 dígitos numéricos.");
                return;
            }

            if (usuariosRegistrados.Any(p => p.Nombre_Usuario == tbNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe. Elija uno diferente.");
                return;
            }

            // Crear un nuevo propietario
            Propietario nuevoPropietario = new Propietario
            {
                DNI = tbDNI.Text,
                Nombre_Usuario = tbNombreUsuario.Text,
                Nombre_Completo = tbNombreCompleto.Text,
                Correo = tbCorreo.Text,
                Contraseña = tbContraseña.Text,
                Celular = tbCelular.Text,
                RUC = tbRUC.Text,
                Inmobiliarios = new List<Inmobiliario>()
            };

            // Registrar el nuevo propietario
            bool registrar = propietarioService.Registrar(nuevoPropietario);
            if (registrar)
            {
                usuariosRegistrados.Add(nuevoPropietario); // Actualizar la lista en FormLogin
                MostrarPropietarios(propietarioService.ListarTodo()); // Mostrar lista actualizada
                MessageBox.Show("Propietario registrado exitosamente.");

            }
            else
            {
                MessageBox.Show("No puede haber registros iguales");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombreCompleto.Clear();
            tbNombreUsuario.Clear();  // Faltaba este
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
            tbRUC.Clear();  // Faltaba este
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

            // Actualizar lista de usuarios registrados después de eliminar
            usuariosRegistrados = propietarioService.ListarTodo();

            MostrarPropietarios(usuariosRegistrados);
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
