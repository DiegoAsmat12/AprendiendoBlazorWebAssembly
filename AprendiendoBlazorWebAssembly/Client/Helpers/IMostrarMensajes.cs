using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensageError(string mensaje);
    }
}
