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
    public class SedeModel : PageModel
    {
        private static IRepositorioSede _repositorioSede = new RepositorioSede(new Persistencia.appContext());
        public IEnumerable<Sede> Sedes {get;set;}
        public void OnGet()
        {
            Sedes = _repositorioSede.GetAllSede();
        }
    }
}
