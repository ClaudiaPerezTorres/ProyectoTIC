using System;
using System.Collections.Generic;
using AsigOficinas.App.Dominio;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioRegistro : IRepositorioRegistro
    {
        /// <summary>
        /// Referencia al contexto de Registro
        /// </summary>

        private readonly appContext _appContext;
        /// <summary>
        /// Metodo Constructor
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        RepositorioRegistro (appContext appContext)
        {
            _appContext=appContext;
        }
        Registro IRepositorioRegistro.AddRegistro(Registro registro)
        {
            var registroAdicionado= _appContext.Registro.Add(registro);
            _appContext.SaveChanges();
            return registroAdicionado.Entity;
        }

        bool IRepositorioRegistro.DeleteRegistro(int idRegistro)
        {
            var registroEncontrado= _appContext.Registro.FirstOrDefault(r=>r.id == idRegistro);
            if(registroEncontrado==null)
                return false;
            _appContext.Registro.Remove(registroEncontrado);
            _appContext.SaveChanges();
            return true;
        }

        IEnumerable<Registro> IRepositorioRegistro.GetAllRegistro()
        {
            return _appContext.Registro;
        }

        Registro IRepositorioRegistro.GetRegistro(int idRegistro)
        {
            return _appContext.Registro.FirstOrDefault(r=>r.id == idRegistro);
        }

        // Falta definir los atributos de la clase registro
        Registro IRepositorioRegistro.UpdateRegistro(Registro registro)
        {
            throw new NotImplementedException();
        }
    }
}