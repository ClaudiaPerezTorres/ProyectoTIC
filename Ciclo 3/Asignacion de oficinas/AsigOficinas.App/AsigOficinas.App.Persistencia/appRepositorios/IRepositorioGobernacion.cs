using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioGobernacion
    {
        IEnumerable <Gobernacion> GetAllGobernacion();

        // Añadir
        Gobernacion AddGobernacion (Gobernacion gobernacion);

        // Actualizar
        Gobernacion UpdateGobernacion (Gobernacion gobernacion);

        // Borrar 
        void DeleteGobernacion (int idGobernacion);

        // ver
        Gobernacion GetGobernacion (int idGobernacion);
    }
}