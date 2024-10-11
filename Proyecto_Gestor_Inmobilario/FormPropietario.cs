using Proyecto_Gestor_Inmobilario.Entities;
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
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (tbNombreCompleto.Text == "" || tbNombreUsuario.Text == "" || tbDNI.Text == "" || tbCorreo.Text == "" || tbContraseña.Text == "" || tbCelular.Text == "")
            {
                MessageBox.Show("Rellene todas las casilas");
                return;
            }

            Propietario nuevoPropietario = new Propietario()
            {
                Nombre_Usuario = tbNombreUsuario.Text,
                Nombre_Completo = tbNombreCompleto.Text,
                DNI = tbDNI.Text,
                Correo = tbCorreo.Text,
                contraseña = tbContraseña.Text,
                Celular = tbCelular.Text,
            };

            bool registrar = propietarioService.Registrar(nuevoPropietario);
            if (!registrar)
            {
                MessageBox.Show("No puede haber registros iguales");
            }

            MessageBox.Show("Propietario registrado exitosamente");
            LimpiarCampos();
            MostrarPropietarios(propietarioService.ListarTodo());
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

        

        private void LimpiarCampos()
        {
            tbNombreCompleto.Clear();
            tbNombreCompleto.Clear();
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
        }
    }
}
