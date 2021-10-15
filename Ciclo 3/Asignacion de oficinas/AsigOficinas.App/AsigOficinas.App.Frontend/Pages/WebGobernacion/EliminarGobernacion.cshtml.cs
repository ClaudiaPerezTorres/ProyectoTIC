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
    public class EliminarGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _repositorioGobernacion = new RepositorioGobernacion(new Persistencia.appContext());
        [BindProperty]
        public Gobernacion gobernacion { get; set; }
        public IActionResult OnGet(int idGobernacion)
        {
            gobernacion = _repositorioGobernacion.GetGobernacion(idGobernacion);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioGobernacion.DeleteGobernacion(gobernacion.id);
            return RedirectToPage("./gobernacion");
        }
    }
}
