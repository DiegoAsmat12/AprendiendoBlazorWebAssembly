﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        public async Task MostrarMensageError(string mensaje)
        {
            await Task.FromResult(0);
        }
    }
}
