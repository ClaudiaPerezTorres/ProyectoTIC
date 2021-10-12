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
    public class EditarOficinaModel : PageModel
    {
        private static IRepositorioOficina _repositorioOficina = new RepositorioOficina(new Persistencia.appContext());
        [BindProperty]
        public Oficina oficina { get; set; }
        public IActionResult OnGet(int? idOficina)
        {
            if (idOficina.HasValue)
            {
                oficina = _repositorioOficina.GetOficina(idOficina.Value);
            }
            else
            {
                oficina = new Oficina();
            }

            if (oficina == null)
            {
                return RedirectToPage("./oficina");
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
                if (oficina.id > 0)
                {
                    _repositorioOficina.UpdateOficina(oficina);
                }
                else
                {
                    _repositorioOficina.AddOficina(oficina);
                }
            }
            return RedirectToPage("./oficina");
        }
    }
}
