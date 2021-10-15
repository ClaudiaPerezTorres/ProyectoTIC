using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsigOficinas.App.Dominio
{
    public class Oficina
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(50, MinimumLength = 10)]
        public string numero { get; set; }
        [Required(ErrorMessage = "Falta completar este campo")]
        public ushort aforo { get; set; }
        [Required(ErrorMessage = "Falta completar este campo"), StringLength(90, MinimumLength = 10)]
        public string horaLaboral { get; set; }
        public List<Persona> numeroPersonas { get; set; }
        public bool estadoOficina { get; set; }
    }
}