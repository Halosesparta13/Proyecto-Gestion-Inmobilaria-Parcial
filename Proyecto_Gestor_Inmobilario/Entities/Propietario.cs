using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entities
{
    internal class Propietario
    {
        public Propietario() { }
        public int Propietario_Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre_Completo { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string contraseña { get; set; }
        public string Celular { get; set; }
        public string RUC { get; set; }
    }
}
