using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsigOficinas.App.Frontend.Pages
{
    public class EliminarproveedorServiciosModel : PageModel
    {
        private static IRepositorioProveedorDeServicios _repositorioProveedorDeServicios = new RepositorioProveedorDeServicios(new Persistencia.appContext());
        [BindProperty]
        public ProveedorDeServicios proveedorDeServicios { get; set; }
        public IActionResult OnGet(int idProveedorDeServicios)
        {
            proveedorDeServicios = _repositorioProveedorDeServicios.GetProveedorDeServicios(idProveedorDeServicios);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repositorioProveedorDeServicios.DeleteProveedorDeServicios(proveedorDeServicios.id);
            return RedirectToPage("./proveedorServicios");
        }
    }
}
