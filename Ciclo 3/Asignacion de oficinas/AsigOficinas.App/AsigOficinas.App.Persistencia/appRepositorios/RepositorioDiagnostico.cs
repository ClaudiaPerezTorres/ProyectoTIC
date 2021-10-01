using System;
using System.Collections.Generic;
using System.Linq;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
        /// <summary>
        /// Referencia al contexto de Diagostico
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioDiagnostico (appContext appContext)
        {
            _appContext=appContext;
        }
        Diagnostico IRepositorioDiagnostico.AddDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoAdicionado= _appContext.Diagnostico.Add(diagnostico);
            _appContext.SaveChanges();
            return diagnosticoAdicionado.Entity;
        }

        void IRepositorioDiagnostico.DeleteDiagnostico(int idDiagnostico)
        {
            var diagnosticoEncontrado= _appContext.Diagnostico.FirstOrDefault(d=>d.id == idDiagnostico);
            if(diagnosticoEncontrado==null)
                return;
            _appContext.Diagnostico.Remove(diagnosticoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Diagnostico> IRepositorioDiagnostico.GetAllDiagnostico()
        {
            return _appContext.Diagnostico;
        }

        Diagnostico IRepositorioDiagnostico.GetDiagnostico(int idDiagnostico)
        {
            return _appContext.Diagnostico.FirstOrDefault(d=>d.id == idDiagnostico);
        }

        Diagnostico IRepositorioDiagnostico.UpdateDiagnostico(Diagnostico diagnostico)
        {
            var diagnosticoEncontrado = _appContext.Diagnostico.FirstOrDefault(a=>a.id == diagnostico.id);
            if (diagnosticoEncontrado!=null)
            {
                diagnosticoEncontrado.sintomas = diagnostico.sintomas;
                diagnosticoEncontrado.fechaDiagnostico = diagnostico.fechaDiagnostico;
                _appContext.SaveChanges();
            }
            return diagnosticoEncontrado;
        }
    }
}