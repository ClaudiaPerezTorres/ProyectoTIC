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
    public class EditarsecretarioDespachoModel : PageModel
    {
        private static IRepositorioSecretarioDeDespacho _repositorioSecretarioDeDespacho = new RepositorioSecretarioDeDespacho(new Persistencia.appContext());
        [BindProperty]
        public SecretarioDeDespacho secretarioDeDespachos { get; set; }
public IActionResult OnGet(int? idSecretarioDeDespacho)
        {
            if (idSecretarioDeDespacho.HasValue)
            {
                secretarioDeDespachos = _repositorioSecretarioDeDespacho.GetSecretarioDeDespacho(idSecretarioDeDespacho.Value);
            }
            else
            {
                secretarioDeDespachos = new SecretarioDeDespacho();
            }

            if (secretarioDeDespachos == null)
            {
                return RedirectToPage("./secretarioDespacho");
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
                if (secretarioDeDespachos.id > 0)
                {
                    _repositorioSecretarioDeDespacho.UpdateSecretarioDeDespacho(secretarioDeDespachos);
                }
                else
                {
                    _repositorioSecretarioDeDespacho.AddSecretarioDeDespacho(secretarioDeDespachos);
                }
            }
            return RedirectToPage("./secretarioDespacho");
        }
    }
}
