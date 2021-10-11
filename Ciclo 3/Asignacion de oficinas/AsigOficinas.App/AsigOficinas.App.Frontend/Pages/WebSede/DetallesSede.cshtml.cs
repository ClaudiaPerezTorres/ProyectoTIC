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
    public class DetallesModel : PageModel
    {
        private static IRepositorioSede _repositorioSede = new RepositorioSede(new Persistencia.appContext());
        public Sede sede {get;set;}
        public IActionResult OnGet(int idSede)
        {
            sede = _repositorioSede.GetSede(idSede);
            if(sede == null)
            {
                return RedirectToPage("./sede");
            }
            return Page();
        }
    }
}
