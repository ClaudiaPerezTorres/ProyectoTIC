using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;

namespace AsigOficinas.App.Persistencia
{
    public interface IRepositorioPersonalDeAseo
    {
        IEnumerable <PersonalDeAseo> GetAllPersonalDeAseo();

        // Añadir
        PersonalDeAseo AddPersonalDeAseo (PersonalDeAseo personalDeAseo);

        // Actualizar
        PersonalDeAseo UpdatePersonalDeAseo (PersonalDeAseo personalDeAseo);

        // Borrar
        void DeletePersonalDeAseo (int idPersonalDeAseo); 

        // ver
        PersonalDeAseo GetPersonalDeAseo (int idPersonalDeAseo);
    }
}