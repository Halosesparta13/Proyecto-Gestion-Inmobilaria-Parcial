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
            return propietarios.Exists(e => e.Inmobiliarios.Any(i => i.Inmueble_Id.Equals(codigoInmobilario)));
        }
        //Registrar
        public void Registrar(string DNI, Inmobiliario inmobiliario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI.Equals(DNI));
            if (propietario == null)
            {
                throw new ArgumentException($"No se encontró un propietario con el DNI: {DNI}");
            }
            propietario.Inmobiliarios.Add(inmobiliario);

        }
        //Eliminar
        public void Eliminar(string DNI, string codigoInmobilario)
        {
            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI.Equals(DNI));
            propietario.Inmobiliarios.RemoveAll(a => a.Inmueble_Id.Equals(codigoInmobilario));
        }
        //Listar Todo
        public List<Inmobiliario> ListarTodo(string DNI)
        {

            List<Propietario> propietarios = PropietarioRepository.ListarTodo();
            Propietario propietario = propietarios.Find(p => p.DNI == DNI);
            if (propietario == null)
            {
                throw new ArgumentException($"No se encontró un propietario con el DNI: {DNI}");
            }
            return propietario.Inmobiliarios;
        }


    }
}