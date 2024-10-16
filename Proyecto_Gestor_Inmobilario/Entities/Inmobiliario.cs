﻿using Proyecto_Gestor_Inmobilario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entity
{
    public class Inmobiliario
    {
        public Inmobiliario() { }
        public string Inmueble_Id { get; set; }
        public string Ubicación { get; set; }
        public decimal PagoMensual { get; set; }
        public string DescipciónPropiedad { get; set; }
        public string TipoInmueble { get; set; }
        public string ServicioAgregados { get; set; }
        public string ImagePath { get; set; }
        public List<Inquilino> Inquilinos { get; set; }
    }
}
