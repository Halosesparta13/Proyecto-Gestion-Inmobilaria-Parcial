using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entities
{
    public class Inquilino
    {
        public string DNI { get; set; }
        public string Nombre_Completo { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public decimal Monto_Alquiler { get; set; }
        public DateTime Fecha_Inicio_Alquiler { get; set; }
        public DateTime Fecha_Fin_Alquiler { get; set; }
        public DateTime Fecha_Pago_Mensual { get; set; }

    }
}
