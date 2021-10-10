using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioGobernadorYAsesor : IRepositorioGobernadorYAsesor
    {
        /// <summary>
        /// Referencia al contexto de Goberador y asesor
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioGobernadorYAsesor(appContext appContext)
        {
            _appContext = appContext;
        }

        Diagnostico IRepositorioGobernadorYAsesor.asignarDiagnostico(int idGobernadorYAsesor, int idDiagnostico)
        {
            var gobernadorYAsesorEncontrado = _appContext.GobernadorYAsesor.FirstOrDefault(g => g.id == idGobernadorYAsesor);
            if (gobernadorYAsesorEncontrado != null)
            {
                var diagnosticoEncontrado = _appContext.Diagnostico.FirstOrDefault(d => d.id == idDiagnostico);
                if (diagnosticoEncontrado != null)
                {
                    gobernadorYAsesorEncontrado.diagnostico = diagnosticoEncontrado;
                    _appContext.SaveChanges();
                }
                return diagnosticoEncontrado;
            }
            return null;
        }

        GobernadorYAsesor IRepositorioGobernadorYAsesor.AddGobernadorYAsesor(GobernadorYAsesor gobernadorYAsesor)
        {
            var gobernadorYAsesorAdicionado = _appContext.GobernadorYAsesor.Add(gobernadorYAsesor);
            _appContext.SaveChanges();
            return gobernadorYAsesorAdicionado.Entity;
        }

        bool IRepositorioGobernadorYAsesor.DeleteGobernadorYAsesor(int idGobernadorYAsesor)
        {
            var gobernadorYAsesorEncontrado = _appContext.GobernadorYAsesor.FirstOrDefault(a => a.id == idGobernadorYAsesor);
            if (gobernadorYAsesorEncontrado == null)
                return false;
            _appContext.GobernadorYAsesor.Remove(gobernadorYAsesorEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<GobernadorYAsesor> IRepositorioGobernadorYAsesor.GetAllGobernadorYAsesor()
        {
            return _appContext.GobernadorYAsesor;
        }

        GobernadorYAsesor IRepositorioGobernadorYAsesor.GetGobernadorYAsesor(int idGobernadorYAsesor)
        {
            return _appContext.GobernadorYAsesor.FirstOrDefault(a => a.id == idGobernadorYAsesor);
        }

        GobernadorYAsesor IRepositorioGobernadorYAsesor.UpdateGobernadorYAsesor(GobernadorYAsesor gobernadorYAsesor)
        {
            var GobernadorYAsesorEncontrado = _appContext.GobernadorYAsesor.FirstOrDefault(a => a.id == gobernadorYAsesor.id);
            if (GobernadorYAsesorEncontrado != null)
            {
                GobernadorYAsesorEncontrado.nombre = gobernadorYAsesor.nombre;
                GobernadorYAsesorEncontrado.apellido = gobernadorYAsesor.apellido;
                GobernadorYAsesorEncontrado.identificacion = gobernadorYAsesor.identificacion;
                GobernadorYAsesorEncontrado.edad = gobernadorYAsesor.edad;
                GobernadorYAsesorEncontrado.estadoCovid = gobernadorYAsesor.estadoCovid;
                GobernadorYAsesorEncontrado.oficinasVisitadas = gobernadorYAsesor.oficinasVisitadas;
                _appContext.SaveChanges();
            }
            return GobernadorYAsesorEncontrado;
        }
    }
}