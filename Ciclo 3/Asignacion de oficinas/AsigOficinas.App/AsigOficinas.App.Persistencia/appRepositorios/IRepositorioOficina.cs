using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioOficina
    {
        IEnumerable <Oficina> GetAllOficina();

        // Añadir
        Oficina AddOficina (Oficina oficina);

        // Actualizar
        Oficina UpdateOficina (Oficina oficina);

        // Borrar
        bool DeleteOficina (int oficina);

        // ver
        Oficina GetOficina (int idOficina);
    }
}