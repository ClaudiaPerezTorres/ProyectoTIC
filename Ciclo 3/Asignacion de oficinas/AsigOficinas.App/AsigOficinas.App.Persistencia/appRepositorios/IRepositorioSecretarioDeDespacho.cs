using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioSecretarioDeDespacho
    {
        IEnumerable <SecretarioDeDespacho> GetAllSecretarioDeDespacho();

        // Añadir
        SecretarioDeDespacho AddSecretarioDeDespacho (SecretarioDeDespacho secretarioDeDespacho);

        // Actualizar
        SecretarioDeDespacho UpdateSecretarioDeDespacho (SecretarioDeDespacho secretarioDeDespacho);

        // Borrar
        void DeleteSecretarioDeDespacho (int idSecretarioDeDespacho); 

        // ver
        SecretarioDeDespacho GetSecretarioDeDespacho (int idSecretarioDeDespacho); 
    }
}