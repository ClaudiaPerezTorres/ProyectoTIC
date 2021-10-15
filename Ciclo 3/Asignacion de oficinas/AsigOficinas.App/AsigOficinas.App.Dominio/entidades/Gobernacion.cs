using System;
using System.Collections.Generic;

namespace AsigOficinas.App.Dominio
{
    public class Gobernacion
    {
        public int id {get;set;}
        public string ubicacion {get;set;}
        public string direccion {get;set;}
        public uint telefono {get;set;}
        public List<Sede> sedes {get;set;}
    }
}