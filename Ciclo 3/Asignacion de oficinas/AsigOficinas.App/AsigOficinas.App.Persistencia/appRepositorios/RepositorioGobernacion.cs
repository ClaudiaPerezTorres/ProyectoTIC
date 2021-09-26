using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq; 

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioGobernacion : IRepositorioGobernacion
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
        public RepositorioGobernacion (appContext appContext)
        {
            _appContext=appContext;
        }
        Gobernacion IRepositorioGobernacion.AddGobernacion(Gobernacion gobernacion)
        {
            var gobernacionAdicionada= _appContext.Gobernacion.Add(gobernacion);
            _appContext.SaveChanges();
            return gobernacionAdicionada.Entity;
        }

        void IRepositorioGobernacion.DeleteGobernacion(int idGobernacion)
        {
            var gobernacionEncontrada= _appContext.Gobernacion.FirstOrDefault(g=>g.id == idGobernacion);
            if(gobernacionEncontrada==null)
                return;
            _appContext.Gobernacion.Remove(gobernacionEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<Gobernacion> GetAllGobernacion()
        {
            throw new NotImplementedException();
        }

        public Gobernacion GetGobernacion(int idgobernacion)
        {
            throw new NotImplementedException();
        }

        public Gobernacion UpdateGobernacion(Gobernacion gobernacion)
        {
            throw new NotImplementedException();
        }
    }
}