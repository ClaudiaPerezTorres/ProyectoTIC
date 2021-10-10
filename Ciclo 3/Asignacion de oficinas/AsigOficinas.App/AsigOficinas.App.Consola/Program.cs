using System;
using AsigOficinas.App.Dominio;
using AsigOficinas.App.Persistencia;
namespace AsigOficinas.App.Consola
{
    class Program
    {
        private static IRepositorioOficina _repoOficina = new RepositorioOficina(new appContext());
        private static IRepositorioSede _repoSede = new RepositorioSede(new appContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Probando CRUD de las entidades");
            //AddOficina();
            //BuscarOficina(1);
            AddSede();
        }

        private static void AddOficina()
        {
            var oficina = new Oficina
            {
                numero = "201",
                aforo = 12,
                horaLaboral = "Lunes a Viernes - 7:00 am a 5:00 pm",estadoOficina = false
            };
            _repoOficina.AddOficina(oficina);
        }

        private static void AddSede(){
            var sede = new Sede
            {
                nombre = "Oriente",
                ubicacion = "Barrio Alamos"
            };
            _repoSede.AddSede(sede);
        }

        private static void BuscarOficina(int idOficina)
        {
            var oficina = _repoOficina.GetOficina(idOficina);
            Console.WriteLine(oficina.numero+" "+oficina.aforo);
        }
    }
}
