using System;
namespace AsignacionDeOficinas.App.Dominio
{
    public class Sede
    {
        public Gobernacion Gobernacion {get;set;}
         public string ubicacion {get;set;}
         public string direccion {get;set;}
         public ushort telefono {get;set;}
         public List<Sede> sedes {get;set;}
        
    }
}