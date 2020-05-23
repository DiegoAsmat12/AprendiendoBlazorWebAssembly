using AprendiendoBlazorWebAssembly.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
                    {
                        new Pelicula() { Titulo = "Omaewa", Lanzamiento = new DateTime(2020, 05, 11), Poster="" },
                        new Pelicula() { Titulo = "Mo", Lanzamiento = new DateTime(2020, 05, 11), Poster=""  },
                        new Pelicula() { Titulo = "Shindeiru", Lanzamiento = new DateTime(2020, 05, 11), Poster=""  },
                    };
        }
    }
}
