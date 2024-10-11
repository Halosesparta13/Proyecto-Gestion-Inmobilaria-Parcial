using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Services
{
    public class PagoService
    {
        private readonly PagoRepository pagoRepository;

        public PagoService()
        {
            pagoRepository = new PagoRepository();
        }

        public List<Pago> ObtenerPagos()
        {
            return pagoRepository.ObtenerPagos();
        }

        public void AgregarPago(Pago nuevoPago)
        {
            pagoRepository.AgregarPago(nuevoPago);
        }
    }
}
