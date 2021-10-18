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
    public class secretarioDespachoModel : PageModel
    {
        private static IRepositorioSecretarioDeDespacho _repositorioSecretarioDeDespacho = new RepositorioSecretarioDeDespacho(new Persistencia.appContext());
        public IEnumerable<SecretarioDeDespacho> secretariosDeDespachos { get; set; }
        public Diagnostico diagnostico { get; set; }
        public void OnGet(int idDiagnostico)
        {
            secretariosDeDespachos = _repositorioSecretarioDeDespacho.GetAllSecretarioDeDespacho();
        }
    }
}
