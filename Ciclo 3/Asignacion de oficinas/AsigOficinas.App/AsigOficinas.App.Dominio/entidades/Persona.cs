using System;

namespace AsigOficinas.App.Dominio
{
    public class Persona
    {
        public int id {get;set;}
        public string nombre {get;set;}
        public string apellido {get;set;}
        public uint identificacion {get;set;}
        public byte edad {get;set;}
        public bool estadoCovid {get;set;}
        public Diagnostico diagnostico {get;set;}
    }
}