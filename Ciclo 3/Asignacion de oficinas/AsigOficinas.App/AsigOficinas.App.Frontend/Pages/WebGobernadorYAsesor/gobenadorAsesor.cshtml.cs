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
    public class gobenadorAsesorModel : PageModel
    {
        private static IRepositorioGobernadorYAsesor _repositorioGobernadorYAsesor = new RepositorioGobernadorYAsesor(new Persistencia.appContext());
        public IEnumerable<GobernadorYAsesor> gobernadorYAsesors { get; set; }
        public void OnGet()
        {
            gobernadorYAsesors = _repositorioGobernadorYAsesor.GetAllGobernadorYAsesor();
        }
    }
}
