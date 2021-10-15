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
    public class EditarGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _repositorioGobernacion = new RepositorioGobernacion(new Persistencia.appContext());
        [BindProperty]
        public Gobernacion gobernacion { get; set; }
        public IActionResult OnGet(int? idGobernacion)
        {
            if (idGobernacion.HasValue)
            {
                gobernacion = _repositorioGobernacion.GetGobernacion(idGobernacion.Value);
            }
            else
            {
                gobernacion = new Gobernacion();
            }

            if (gobernacion == null)
            {
                return RedirectToPage("./gobernacion");
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
                if (gobernacion.id > 0)
                {
                    _repositorioGobernacion.UpdateGobernacion(gobernacion);
                }
                else
                {
                    _repositorioGobernacion.AddGobernacion(gobernacion);
                }
            }
            return RedirectToPage("./gobernacion");
        }
    }
}
