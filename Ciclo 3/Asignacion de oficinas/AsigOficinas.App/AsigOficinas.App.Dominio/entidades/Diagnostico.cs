using System;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Diagnostico
    {
        public int id {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(100, MinimumLength = 3)]
        public string sintomas {get;set;}
        [Range(typeof(DateTime), "1/1/2021", "31/12/2050",
        ErrorMessage = "La fecha debe estar {1} entre {2}")]
        public DateTime fechaDiagnostico {get;set;}
    }
}