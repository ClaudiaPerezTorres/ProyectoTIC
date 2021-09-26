using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;
// si da error cambiar Oficina a Oficinas
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
            var oficinaAdicionado= _appContext.Oficina.Add(oficina);
            _appContext.SaveChanges();
            return oficinaAdicionado.Entity;
        }

        Oficina IRepositorioOficina.UpdateOficina (Oficina oficina)
        {
            var oficinaEncontrado= _appContext.Oficina.FirstOrDefault(p=>p.id == oficina.id);
            if (oficinaEncontrado!=null)
            {
                oficinaEncontrado.numero = oficina.numero;
                oficinaEncontrado.aforo = oficina.aforo;
                oficinaEncontrado.horaLaboral = oficina.horaLaboral;
                oficinaEncontrado.estadoOficina = oficina.estadoOficina;
                oficinaEncontrado.numeroPersonas = oficina.numeroPersonas;
                _appContext.SaveChanges();
            }
            return oficinaEncontrado;
        }

        void IRepositorioOficina.DeleteOficina (int idOficina)
        {
            var oficinaEncontrado= _appContext.Oficina.FirstOrDefault(p=>p.id == idOficina);
            if(oficinaEncontrado==null)
                return;
            _appContext.Oficina.Remove(oficinaEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Oficina> IRepositorioOficina.GetAllOficina ()
        {
            return _appContext.Oficina;
        }

        Oficina IRepositorioOficina.GetOficina (int idOficina)
        {
            return _appContext.Oficina.FirstOrDefault(p=>p.id == idOficina);
        }
    }
}