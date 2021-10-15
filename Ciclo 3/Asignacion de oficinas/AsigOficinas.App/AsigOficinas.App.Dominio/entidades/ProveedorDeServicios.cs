using System;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class ProveedorDeServicios:Persona
    {
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string servicioRealizado {get;set;}
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string undDesarrolloServicio {get;set;}
    }
}