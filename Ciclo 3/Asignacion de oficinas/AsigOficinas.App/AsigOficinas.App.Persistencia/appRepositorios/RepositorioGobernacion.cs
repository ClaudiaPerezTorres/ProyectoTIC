using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq; 

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioGobernacion : IRepositorioGobernacion
    {
        /// <summary>
        /// Referencia al contexto de Gobernación
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

        bool IRepositorioGobernacion.DeleteGobernacion(int idGobernacion)
        {
            var gobernacionEncontrada= _appContext.Gobernacion.FirstOrDefault(g=>g.id == idGobernacion);
            if(gobernacionEncontrada==null)
                return false;
            _appContext.Gobernacion.Remove(gobernacionEncontrada);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Gobernacion> IRepositorioGobernacion.GetAllGobernacion()
        {
            return _appContext.Gobernacion;
        }

        Gobernacion IRepositorioGobernacion.GetGobernacion(int idGobernacion)
        {
            return _appContext.Gobernacion.FirstOrDefault(g=>g.id == idGobernacion);
        }

        Gobernacion IRepositorioGobernacion.UpdateGobernacion(Gobernacion gobernacion)
        {
            var gobernacionEncontrada= _appContext.Gobernacion.FirstOrDefault(g=>g.id == gobernacion.id);
            if (gobernacionEncontrada!=null)
            {
                gobernacionEncontrada.ubicacion = gobernacion.ubicacion;
                gobernacionEncontrada.direccion = gobernacion.direccion;
                gobernacionEncontrada.telefono = gobernacion.telefono;
                gobernacionEncontrada.sedes = gobernacion.sedes;
                _appContext.SaveChanges();
            }
            return gobernacionEncontrada;
        }
    }
}