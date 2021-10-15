using System;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Diagnostico
    {
        public int id {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(100, MinimumLength = 10)]
        public string sintomas {get;set;}
        [Required(ErrorMessage = "Falta completar este campo")]
        public DateTime fechaDiagnostico {get;set;}
    }
}