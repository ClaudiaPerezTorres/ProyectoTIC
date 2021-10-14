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
    public class DetallessecretarioDespachoModel : PageModel
    {
        private static IRepositorioSecretarioDeDespacho _repositorioSecretarioDeDespacho = new RepositorioSecretarioDeDespacho(new Persistencia.appContext());
        public SecretarioDeDespacho secretarioDeDespachos { get; set; }
        public IActionResult OnGet(int idSecretarioDeDespacho)
        {
            secretarioDeDespachos = _repositorioSecretarioDeDespacho.GetSecretarioDeDespacho(idSecretarioDeDespacho);
            if (secretarioDeDespachos == null)
            {
                return RedirectToPage("./secretarioDespacho");
            }
            return Page();
        }
    }
}
