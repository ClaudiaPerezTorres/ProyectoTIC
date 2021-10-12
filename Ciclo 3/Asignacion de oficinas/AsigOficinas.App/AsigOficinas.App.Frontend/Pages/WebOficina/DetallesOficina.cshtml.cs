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
    public class DetallesOficinaModel : PageModel
    {
        private static IRepositorioOficina _repositorioOficina = new RepositorioOficina(new Persistencia.appContext());
        [BindProperty]
        public Oficina oficina { get; set; }
        public IActionResult OnGet(int idOficina)
        {
            oficina = _repositorioOficina.GetOficina(idOficina);
            if (oficina == null)
            {
                return RedirectToPage("./Oficina");
            }
            return Page();
        }
    }
}
