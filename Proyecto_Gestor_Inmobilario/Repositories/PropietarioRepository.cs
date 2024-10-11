
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
        private List<Propietario> propietarios = new List<Propietario>();

        public void Agregar(Propietario propietario)
        {
            propietario.Propietario_Id = propietarios.Count + 1;  
            propietarios.Add(propietario);
        }

        public void Eliminar(int propietarioId)
        {
            propietarios.RemoveAll(p => p.Propietario_Id == propietarioId);
        }

        public Propietario VerificarCredenciales(string usuario, string contraseña)
        {
            return propietarios.FirstOrDefault(p => p.Nombre_Usuario == usuario && p.contraseña == contraseña);
        }

        public List<Propietario> ObtenerTodos()
        {
            return propietarios;
        }
   
    }
}
