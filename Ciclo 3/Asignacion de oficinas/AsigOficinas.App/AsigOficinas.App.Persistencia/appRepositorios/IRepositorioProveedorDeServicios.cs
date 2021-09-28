using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia.appRepositorios
{
    public interface IRepositorioProveedorDeServicios
    {
        IEnumerable <ProveedorDeServicios> GetAllProveedorDeServicios();

        // Añadir
        ProveedorDeServicios AddProveedorDeServicios (ProveedorDeServicios proveedorDeServicios);

        // Actualizar
        ProveedorDeServicios UpdateProveedorDeServicios (ProveedorDeServicios proveedorDeServicios);

        // Borrar 
        void DeleteProveedorDeServicios (int idProveedorDeServicios); 

        // ver
        ProveedorDeServicios GetProveedorDeServicios (int idProveedorDeServicios);
    }
}