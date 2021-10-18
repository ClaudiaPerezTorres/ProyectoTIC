using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia;
using AsigOficinas.App.Persistencia.appRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AsigOficinas.App.Frontend.Pages
{
    public class principalModel : PageModel
    {
        //ASEO
        private static IRepositorioPersonalDeAseo _repositorioPersonalDeAseo = new RepositorioPersonalDeAseo(new Persistencia.appContext());
        public IEnumerable<PersonalDeAseo> personalDeAseos { get; set; }
        
        // SERVICIOS
        private static IRepositorioProveedorDeServicios _repositorioProveedorDeServicios = new RepositorioProveedorDeServicios(new Persistencia.appContext());
        public IEnumerable<ProveedorDeServicios> proveedoresDeServicios { get; set; }

        //DESPACHO
        private static IRepositorioSecretarioDeDespacho _repositorioSecretarioDeDespacho = new RepositorioSecretarioDeDespacho(new Persistencia.appContext());
        public IEnumerable<SecretarioDeDespacho> secretariosDeDespachos { get; set; }

        //GOBERNADOR
        private static IRepositorioGobernadorYAsesor _repositorioGobernadorYAsesor = new RepositorioGobernadorYAsesor(new Persistencia.appContext());
        public IEnumerable<GobernadorYAsesor> gobernadorYAsesors { get; set; }
        public void OnGet()
        {
            personalDeAseos = _repositorioPersonalDeAseo.GetAllPersonalDeAseo();
            proveedoresDeServicios = _repositorioProveedorDeServicios.GetAllProveedorDeServicios();
            secretariosDeDespachos = _repositorioSecretarioDeDespacho.GetAllSecretarioDeDespacho();
            gobernadorYAsesors = _repositorioGobernadorYAsesor.GetAllGobernadorYAsesor();
        }
    }
}
