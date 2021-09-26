using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioOficina
    {
        /*IEnumerable <PersonalDeAseo> GetAllPersonalDeAseo();
        IEnumerable <ProveedorDeServicios> GetAllProveedorDeServicios();
        IEnumerable <SecretarioDeDespacho> GetAllSecretarioDeDespacho();
        IEnumerable <GobernadorYAsesor> GetAllGobernadorYAsesor();*/
        IEnumerable <Oficina> GetAllOficina();

        // Añadir
        /*PersonalDeAseo AddPersonalDeAseo (PersonalDeAseo personalDeAseo);
        ProveedorDeServicios AddProveedorDeServicios (ProveedorDeServicios proveedorDeServicios);
        SecretarioDeDespacho AddSecretarioDeDespacho (SecretarioDeDespacho secretarioDeDespacho);
        GobernadorYAsesor AddGobernadorYAsesor (GobernadorYAsesor gobernadorYAsesor);*/
        Oficina AddOficina (Oficina oficina);

        // Actualizar
        /*PersonalDeAseo UpdatePersonalDeAseo (PersonalDeAseo personalDeAseo);
        ProveedorDeServicios UpdateProveedorDeServicios (ProveedorDeServicios proveedorDeServicios);
        SecretarioDeDespacho UpdateSecretarioDeDespacho (SecretarioDeDespacho secretarioDeDespacho);
        GobernadorYAsesor UpdateGobernadorYAsesor (GobernadorYAsesor gobernadorYAsesor);*/
        Oficina UpdateOficina (Oficina oficina);

        // Borrar
        /*void DeletePersonalDeAseo (int idPersonalDeAseo); 
        void DeleteProveedorDeServicios (int idProveedorDeServicios); 
        void DeleteSecretarioDeDespacho (int idSecretarioDeDespacho); 
        void DeleteGobernadorYAsesor (int idGobernadorYAsesor);*/
        void DeleteOficina (int oficina);

        // ver
        /*PersonalDeAseo GetPersonalDeAseo (int idPersonalDeAseo);
        ProveedorDeServicios GetProveedorDeServicios (int idProveedorDeServicios);
        SecretarioDeDespacho GetSecretarioDeDespacho (int idSecretarioDeDespacho);
        GobernadorYAsesor GetGobernadorYAsesor (int idGobernadorYAsesor);*/
        Oficina GetOficina (int idOficina);
    }
}