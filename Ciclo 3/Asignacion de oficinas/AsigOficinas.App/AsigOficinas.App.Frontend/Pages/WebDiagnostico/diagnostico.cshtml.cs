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
    public class diagnosticoModel : PageModel
    {
        private static IRepositorioDiagnostico _repositorioDiagnostico = new RepositorioDiagnostico(new Persistencia.appContext());
        public IEnumerable<Diagnostico> diagnosticos {get;set;}
        public void OnGet()
        {
            diagnosticos = _repositorioDiagnostico.GetAllDiagnostico();
        }
    }
}
