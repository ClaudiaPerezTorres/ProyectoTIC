using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioSistema
    {
        IEnumerable <Sistema> GetAllSistema();

        // Añadir
        Sistema AddSistema (Sistema sistema);

        // Actualizar
        Sistema UpdateSistema (Sistema sistema);

        // Borrar
        void DeleteSistema (int idSistema);

        // ver
        Sistema GetSistema (int idSistema);

        // Metodos
        bool verificarEstadoCovid (PersonalDeAseo personalDeAseo);
        bool verificarEstadoCovid (ProveedorDeServicios proveedorDeServicios);
        bool verificarEstadoCovid (SecretarioDeDespacho secretarioDeDespacho);
        bool verificarEstadoCovid (GobernadorYAsesor gobernadorYAsesor);
        void ingresa (PersonalDeAseo personalDeAseo);
        void ingresa (ProveedorDeServicios proveedorDeServicios);
        void ingresa (SecretarioDeDespacho secretarioDeDespacho);
        void ingresa (GobernadorYAsesor gobernadorYAsesor);
        void sale (PersonalDeAseo personalDeAseo);
        void sale (ProveedorDeServicios proveedorDeServicios);
        void sale (SecretarioDeDespacho secretarioDeDespacho);
        void sale (GobernadorYAsesor gobernadorYAsesor);
    }
}