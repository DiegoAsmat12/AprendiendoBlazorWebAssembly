using AprendiendoBlazorWebAssembly.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJson = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJson, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);

        }

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
