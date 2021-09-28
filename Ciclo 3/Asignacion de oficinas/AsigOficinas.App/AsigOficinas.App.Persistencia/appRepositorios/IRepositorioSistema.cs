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
        void DeleteSistema (int sistema);

        // ver
        Sistema GetSistema (int idSistema);
    }
}