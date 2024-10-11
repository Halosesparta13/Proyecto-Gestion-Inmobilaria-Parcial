using Proyecto_Gestor_Inmobilario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    public class PagoRepository
    {
        private List<Pago> pagos = new List<Pago>();

        public List<Pago> ObtenerPagos()
        {
            return pagos;
        }

        public void AgregarPago(Pago nuevoPago)
        {
            nuevoPago.PagoId = pagos.Count + 1; // Asigna un nuevo ID
            pagos.Add(nuevoPago);
        }
    }
}
