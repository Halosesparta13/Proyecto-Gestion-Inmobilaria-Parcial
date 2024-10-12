
using Proyecto_Gestor_Inmobilario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    internal class PropietarioRepository
    {
        private static List<Propietario> propietarios = new List<Propietario>();

        public bool Existe(string NombreUsuario, string DNI)
        {
            return propietarios.Exists(p => p.DNI.Equals(DNI) && p.Nombre_Usuario.Equals(NombreUsuario));
        }
        public void Registrar(Propietario propietario)
        {
            propietarios.Add(propietario);
        }

        public void Eliminar(string propietarioId)
        {
            propietarios.RemoveAll(p => p.Nombre_Usuario == propietarioId);
        }


        public static List<Propietario> ListarTodo()
        {
            return propietarios;
        }
   
    }
}
