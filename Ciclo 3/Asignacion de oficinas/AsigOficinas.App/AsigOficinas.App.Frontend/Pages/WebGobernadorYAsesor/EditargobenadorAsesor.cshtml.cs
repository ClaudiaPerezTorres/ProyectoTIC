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
    public class EditargobenadorAsesorModel : PageModel
    {
        private static IRepositorioGobernadorYAsesor _repositorioGobernadorYAsesor = new RepositorioGobernadorYAsesor(new Persistencia.appContext());
        [BindProperty]
        public GobernadorYAsesor gobernadorYAsesor { get; set; }
        public IActionResult OnGet(int? idGobernadorYAsesor)
        {
            if (idGobernadorYAsesor.HasValue)
            {
                gobernadorYAsesor = _repositorioGobernadorYAsesor.GetGobernadorYAsesor(idGobernadorYAsesor.Value);
            }
            else
            {
                gobernadorYAsesor = new GobernadorYAsesor();
            }

            if (gobernadorYAsesor == null)
            {
                return RedirectToPage("./gobenadorAsesor");
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
                if (gobernadorYAsesor.id > 0)
                {
                    _repositorioGobernadorYAsesor.UpdateGobernadorYAsesor(gobernadorYAsesor);
                }
                else
                {
                    _repositorioGobernadorYAsesor.AddGobernadorYAsesor(gobernadorYAsesor);
                }
            }
            return RedirectToPage("./gobenadorAsesor");
        }
    }
}
