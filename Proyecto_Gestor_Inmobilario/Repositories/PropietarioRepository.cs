
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

        public bool Existe(string NombreUsuario, string DNI, string RUC)
        {
            return propietarios.Exists(p => p.DNI.Equals(DNI) && p.Nombre_Usuario.Equals(NombreUsuario) && p.RUC.Equals(RUC));
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

        public void Modificar(Propietario propietario)
        {
            // Buscar el propietario en la lista que coincide con el DNI, Nombre_Usuario y RUC
            var propietarioExistente = propietarios.FirstOrDefault(p =>
                p.DNI == propietario.DNI &&
                p.Nombre_Usuario == propietario.Nombre_Usuario &&
                p.RUC == propietario.RUC);
        }
   
    }
}
