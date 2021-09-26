using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable <Sede> GetAllSede();

        // Añadir
        Sede AddSede (Sede sede);

        // Actualizar
        Sede UpdateSede (Sede sede);

        // Borrar 
        void DeleteSede (int idSede);

        // ver
        Sede GetSede (int idSede);
    }
}