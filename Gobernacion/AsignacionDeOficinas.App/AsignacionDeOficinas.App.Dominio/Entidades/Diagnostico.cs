using System;
namespace AsignacionDeOficinas.App.Dominio
{
    public class Diagnostico:Persona
    {
        public int Id {get;set;}
         public string sintomas {get;set;}
         public DateTime fechaDiagnostico {get;set;}
        
    }
}