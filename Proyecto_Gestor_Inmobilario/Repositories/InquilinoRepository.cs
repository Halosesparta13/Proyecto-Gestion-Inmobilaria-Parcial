using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    internal class InquilinoRepository
    {
        private InmobiliarioRepository inmobiliarioRepository = new InmobiliarioRepository();
        //Existe
        public bool Existe(string codigo)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            return propietarios.Exists(p => p.Inmobiliarios.Any(i => i.Inquilinos.Any(inq => inq.DNI == codigo)));
        }
        //Registrar
        public void Registrar(string codigoPropietario, string codigoInmobiliario, Inquilino inquilino)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI.Equals(codigoPropietario));
            Inmobiliario inmobiliario = propietario?.Inmobiliarios.Find(i => i.Inmueble_Id.Equals(codigoInmobiliario));
            if (inmobiliario == null)
            {
                throw new Exception("El inmueble no se encontró.");
            }
            inmobiliario.Inquilinos.Add(inquilino);
        }
        //ListarTodo
        public static List<Inquilino> ListarTodo(string DNI, string codigoInmobilario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI == DNI);

            if (propietario == null)
            {
                throw new Exception("Propietario no encontrado.");
            }

            Inmobiliario inmobiliario = propietario.Inmobiliarios.Find(i => i.Inmueble_Id.Equals(codigoInmobilario));

            if (inmobiliario == null)
            {
                throw new Exception("Inmobiliario no encontrado.");
            }

            return inmobiliario.Inquilinos;
        }
        //Eliminar
        public void Eliminar(string DNI, string codigoInmobilario, string codigoInquilino)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI.Equals(DNI));
            Inmobiliario inmobiliario = propietario.Inmobiliarios.Find(i => i.Inmueble_Id.Equals(codigoInmobilario));
            inmobiliario.Inquilinos.RemoveAll(i => i.DNI.Equals(codigoInquilino));
        }
    }
}
