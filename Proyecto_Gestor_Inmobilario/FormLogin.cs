using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Repositories;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
    


 private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = tbUsuario.Text;
            string contraseña = tbContraseña.Text;

            PropietarioRepository propietarioRepository = new PropietarioRepository();
            Propietario propietario = propietarioRepository.VerificarCredenciales(usuario, contraseña);

            if (propietario != null)
            {
                MessageBox.Show("Login exitoso");
                FormPropietario formPropietario = new FormPropietario();
                formPropietario.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            FormPropietario formPropietario = new FormPropietario();
            formPropietario.Show();
            this.Hide(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}