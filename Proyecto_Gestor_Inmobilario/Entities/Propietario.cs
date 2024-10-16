﻿using Proyecto_Gestor_Inmobilario.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entities
{
    public class Propietario
    {
        public Propietario() { }
        public string Nombre_Usuario { get; set; }
        public string Nombre_Completo { get; set; }
        public string DNI { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Celular { get; set; }
        public string RUC { get; set; }
        public List<Inmobiliario> Inmobiliarios { get; set; }
    }
}
