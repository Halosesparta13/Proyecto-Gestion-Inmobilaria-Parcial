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


        //Existe
        public bool Existe(string codigoInmueble, string codigoInquilino)
        {
            List<Inmobiliario> inmobiliarios = InmobiliarioRepository.ListarTodo(codigoInmueble);
            return inmobiliarios.Exists(i => i.inquilinos.Any(inq => inq.DNI == codigoInquilino));
        }
        //Registrar
        public void Registrar(string codigoInmueble, Inquilino inquilino)
        {
            List<Inmobiliario> inmobiliarios = InmobiliarioRepository.ListarTodo(codigoInmueble);
            Inmobiliario inmobiliario = inmobiliarios.Find(i => i.Inmueble_Id == codigoInmueble);
            inmobiliario.inquilinos.Add(inquilino);
        }
        //ListarTodo
        public static List<Inquilino> ListarTodo(string codigoInmueble)
        {
            List<Inmobiliario> inmobiliarios = InmobiliarioRepository.ListarTodo(codigoInmueble);
            Inmobiliario inmobiliario = inmobiliarios.Find(i => i.Inmueble_Id == codigoInmueble);
            return inmobiliario.inquilinos;
        }
        //Eliminar
        public void Eliminar(string codigoInmueble, string codigoDni)
        {
            List<Inmobiliario> inmobiliarios = InmobiliarioRepository.ListarTodo(codigoInmueble);
            Inmobiliario inmobiliario = inmobiliarios.Find(i => i.Inmueble_Id == codigoInmueble);
            inmobiliario.inquilinos.RemoveAll(i => i.DNI == codigoDni);
        }
    }
}
