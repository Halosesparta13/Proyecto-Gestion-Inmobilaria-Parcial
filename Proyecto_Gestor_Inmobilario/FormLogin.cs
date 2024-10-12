using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using Proyecto_Gestor_Inmobilario.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Gestor_Inmobilario
{
    public partial class FormLogin : Form
    {
        private PropietarioService propietarioService = new PropietarioService();
        private List<Propietario> usuariosRegistrados = new List<Propietario>();
        public FormLogin()
        {
            InitializeComponent();
            //CargarUsuariosDesdeArchivo();
            AgregarAdmin();
        }

        //Usuario predeterminado para uso de prueba
        private void AgregarAdmin()
        {
            if (!usuariosRegistrados.Any(u => u.Nombre_Usuario == "Admin"))
            {
                var admin = new Propietario
                {
                    Nombre_Usuario = "Admin",
                    Contraseña = "12345",
                    DNI = "12345678",
                    Nombre_Completo = "Administrador",
                    Correo = "admin@ejemplo.com",
                    Celular = "987654321",
                    RUC = "12345678912",
                    Inmobiliarios = new List<Inmobiliario>()
                };

                usuariosRegistrados.Add(admin);
                propietarioService.Registrar(admin);
            }
        }
        //Este era el antiguo sistema, tengo uno mejor
        /*
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
                //MessageBox.Show("El archivo de usuarios no existe.");
            }
        }
        */
        private void btnIniciarSeccion_Click(object sender, EventArgs e)
        {
            // Obtener los datos introducidos por el usuario
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            // Buscar el propietario en la lista
            var propietario = usuariosRegistrados.FirstOrDefault(p => p.Nombre_Usuario == usuario);

            if (propietario != null)
            {
                // Verificar si la contraseña es correcta
                if (propietario.Contraseña == contraseña)
                {
                    MessageBox.Show("Inicio de sesión exitosa.");
                    FormInmobilario form = new FormInmobilario(propietario);
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
            FormPropietario form = new FormPropietario(usuariosRegistrados);
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}