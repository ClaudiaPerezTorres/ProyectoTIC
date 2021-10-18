using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioSistema : IRepositorioSistema
    {
        /// <summary>
        /// Referencia al contexto de Sistema
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioSistema (appContext appContext)
        {
            _appContext=appContext;
        }
        Sistema IRepositorioSistema.AddSistema(Sistema sistema)
        {
            var sistemaAdicionado= _appContext.Sistema.Add(sistema);
            _appContext.SaveChanges();
            return sistemaAdicionado.Entity;
        }

        bool IRepositorioSistema.DeleteSistema(int idSistema)
        {
            var sistemaEncontrado= _appContext.Sistema.FirstOrDefault(a=>a.id == idSistema);
            if(sistemaEncontrado==null)
                return false;
            _appContext.Sistema.Remove(sistemaEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Sistema> IRepositorioSistema.GetAllSistema()
        {
            return _appContext.Sistema;
        }

        Sistema IRepositorioSistema.GetSistema(int idSistema)
        {
            return _appContext.Sistema.FirstOrDefault(s=>s.id == idSistema);
        }

        Sistema IRepositorioSistema.UpdateSistema(Sistema sistema)
        {
            var sistemaEncontrado = _appContext.Sistema.FirstOrDefault(a=>a.id == sistema.id);
            if (sistemaEncontrado!=null)
            {
                sistemaEncontrado.oficina = sistema.oficina;
                _appContext.SaveChanges();
            }
            return sistemaEncontrado;
        }
        
        // Falta aplicar metodos
        public void ingresa(PersonalDeAseo personalDeAseo)
        {
            throw new System.NotImplementedException();
        }

        public void ingresa(ProveedorDeServicios proveedorDeServicios)
        {
            throw new System.NotImplementedException();
        }

        public void ingresa(SecretarioDeDespacho secretarioDeDespacho)
        {
            throw new System.NotImplementedException();
        }

        public void ingresa(GobernadorYAsesor gobernadorYAsesor)
        {
            throw new System.NotImplementedException();
        }

        public void sale(PersonalDeAseo personalDeAseo)
        {
            throw new System.NotImplementedException();
        }

        public void sale(ProveedorDeServicios proveedorDeServicios)
        {
            throw new System.NotImplementedException();
        }

        public void sale(SecretarioDeDespacho secretarioDeDespacho)
        {
            throw new System.NotImplementedException();
        }

        public void sale(GobernadorYAsesor gobernadorYAsesor)
        {
            throw new System.NotImplementedException();
        }


        public bool verificarEstadoCovid(PersonalDeAseo personalDeAseo)
        {
            var personalDeAseoEncontrado = _appContext.PersonalDeAseo.FirstOrDefault(a=>a.id == personalDeAseo.id);
            if (personalDeAseoEncontrado!=null)
            {
                if (personalDeAseoEncontrado.estadoCovid)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarEstadoCovid(ProveedorDeServicios proveedorDeServicios)
        {
            var proveedorDeServiciosEncontrado = _appContext.ProveedorDeServicios.FirstOrDefault(a=>a.id == proveedorDeServicios.id);
            if (proveedorDeServiciosEncontrado!=null)
            {
                if (proveedorDeServiciosEncontrado.estadoCovid)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarEstadoCovid(SecretarioDeDespacho secretarioDeDespacho)
        {
            var secretarioDeDespachoEncontrado = _appContext.SecretarioDeDespacho.FirstOrDefault(a=>a.id == secretarioDeDespacho.id);
            if (secretarioDeDespachoEncontrado!=null)
            {
                if (secretarioDeDespachoEncontrado.estadoCovid)
                {
                    return true;
                }
            }
            return false;
        }

        public bool verificarEstadoCovid(GobernadorYAsesor gobernadorYAsesor)
        {
            var gobernadorYAsesorEncontrado = _appContext.GobernadorYAsesor.FirstOrDefault(a=>a.id == gobernadorYAsesor.id);
            if (gobernadorYAsesorEncontrado!=null)
            {
                if (gobernadorYAsesorEncontrado.estadoCovid)
                {
                    return true;
                }
            }
            return false;
        }
    }
}