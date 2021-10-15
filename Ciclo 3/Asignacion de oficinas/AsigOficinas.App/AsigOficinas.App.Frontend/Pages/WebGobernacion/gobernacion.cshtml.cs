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
    public class gobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _repositorioGobernacion = new RepositorioGobernacion(new Persistencia.appContext());
        public IEnumerable<Gobernacion> gobernacions { get; set; }
        public void OnGet()
        {
            gobernacions = _repositorioGobernacion.GetAllGobernacion();
        }
    }
}
