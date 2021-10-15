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
    public class DetallesDiagnosticoModel : PageModel
    {
        private static IRepositorioDiagnostico _repositorioDiagnostico = new RepositorioDiagnostico(new Persistencia.appContext());
        [BindProperty]
        public Diagnostico diagnostico {get;set;}
        public IActionResult OnGet(int Diagnostico)
        {
            diagnostico = _repositorioDiagnostico.GetDiagnostico(Diagnostico);
            if(diagnostico == null)
            {
                return RedirectToPage("./diagnostico");
            }
            return Page();
        }
    }
}
