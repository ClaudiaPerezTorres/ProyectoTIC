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
    public class sistemaModel : PageModel
    {
        private static IRepositorioSistema _repositorioSistema = new RepositorioSistema(new Persistencia.appContext());
        public IEnumerable<Sistema> sistemas {get;set;}
        public void OnGet()
        {
            sistemas = _repositorioSistema.GetAllSistema();
        }
    }
}
