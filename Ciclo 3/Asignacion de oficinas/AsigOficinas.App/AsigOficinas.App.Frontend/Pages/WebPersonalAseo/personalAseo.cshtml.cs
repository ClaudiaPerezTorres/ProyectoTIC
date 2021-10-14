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
    public class personalAseoModel : PageModel
    {
        private static IRepositorioPersonalDeAseo _repositorioPersonalDeAseo = new RepositorioPersonalDeAseo(new Persistencia.appContext());
        public IEnumerable<PersonalDeAseo> personalDeAseos { get; set; }
        public void OnGet()
        {
            personalDeAseos = _repositorioPersonalDeAseo.GetAllPersonalDeAseo();
        }
    }
}
