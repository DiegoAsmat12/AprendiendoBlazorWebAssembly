using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Pages
{
    
    public class CounterBase:ComponentBase
    {
        protected int currentCount = 0;
        [Inject]
        protected ServicioSingleton Singleton { get; set; }
        [Inject]
        protected ServicioTransient Transient { get; set; }
        protected void IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
        }
    }
}
