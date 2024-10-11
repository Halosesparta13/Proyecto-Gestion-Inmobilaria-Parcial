using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Entities
{
    public class Pago
    {
        public int PagoId { get; set; }
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; }
        public string Estado { get; set; }
        public  DateTime Fecha { get; set; }
        public int PropiedadId { get; set; }
    }
}
