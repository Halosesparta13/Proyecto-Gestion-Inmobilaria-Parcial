using Proyecto_Gestor_Inmobilario.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    internal class InmobiliarioRepository
    {
        private static List<Inmobiliario> inmobiliarios = new List<Inmobiliario>();
        //Existe
        public bool Existe(string codigo)
        {
            return inmobiliarios.Exists(a => a.Inmueble_Id.Equals(codigo));
        }
        //Registrar
        public void Registrar(Inmobiliario inmobiliario)
        {
            inmobiliarios.Add(inmobiliario);
        }
        //Eliminar
        public void Eliminar(string codigo)
        {
            inmobiliarios.RemoveAll(a => a.Inmueble_Id.Equals(codigo));
        }
        //Listar Todo
        public static List<Inmobiliario> ListarTodo()
        {
            return inmobiliarios;
        }

        public void LimpiarTodo()
        {
            inmobiliarios.Clear();
        }
    }
}