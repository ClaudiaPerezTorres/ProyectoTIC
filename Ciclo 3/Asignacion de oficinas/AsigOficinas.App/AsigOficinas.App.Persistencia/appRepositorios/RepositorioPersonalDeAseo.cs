using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioPersonalDeAseo : IRepositorioPersonalDeAseo
    {
        /// <summary>
        /// Referencia al contexto de Personal De Aseo
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

        Diagnostico IRepositorioPersonalDeAseo.asignarDiagnostico(int idPersonalDeAseo, int idDiagnostico)
        {
            var personalDeAseoEncontrado = _appContext.PersonalDeAseo.FirstOrDefault(g => g.id == idPersonalDeAseo);
            if (personalDeAseoEncontrado != null)
            {
                var diagnosticoEncontrado = _appContext.Diagnostico.FirstOrDefault(d => d.id == idDiagnostico);
                if (diagnosticoEncontrado != null)
                {
                    personalDeAseoEncontrado.diagnostico = diagnosticoEncontrado;
                    _appContext.SaveChanges();
                }
                return diagnosticoEncontrado;
            }
            return null;
        }

        PersonalDeAseo IRepositorioPersonalDeAseo.AddPersonalDeAseo(PersonalDeAseo personalDeAseo)
        {
            var PersonalDeAseoAdicionada= _appContext.PersonalDeAseo.Add(personalDeAseo);
            _appContext.SaveChanges();
            return PersonalDeAseoAdicionada.Entity;
        }

        bool IRepositorioPersonalDeAseo.DeletePersonalDeAseo(int idPersonalDeAseo)
        {
            var PersonalDeAseoEncontrada= _appContext.PersonalDeAseo.FirstOrDefault(a=>a.id == idPersonalDeAseo);
            if(PersonalDeAseoEncontrada==null)
                return false;
            _appContext.PersonalDeAseo.Remove(PersonalDeAseoEncontrada);
            _appContext.SaveChanges();
            return false;
        }

        IEnumerable<PersonalDeAseo> IRepositorioPersonalDeAseo.GetAllPersonalDeAseo()
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