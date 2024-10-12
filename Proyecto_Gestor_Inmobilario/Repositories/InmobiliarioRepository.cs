using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    internal class InmobiliarioRepository
    {
       
        //Existe
        public bool Existe(string codigoInmobilario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            return propietarios.Exists(e => e.Inmobiliarios.Any(i => i.Inmueble_Id == codigoInmobilario));
        }
        //Registrar
        public void Registrar(string NombrePropietario, Inmobiliario inmobiliario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.Nombre_Usuario.Equals(NombrePropietario)); 
            propietario.Inmobiliarios.Add(inmobiliario);

        }
        //Eliminar
        public void Eliminar(string codigoPropietario, string codigoInmobilario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.Nombre_Usuario.Equals(codigoPropietario));
            propietario.Inmobiliarios.RemoveAll(a => a.NombrePropiedad.Equals(codigoInmobilario));
        }
        //Listar Todo
        public static List<Inmobiliario> ListarTodo(string codigo)
        {

            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.Nombre_Usuario == codigo);
            return propietario.Inmobiliarios;
        }

  
    }
}
