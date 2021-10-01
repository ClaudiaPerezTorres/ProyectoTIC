using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioRegistro
    {
        IEnumerable <Registro> GetAllRegistro();

        // Añadir
        Registro AddRegistro (Registro registro);

        // Actualizar
        Registro UpdateRegistro (Registro registro);

        // Borrar
        void DeleteRegistro (int idRegistro);

        // ver
        Registro GetRegistro (int idRegistro);
    }
}