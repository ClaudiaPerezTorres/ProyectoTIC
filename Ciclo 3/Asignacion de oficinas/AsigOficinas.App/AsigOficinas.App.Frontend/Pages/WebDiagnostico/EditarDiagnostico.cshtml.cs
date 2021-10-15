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
    public class EditarDiagnosticoModel : PageModel
    {
        private static IRepositorioDiagnostico _repositorioDiagnostico = new RepositorioDiagnostico(new Persistencia.appContext());
        [BindProperty]
        public Diagnostico diagnostico { get; set; }
        public IActionResult OnGet(int? idDiagnostico)
        {
            if (idDiagnostico.HasValue)
            {
                diagnostico = _repositorioDiagnostico.GetDiagnostico(idDiagnostico.Value);
            }
            else
            {
                diagnostico = new Diagnostico();
            }

            if (diagnostico == null)
            {
                return RedirectToPage("./diagnostico");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (diagnostico.id > 0)
                {
                    _repositorioDiagnostico.UpdateDiagnostico(diagnostico);
                }
                else
                {
                    _repositorioDiagnostico.AddDiagnostico(diagnostico);
                }
            }
            return RedirectToPage("./diagnostico");
        }
    }
}
