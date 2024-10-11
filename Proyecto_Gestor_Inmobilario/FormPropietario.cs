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
    public partial class FormPropietario : Form
    {
        private PropietarioRepository propietarioRepository = new PropietarioRepository();
        public FormPropietario()
        {
            InitializeComponent();
            MostrarPropietarios();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Propietario nuevoPropietario = new Propietario()
            {
                Nombre_Usuario = tbNombreUsuario.Text,
                Nombre_Completo = tbNombreCompleto.Text,
                DNI = tbDNI.Text,
                Correo = tbCorreo.Text,
                contraseña = tbContraseña.Text,
                Celular = tbCelular.Text,
            };

            propietarioRepository.Agregar(nuevoPropietario);
            MessageBox.Show("Propietario registrado exitosamente");
            LimpiarCampos();
            MostrarPropietarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un propietario para eliminar");
                return;
            }

            int propietarioId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            propietarioRepository.Eliminar(propietarioId);
            MessageBox.Show("Propietario eliminado exitosamente");
            MostrarPropietarios();
        }

        private void MostrarPropietarios()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propietarioRepository.ObtenerTodos();
        }

        private void LimpiarCampos()
        {
            tbNombreUsuario.Clear();
            tbNombreCompleto.Clear();
            tbDNI.Clear();
            tbCorreo.Clear();
            tbContraseña.Clear();
            tbCelular.Clear();
        }
    }
}
    }
}
