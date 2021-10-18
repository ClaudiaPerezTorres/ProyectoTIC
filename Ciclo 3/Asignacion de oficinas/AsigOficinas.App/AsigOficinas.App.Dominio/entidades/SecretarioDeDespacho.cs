using System;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class SecretarioDeDespacho:Persona
    {
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 3)]
        public string despacho {get;set;}
    }
}