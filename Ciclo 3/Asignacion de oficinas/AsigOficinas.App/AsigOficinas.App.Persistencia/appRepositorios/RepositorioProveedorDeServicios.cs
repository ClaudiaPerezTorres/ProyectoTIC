using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia.appRepositorios
{
    public class RepositorioProveedorDeServicios : IRepositorioProveedorDeServicios
    {
        /// <summary>
        /// Referencia al contexto de sede
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioProveedorDeServicios (appContext appContext)
        {
            _appContext=appContext;
        }
        ProveedorDeServicios IRepositorioProveedorDeServicios.AddProveedorDeServicios(ProveedorDeServicios proveedorDeServicios)
        {
            var proveedorDeServiciosAdicionada= _appContext.ProveedorDeServicios.Add(proveedorDeServicios);
            _appContext.SaveChanges();
            return proveedorDeServiciosAdicionada.Entity;
        }

        void IRepositorioProveedorDeServicios.DeleteProveedorDeServicios(int idProveedorDeServicios)
        {
            var proveedorDeServiciosEncontrada= _appContext.ProveedorDeServicios.FirstOrDefault(p=>p.id == idProveedorDeServicios);
            if(proveedorDeServiciosEncontrada==null)
                return;
            _appContext.ProveedorDeServicios.Remove(proveedorDeServiciosEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<ProveedorDeServicios> IRepositorioProveedorDeServicios.GetAllProveedorDeServicios()
        {
            return _appContext.ProveedorDeServicios;
        }

        ProveedorDeServicios IRepositorioProveedorDeServicios.GetProveedorDeServicios(int idProveedorDeServicios)
        {
            return _appContext.ProveedorDeServicios.FirstOrDefault(p=>p.id == idProveedorDeServicios);
        }

        ProveedorDeServicios IRepositorioProveedorDeServicios.UpdateProveedorDeServicios(ProveedorDeServicios proveedorDeServicios)
        {
            var proveedorDeServiciosEncontrada = _appContext.ProveedorDeServicios.FirstOrDefault(p=>p.id == proveedorDeServicios.id);
            if (proveedorDeServiciosEncontrada!=null)
            {
                proveedorDeServiciosEncontrada.nombre = proveedorDeServicios.nombre;
                proveedorDeServiciosEncontrada.apellido = proveedorDeServicios.apellido;
                proveedorDeServiciosEncontrada.identificacion = proveedorDeServicios.identificacion;
                proveedorDeServiciosEncontrada.edad = proveedorDeServicios.edad;
                proveedorDeServiciosEncontrada.estadoCovid = proveedorDeServicios.estadoCovid;
                proveedorDeServiciosEncontrada.servicioRealizado = proveedorDeServicios.servicioRealizado;
                proveedorDeServiciosEncontrada.undDesarrolloServicio = proveedorDeServicios.undDesarrolloServicio;
                _appContext.SaveChanges();
            }
            return proveedorDeServiciosEncontrada;
        }
    }
}