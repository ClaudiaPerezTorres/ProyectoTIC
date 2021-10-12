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
    public class oficinaModel : PageModel
    {
        private static IRepositorioOficina _repositorioOficina = new RepositorioOficina(new Persistencia.appContext());
        public IEnumerable<Oficina> Oficinas { get; set; }
        public void OnGet()
        {
            Oficinas = _repositorioOficina.GetAllOficina();
        }
    }
}
