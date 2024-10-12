using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Services
{
    internal class InquilinoService
    {
        private InquilinoRepository inquilinoRepository = new InquilinoRepository();

        public bool Registrar(string codigoInmueble, Inquilino inquilino)
        {
            if (inquilinoRepository.Existe(codigoInmueble, inquilino.DNI))
            {
                return false;
            }
            {
                inquilinoRepository.Registrar(codigoInmueble, inquilino);
                return true;
            }
        }

        public List<Inquilino> ListarTodo(string codigoInmueble)
        {
            return InquilinoRepository.ListarTodo(codigoInmueble);
        }

        public void Eliminar(string codigoInmueble, string CodigoInquilino)
        {
            inquilinoRepository.Eliminar(codigoInmueble, CodigoInquilino);
        }

    }
}
