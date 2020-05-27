using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace AprendiendoBlazorWebAssembly.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Resume { get; set; }
        public bool EnCartelera { get; set; }
        public string Trailer { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Poster { get; set; }
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Titulo))
                {
                    return null;
                }
                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}
