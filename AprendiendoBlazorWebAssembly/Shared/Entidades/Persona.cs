using System;
using System.Collections.Generic;
using System.Text;

namespace AprendiendoBlazorWebAssembly.Shared.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Biografia { get; set; }
        public string Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
