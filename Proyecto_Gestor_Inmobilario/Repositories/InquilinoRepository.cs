using Proyecto_Gestor_Inmobilario.Entities;
using Proyecto_Gestor_Inmobilario.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Gestor_Inmobilario.Repositories
{
    internal class InquilinoRepository
    {
        private static List<Inquilino> inquilinos = new List<Inquilino>();
        //Existe
        public bool Existe(string codigo)
        {

            return inquilinos.Exists(i => i.DNI == codigo);
        }
        //Registrar
        public void Registrar(Inquilino inquilino)
        {
            inquilinos.Add(inquilino);
        }
        //ListarTodo
        public static List<Inquilino> ListarTodo()
        {
            return inquilinos;
        }
        //Eliminar
        public void Eliminar(string codigo)
        {
            inquilinos.RemoveAll(i => i.DNI == codigo);
        }
    }
}
