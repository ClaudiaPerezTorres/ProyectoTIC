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

        Diagnostico IRepositorioSecretarioDeDespacho.asignarDiagnostico(int idSecretarioDeDespacho, int idDiagnostico)
        {
            var secretarioDeDespachoEncontrado = _appContext.SecretarioDeDespacho.FirstOrDefault(g => g.id == idSecretarioDeDespacho);
            if (secretarioDeDespachoEncontrado != null)
            {
                var diagnosticoEncontrado = _appContext.Diagnostico.FirstOrDefault(d => d.id == idDiagnostico);
                if (diagnosticoEncontrado != null)
                {
                    secretarioDeDespachoEncontrado.diagnostico = diagnosticoEncontrado;
                    _appContext.SaveChanges();
                }
                return diagnosticoEncontrado;
            }
            return null;
        }

        SecretarioDeDespacho IRepositorioSecretarioDeDespacho.AddSecretarioDeDespacho(SecretarioDeDespacho secretarioDeDespacho)
        {
            var secretarioDeDespachoAdicionada= _appContext.SecretarioDeDespacho.Add(secretarioDeDespacho);
            _appContext.SaveChanges();
            return secretarioDeDespachoAdicionada.Entity;
        }

        bool IRepositorioSecretarioDeDespacho.DeleteSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            var secretarioDeDespachoEncontrada= _appContext.SecretarioDeDespacho.FirstOrDefault(s=>s.id == idSecretarioDeDespacho);
            if(secretarioDeDespachoEncontrada==null)
                return false;
            _appContext.SecretarioDeDespacho.Remove(secretarioDeDespachoEncontrada);
            _appContext.SaveChanges();
            return true;
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