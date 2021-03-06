using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioGobernadorYAsesor
    {
        IEnumerable <GobernadorYAsesor> GetAllGobernadorYAsesor();

        // Añadir
        GobernadorYAsesor AddGobernadorYAsesor (GobernadorYAsesor gobernadorYAsesor);

        // Actualizar
        GobernadorYAsesor UpdateGobernadorYAsesor (GobernadorYAsesor gobernadorYAsesor);

        // Borrar
        bool DeleteGobernadorYAsesor (int idGobernadorYAsesor);

        // ver
        GobernadorYAsesor GetGobernadorYAsesor (int idGobernadorYAsesor);

        // Metodos
        Diagnostico asignarDiagnostico(int idGobernadorYAsesor, int idDiagnostico);
    }
}