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
    public class EliminarsecretarioDespachoModel : PageModel
    {
        private static IRepositorioSecretarioDeDespacho _repositorioSecretarioDeDespacho = new RepositorioSecretarioDeDespacho(new Persistencia.appContext());
        [BindProperty]
        public SecretarioDeDespacho secretarioDeDespachos { get; set; }
        public IActionResult OnGet(int idSecretarioDeDespacho)
        {
            secretarioDeDespachos = _repositorioSecretarioDeDespacho.GetSecretarioDeDespacho(idSecretarioDeDespacho);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioSecretarioDeDespacho.DeleteSecretarioDeDespacho(secretarioDeDespachos.id);
            return RedirectToPage("./secretarioDespacho");
        }
    }
}
