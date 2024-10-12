using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormLogin : Form
    {
        private PropietarioService propietarioService = new PropietarioService();
        public FormLogin()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> usuariosRegistrados = new Dictionary<string, string>()
        {
            { "u202211674", "12345" },
            { "u202111433", "12345" },
            { "u202010153", "12345" },
            { "u202212481", "12345" }
        };

        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            // Obtener los datos introducidos por el usuario
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            // Verificar si el usuario existe en el diccionario
            if (usuariosRegistrados.ContainsKey(usuario))
            {
                // Verificar si la contraseña es correcta
                if (usuariosRegistrados[usuario] == contraseña)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    FormInquilinos form = new FormInquilinos();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormPropietario form = new FormPropietario();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}