using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia;

namespace AsigOficinas.App.Frontend.Pages
{
    public class EliminarpersonalAseoModel : PageModel
    {
        private static IRepositorioPersonalDeAseo _repositorioPersonalDeAseo = new RepositorioPersonalDeAseo(new Persistencia.appContext());
        [BindProperty]
        public PersonalDeAseo personalDeAseo { get; set; }
        public IActionResult OnGet(int idPersonalDeAseo)
        {
            personalDeAseo = _repositorioPersonalDeAseo.GetPersonalDeAseo(idPersonalDeAseo);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioPersonalDeAseo.DeletePersonalDeAseo(personalDeAseo.id);
            return RedirectToPage("./personalAseo");
        }
    }
}
