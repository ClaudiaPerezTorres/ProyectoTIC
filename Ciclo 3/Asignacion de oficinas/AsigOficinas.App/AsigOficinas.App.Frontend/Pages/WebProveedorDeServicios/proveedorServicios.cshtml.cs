using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia.appRepositorios;

namespace AsigOficinas.App.Frontend.Pages
{
    public class proveedorServiciosModel : PageModel
    {
        private static IRepositorioProveedorDeServicios _repositorioProveedorDeServicios = new RepositorioProveedorDeServicios(new Persistencia.appContext());
        public IEnumerable<ProveedorDeServicios> proveedoresDeServicios { get; set; }
        public void OnGet()
        {
            proveedoresDeServicios = _repositorioProveedorDeServicios.GetAllProveedorDeServicios();
        }
    }
}
