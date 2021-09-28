using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioPersonalDeAseo : IRepositorioPersonalDeAseo
    {
        /// <summary>
        /// Referencia al contexto de Presonal De Aseo
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioPersonalDeAseo (appContext appContext)
        {
            _appContext=appContext;
        }
        PersonalDeAseo IRepositorioPersonalDeAseo.AddPersonalDeAseo(PersonalDeAseo personalDeAseo)
        {
            var PersonalDeAseoAdicionada= _appContext.PersonalDeAseo.Add(personalDeAseo);
            _appContext.SaveChanges();
            return PersonalDeAseoAdicionada.Entity;
        }

        void IRepositorioPersonalDeAseo.DeletePersonalDeAseo(int idPersonalDeAseo)
        {
            var PersonalDeAseoEncontrada= _appContext.PersonalDeAseo.FirstOrDefault(a=>a.id == idPersonalDeAseo);
            if(PersonalDeAseoEncontrada==null)
                return;
            _appContext.PersonalDeAseo.Remove(PersonalDeAseoEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<PersonalDeAseo> GetAllPersonalDeAseo()
        {
            return _appContext.PersonalDeAseo;
        }

        PersonalDeAseo IRepositorioPersonalDeAseo.GetPersonalDeAseo(int idPersonalDeAseo)
        {
            return _appContext.PersonalDeAseo.FirstOrDefault(a=>a.id == idPersonalDeAseo);
        }

        PersonalDeAseo IRepositorioPersonalDeAseo.UpdatePersonalDeAseo(PersonalDeAseo personalDeAseo)
        {
            var PersonalDeAseoEncontrada = _appContext.PersonalDeAseo.FirstOrDefault(a=>a.id == personalDeAseo.id);
            if (PersonalDeAseoEncontrada!=null)
            {
                PersonalDeAseoEncontrada.nombre = personalDeAseo.nombre;
                PersonalDeAseoEncontrada.apellido = personalDeAseo.apellido;
                PersonalDeAseoEncontrada.identificacion = personalDeAseo.identificacion;
                PersonalDeAseoEncontrada.edad = personalDeAseo.edad;
                PersonalDeAseoEncontrada.estadoCovid = personalDeAseo.estadoCovid;
                PersonalDeAseoEncontrada.turnoDesarrolloServicio = personalDeAseo.turnoDesarrolloServicio;
                _appContext.SaveChanges();
            }
            return PersonalDeAseoEncontrada;
        }
    }
}