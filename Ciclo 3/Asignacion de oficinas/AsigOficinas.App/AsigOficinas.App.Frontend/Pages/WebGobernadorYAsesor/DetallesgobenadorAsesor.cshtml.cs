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
    public class DetallesgobenadorAsesorModel : PageModel
    {
        private static IRepositorioGobernadorYAsesor _repositorioGobernadorYAsesor = new RepositorioGobernadorYAsesor(new Persistencia.appContext());
        public GobernadorYAsesor gobernadorYAsesor { get; set; }
        public IActionResult OnGet(int idGobernadorYAsesor)
        {
            gobernadorYAsesor = _repositorioGobernadorYAsesor.GetGobernadorYAsesor(idGobernadorYAsesor);
            if(gobernadorYAsesor == null)
            {
                return RedirectToPage("./gobenadorAsesor");
            }
            return Page();
        }
    }
}
