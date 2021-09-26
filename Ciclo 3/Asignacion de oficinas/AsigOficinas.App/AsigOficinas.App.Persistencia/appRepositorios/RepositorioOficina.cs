using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{

    public class RepositorioOficina:IRepositorioOficina
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
        public RepositorioOficina (appContext appContext)
        {
            _appContext=appContext;
        }

        Oficina IRepositorioOficina.AddOficina (Oficina oficina)
        {
            var oficinaAdicionada= _appContext.Oficina.Add(oficina);
            _appContext.SaveChanges();
            return oficinaAdicionada.Entity;
        }

        Oficina IRepositorioOficina.UpdateOficina (Oficina oficina)
        {
            var oficinaEncontrada= _appContext.Oficina.FirstOrDefault(o=>o.id == oficina.id);
            if (oficinaEncontrada!=null)
            {
                oficinaEncontrada.numero = oficina.numero;
                oficinaEncontrada.aforo = oficina.aforo;
                oficinaEncontrada.horaLaboral = oficina.horaLaboral;
                oficinaEncontrada.estadoOficina = oficina.estadoOficina;
                oficinaEncontrada.numeroPersonas = oficina.numeroPersonas;
                _appContext.SaveChanges();
            }
            return oficinaEncontrada;
        }

        void IRepositorioOficina.DeleteOficina (int idOficina)
        {
            var oficinaEncontrada= _appContext.Oficina.FirstOrDefault(o=>o.id == idOficina);
            if(oficinaEncontrada==null)
                return;
            _appContext.Oficina.Remove(oficinaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Oficina> IRepositorioOficina.GetAllOficina ()
        {
            return _appContext.Oficina;
        }

        Oficina IRepositorioOficina.GetOficina (int idOficina)
        {
            return _appContext.Oficina.FirstOrDefault(o=>o.id == idOficina);
        }
    }
}