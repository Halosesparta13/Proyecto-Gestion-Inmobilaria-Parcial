using Proyecto_Gestor_Inmobilario.Entity;
using Proyecto_Gestor_Inmobilario.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Services
{
    internal class InmobiliarioService
    {
        private InmobiliarioRepository inmobiliarioRepository = new InmobiliarioRepository();
        //Registrar
        public bool Registrar(string DNI, Inmobiliario inmobiliario)
        {
            if (inmobiliario == null)
            {
                throw new ArgumentNullException(nameof(inmobiliario), "El objeto inmobiliario no puede ser nulo.");
            }

            if (string.IsNullOrEmpty(inmobiliario.Inmueble_Id))
            {
                throw new ArgumentException("El ID del inmueble no puede estar vacío.", nameof(inmobiliario.Inmueble_Id));
            }
            if (inmobiliarioRepository.Existe(inmobiliario.Inmueble_Id))
            {
                return false;
            }
            else
            {
                inmobiliarioRepository.Registrar(DNI, inmobiliario);
                return true;
            }
        }
        //Eliminar
        public void Eliminar(string DNI, string codigoInmueble)
        {
            inmobiliarioRepository.Eliminar(DNI, codigoInmueble);
        }
        //Listar Todo
        public List<Inmobiliario> ListarTodo(string DNI)
        {
            return inmobiliarioRepository.ListarTodo(DNI);
        }
    }
}