using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entity
{
    internal class Inmobiliario
    {
        public Inmobiliario() { }
        public string NombrePropiedad { get; set; }
        public string Ubicación { get; set; }
        public int PagoMensual { get; set; }
        public string DescipciónPropiedad { get; set; }
        public string TipoInmueble { get; set; }
        public string ServicioAgregados { get; set; }
        public string ImagePath { get; set; }
    }
}
