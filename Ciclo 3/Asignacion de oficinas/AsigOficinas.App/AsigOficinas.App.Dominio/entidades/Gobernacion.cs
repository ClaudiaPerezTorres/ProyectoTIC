using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Gobernacion
    {
        public int id {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string ubicacion {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(90, MinimumLength = 10)]
        public string direccion {get;set;}
        public uint telefono {get;set;}
        public List<Sede> sedes {get;set;}
    }
}