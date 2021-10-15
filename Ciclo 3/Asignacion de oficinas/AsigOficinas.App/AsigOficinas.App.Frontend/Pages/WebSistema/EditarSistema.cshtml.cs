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
    public class EditarSistemaModel : PageModel
    {
        private static IRepositorioSistema _repositorioSistema = new RepositorioSistema(new Persistencia.appContext());
        [BindProperty]
        public Sistema sistema { get; set; }
        public IActionResult OnGet(int? idSistema)
        {
            if (idSistema.HasValue)
            {
                sistema = _repositorioSistema.GetSistema(idSistema.Value);
            }
            else
            {
                sistema = new Sistema();
            }

            if (sistema == null)
            {
                return RedirectToPage("./sistema");
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
                if (sistema.id > 0)
                {
                    _repositorioSistema.UpdateSistema(sistema);
                }
                else
                {
                    _repositorioSistema.AddSistema(sistema);
                }
            }
            return RedirectToPage("./sistema");
        }
    }
}
