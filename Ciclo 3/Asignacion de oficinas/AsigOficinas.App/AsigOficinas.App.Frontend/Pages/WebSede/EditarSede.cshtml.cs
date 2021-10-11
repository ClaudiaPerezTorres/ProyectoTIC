using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsigOficinas.App.Persistencia;
using AsigOficinas.App.Dominio;
using System.CodeDom;
using System.Diagnostics;

namespace AsigOficinas.App.Frontend.Pages
{
    public class EditarModel : PageModel
    {
        private static IRepositorioSede _repositorioSede = new RepositorioSede(new Persistencia.appContext());
        [BindProperty]
        public Sede sede {get;set;}
        public IActionResult OnGet(int? idSede)
        {
            Console.WriteLine(idSede);
            if (idSede.HasValue)
            {
                sede = _repositorioSede.GetSede(idSede.Value);
            }
            else
            {
                sede = new Sede();
            }

            if (sede == null)
            {
                return RedirectToPage("./sede");
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost()
        {
            //Console.WriteLine(sede.id);
            //Console.WriteLine(sede.nombre);
            //Console.WriteLine(sede.ubicacion);

            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (sede.id > 0)
                {
                    _repositorioSede.UpdateSede(sede);
                }
                else
                {
                    _repositorioSede.AddSede(sede);
                }
            }
            return RedirectToPage("./sede");
        }
    }
}
