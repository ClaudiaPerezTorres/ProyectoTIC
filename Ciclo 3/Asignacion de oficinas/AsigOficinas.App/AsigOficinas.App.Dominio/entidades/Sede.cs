using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Sede
    {
        public int id {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 3)]
        public string nombre {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 3)]
        public string ubicacion {get;set;}
        public List<Oficina> oficinas {get;set;}
    }
}