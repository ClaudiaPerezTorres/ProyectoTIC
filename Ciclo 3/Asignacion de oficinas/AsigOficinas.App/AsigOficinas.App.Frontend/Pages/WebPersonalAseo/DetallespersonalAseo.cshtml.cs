using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsigOficinas.App.Persistencia;
using AsigOficinas.App.Dominio;
using System.Diagnostics;

namespace AsigOficinas.App.Frontend.Pages
{
    public class DetallespersonalAseoModel : PageModel
    {
        private static IRepositorioPersonalDeAseo _repositorioPersonalDeAseo = new RepositorioPersonalDeAseo(new Persistencia.appContext());
        public PersonalDeAseo personalDeAseo { get; set; }public IActionResult OnGet(int idPersonalDeAseo)
        {
            personalDeAseo = _repositorioPersonalDeAseo.GetPersonalDeAseo(idPersonalDeAseo);
            if(personalDeAseo == null)
            {
                return RedirectToPage("./personalAseo");
            }
            return Page();
        }
    }
}
