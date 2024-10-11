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
        public bool Registrar(Inmobiliario inmobiliario)
        {
            if (inmobiliarioRepository.Existe(inmobiliario.NombrePropiedad))
            {
                return false;
            }
            else
            {
                inmobiliarioRepository.Registrar(inmobiliario);
                return true;
            }
        }
        //Eliminar
        public void Eliminar(string codigo)
        {
            inmobiliarioRepository.Eliminar(codigo);
        }
        //Listar Todo
        public List<Inmobiliario> ListarTodo()
        {
            return InmobiliarioRepository.ListarTodo();
        }
        public void LimpiarTodo()
        {
            inmobiliarioRepository.LimpiarTodo();
        }
    }
}
