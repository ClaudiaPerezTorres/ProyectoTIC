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
    public class EliminarModel : PageModel
    {
        private static IRepositorioSede _repositorioSede = new RepositorioSede(new Persistencia.appContext());
        [BindProperty]
        public Sede sede {get;set;}

        public IActionResult OnGet(int idSede)
        {
            sede = _repositorioSede.GetSede(idSede);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioSede.DeleteSede(sede.id);
            return RedirectToPage("./sede");
        }
    }
}
