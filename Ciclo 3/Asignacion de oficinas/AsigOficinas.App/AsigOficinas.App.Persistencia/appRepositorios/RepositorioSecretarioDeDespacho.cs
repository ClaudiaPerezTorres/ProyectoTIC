using System;
using AsigOficinas.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace AsigOficinas.App.Persistencia
{
    public class RepositorioSecretarioDeDespacho : IRepositorioSecretarioDeDespacho
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
        public RepositorioSecretarioDeDespacho (appContext appContext)
        {
            _appContext=appContext;
        }
        SecretarioDeDespacho IRepositorioSecretarioDeDespacho.AddSecretarioDeDespacho(SecretarioDeDespacho secretarioDeDespacho)
        {
            var secretarioDeDespachoAdicionada= _appContext.SecretarioDeDespacho.Add(secretarioDeDespacho);
            _appContext.SaveChanges();
            return secretarioDeDespachoAdicionada.Entity;
        }

        void IRepositorioSecretarioDeDespacho.DeleteSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            var secretarioDeDespachoEncontrada= _appContext.SecretarioDeDespacho.FirstOrDefault(s=>s.id == idSecretarioDeDespacho);
            if(secretarioDeDespachoEncontrada==null)
                return;
            _appContext.SecretarioDeDespacho.Remove(secretarioDeDespachoEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<SecretarioDeDespacho> IRepositorioSecretarioDeDespacho.GetAllSecretarioDeDespacho()
        {
            return _appContext.SecretarioDeDespacho;
        }

        SecretarioDeDespacho IRepositorioSecretarioDeDespacho.GetSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            return _appContext.SecretarioDeDespacho.FirstOrDefault(s=>s.id == idSecretarioDeDespacho);
        }

        SecretarioDeDespacho IRepositorioSecretarioDeDespacho.UpdateSecretarioDeDespacho(SecretarioDeDespacho secretarioDeDespacho)
        {
            var secretarioDeDespachoEncontrada = _appContext.SecretarioDeDespacho.FirstOrDefault(a=>a.id == secretarioDeDespacho.id);
            if (secretarioDeDespachoEncontrada!=null)
            {
                secretarioDeDespachoEncontrada.nombre = secretarioDeDespacho.nombre;
                secretarioDeDespachoEncontrada.apellido = secretarioDeDespacho.apellido;
                secretarioDeDespachoEncontrada.identificacion = secretarioDeDespacho.identificacion;
                secretarioDeDespachoEncontrada.edad = secretarioDeDespacho.edad;
                secretarioDeDespachoEncontrada.estadoCovid = secretarioDeDespacho.estadoCovid;
                secretarioDeDespachoEncontrada.despacho = secretarioDeDespacho.despacho;
                _appContext.SaveChanges();
            }
            return secretarioDeDespachoEncontrada;
        }
    }
}