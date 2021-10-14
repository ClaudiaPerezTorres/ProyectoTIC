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
    public class EditarproveedorServiciosModel : PageModel
    {
        private static IRepositorioProveedorDeServicios _repositorioProveedorDeServicios = new RepositorioProveedorDeServicios(new Persistencia.appContext());
        [BindProperty]
        public ProveedorDeServicios proveedorDeServicios { get; set; }
        public IActionResult OnGet(int? idProveedorDeServicios)
        {
            if (idProveedorDeServicios.HasValue)
            {
                proveedorDeServicios = _repositorioProveedorDeServicios.GetProveedorDeServicios(idProveedorDeServicios.Value);
            }
            else
            {
                proveedorDeServicios = new ProveedorDeServicios();
            }

            if (proveedorDeServicios == null)
            {
                return RedirectToPage("./proveedorServicios");
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
                if (proveedorDeServicios.id > 0)
                {
                    _repositorioProveedorDeServicios.UpdateProveedorDeServicios(proveedorDeServicios);
                }
                else
                {
                    _repositorioProveedorDeServicios.AddProveedorDeServicios(proveedorDeServicios);
                }
            }
            return RedirectToPage("./proveedorServicios");
        }
    }
}
