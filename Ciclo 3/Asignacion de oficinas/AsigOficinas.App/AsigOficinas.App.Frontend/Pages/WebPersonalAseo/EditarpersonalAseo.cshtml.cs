using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsigOficinas.App.Persistencia;
using AsigOficinas.App.Dominio;
using System.CodeDom;
using System.Diagnostics;

namespace AsigOficinas.App.Frontend.Pages
{
    public class EditarpersonalAseoModel : PageModel
    {
        private static IRepositorioPersonalDeAseo _repositorioPersonalDeAseo = new RepositorioPersonalDeAseo(new Persistencia.appContext());
        [BindProperty]
        public PersonalDeAseo personalDeAseo { get; set; }
        public IActionResult OnGet(int? idPersonalDeAseo)
        {
            if (idPersonalDeAseo.HasValue)
            {
                personalDeAseo = _repositorioPersonalDeAseo.GetPersonalDeAseo(idPersonalDeAseo.Value);
            }
            else
            {
                personalDeAseo = new PersonalDeAseo();
            }

            if (personalDeAseo == null)
            {
                return RedirectToPage("./personalAseo");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (personalDeAseo.id > 0)
                {
                    _repositorioPersonalDeAseo.UpdatePersonalDeAseo(personalDeAseo);
                }
                else
                {
                    _repositorioPersonalDeAseo.AddPersonalDeAseo(personalDeAseo);
                }
            }
            return RedirectToPage("./personalAseo");
        }
    }
}
