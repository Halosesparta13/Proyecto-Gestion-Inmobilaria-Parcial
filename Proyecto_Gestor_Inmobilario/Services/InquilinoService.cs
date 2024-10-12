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
        public bool Registrar(Inquilino inquilino)
        {
            if (inquilinoRepository.Existe(inquilino.DNI))
            {
                return false;
            }
            {
                inquilinoRepository.Registrar(inquilino);
                return true;
            }
        }
        public List<Inquilino> ListarTodo()
        {
            return InquilinoRepository.ListarTodo();
        }
        public void Eliminar(string codigo)
        {
            inquilinoRepository.Eliminar(codigo);
        }

    }
}
