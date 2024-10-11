using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Services
{
    internal class PropietarioService
    {
        private PropietarioRepository propietarioRepository = new PropietarioRepository();
        //Registrar
        public bool Registrar(Propietario propietario)
        {
            if (propietarioRepository.Existe(propietario.Nombre_Usuario))
            {
                return false;
            }
            else
            {
                propietarioRepository.Registrar(propietario);
                return true;
            }
        }

        //Listar Todo
        public List<Propietario> ListarTodo()
        {
            return PropietarioRepository.ListarTodo();
        }
        //Elimninar
        public void Eliminar(string propietarioUsuario)
        {
            propietarioRepository.Eliminar(propietarioUsuario);
        }
    }
}
