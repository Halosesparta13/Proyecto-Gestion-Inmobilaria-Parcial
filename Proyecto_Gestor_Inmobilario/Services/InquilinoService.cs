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
        public bool Registrar(string codigoPropietario, string codigoInmobilario, Inquilino inquilino)
        {
            if (inquilinoRepository.Existe(inquilino.DNI))
            {
                return false;
            }
            {
                inquilinoRepository.Registrar(codigoPropietario, codigoInmobilario, inquilino);
                return true;
            }
        }
        public List<Inquilino> ListarTodo(string codigoPropietario, string codigoInmobilario)
        {
            return InquilinoRepository.ListarTodo(codigoPropietario,codigoInmobilario);
        }
        public void Eliminar(string codigoPropietario, string codigoInmobilario, string codigoInquilino)
        {
            inquilinoRepository.Eliminar(codigoPropietario,codigoInmobilario,codigoInquilino);
        }

    }
}
