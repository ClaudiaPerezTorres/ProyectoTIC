using System;
using System.Collections.Generic;

namespace AsigOficinas.App.Dominio
{
    public class Sede
    {
        public int id {get;set;}
        public string nombre {get;set;}
        public string ubicacion {get;set;}
        public List<Oficina> oficinas {get;set;}
    }
}