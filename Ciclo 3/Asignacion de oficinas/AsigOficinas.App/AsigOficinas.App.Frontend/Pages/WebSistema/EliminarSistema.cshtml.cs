using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsigOficinas.App.Frontend.Pages
{
    public class EliminarSistemaModel : PageModel
    {
        private static IRepositorioSistema _repositorioSistema = new RepositorioSistema(new Persistencia.appContext());
        [BindProperty]
        public Sistema sistema {get;set;}
        public IActionResult OnGet(int idSistema)
        {
            sistema = _repositorioSistema.GetSistema(idSistema);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioSistema.DeleteSistema(sistema.id);
            return RedirectToPage("./sistema");
        }
    }
}
