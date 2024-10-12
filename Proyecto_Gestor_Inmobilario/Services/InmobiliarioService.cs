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
        public bool Registrar(string nombrePropietario, Inmobiliario inmobiliario)
        {
            if (inmobiliarioRepository.Existe(inmobiliario.Inmueble_Id))
            {
                return false;
            }
            else
            {
                inmobiliarioRepository.Registrar(nombrePropietario, inmobiliario);
                return true;
            }
        }
        //Eliminar
        public void Eliminar(string codigoPropietario, string codigoInmueble)
        {
            inmobiliarioRepository.Eliminar(codigoPropietario, codigoInmueble);
        }
        //Listar Todo
        public List<Inmobiliario> ListarTodo(string codigo)
        {
            return InmobiliarioRepository.ListarTodo(codigo);
        }
    }
}
