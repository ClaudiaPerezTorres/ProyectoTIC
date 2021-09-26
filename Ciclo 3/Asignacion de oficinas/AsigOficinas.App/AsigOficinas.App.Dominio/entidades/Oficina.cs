using System;
using System.Collections.Generic;

namespace AsigOficinas.App.Dominio
{
    public class Oficina
    {
        public int id {get;set;}
        public string numero {get;set;}
        public ushort aforo {get;set;}
        public string horaLaboral {get;set;}
        public List<Persona> numeroPersonas {get;set;}
        public bool estadoOficina {get;set;}
    }
}