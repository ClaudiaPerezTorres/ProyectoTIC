using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioSede : IRepositorioSede
    {
        /// <summary>
        /// Referencia al contexto de Oficina
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioSede (appContext appContext)
        {
            _appContext=appContext;
        }
        Sede IRepositorioSede.AddSede(Sede sede)
        {
            var sedeAdicionada= _appContext.Sede.Add(sede);
            _appContext.SaveChanges();
            return sedeAdicionada.Entity;
        }

        void IRepositorioSede.DeleteSede(int idSede)
        {
            var sedeEncontrada= _appContext.Sede.FirstOrDefault(s=>s.id == idSede);
            if(sedeEncontrada==null)
                return;
            _appContext.Sede.Remove(sedeEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Sede> GetAllSede()
        {
            return _appContext.Sede;
        }

        Sede IRepositorioSede.GetSede(int idSede)
        {
            return _appContext.Sede.FirstOrDefault(s=>s.id == idSede);
        }

        Sede IRepositorioSede.UpdateSede(Sede sede)
        {
            var sedeEncontrada = _appContext.Sede.FirstOrDefault(s=>s.id == sede.id);
            if (sedeEncontrada!=null)
            {
                sedeEncontrada.nombre = sede.nombre;
                sedeEncontrada.ubicacion = sede.ubicacion;
                _appContext.SaveChanges();
            }
            return sedeEncontrada;
        }
    }
}