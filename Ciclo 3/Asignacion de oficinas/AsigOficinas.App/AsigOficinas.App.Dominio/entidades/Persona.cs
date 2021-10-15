using System;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Persona
    {
        public int id {get;set;}
        [Required(ErrorMessage ="Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string nombre {get;set;}
        [Required(ErrorMessage ="Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string apellido {get;set;}
        [Required(ErrorMessage = "Falta completar este campo")]
        public uint identificacion {get;set;}
        public byte edad {get;set;}
        public bool estadoCovid {get;set;}
        public Diagnostico diagnostico {get;set;}
    }
}