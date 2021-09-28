using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioDiagnostico
    {
        IEnumerable <Diagnostico> GetAllDiagnostico();

        // Añadir
        Diagnostico AddDiagnostico (Diagnostico diagnostico);

        // Actualizar
        Diagnostico UpdateDiagnostico (Diagnostico diagnostico);

        // Borrar
        void DeleteDiagnostico (int diagnostico);

        // ver
        Diagnostico GetDiagnostico (int idDiagnostico);
    }
}