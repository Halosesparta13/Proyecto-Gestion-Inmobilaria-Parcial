using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormLogin : Form
    {
        private PropietarioService propietarioService = new PropietarioService();
        private Dictionary<string, string> usuariosRegistrados = new Dictionary<string, string>()
        {
            { "admin", "12345" },
            { "u202211674", "12345" },
            { "u202111433", "12345" },
            { "u202010153", "12345" },
            { "u202212481", "12345" }
        };
        public FormLogin()
        {
            InitializeComponent();
            CargarUsuariosDesdeArchivo();
        }

        private void CargarUsuariosDesdeArchivo()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.txt");
            if (File.Exists(path))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var datos = line.Split(',');
                            if (datos.Length == 2)
                            {
                                string usuario = datos[0];
                                string contraseña = datos[1];
                                // Agregar al diccionario, sobreescribiendo si ya existe
                                usuariosRegistrados[usuario] = contraseña;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo de usuarios: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El archivo de usuarios no existe.");
            }
        }

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
                    FormInmobilario form = new FormInmobilario();
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