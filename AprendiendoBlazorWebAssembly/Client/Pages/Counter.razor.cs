using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendiendoBlazorWebAssembly.Client.Pages
{
    
    public class CounterBase:ComponentBase
    {
        protected int currentCount = 0;
        static int currentCountStatic = 0;
        [Inject]
        protected ServicioSingleton Singleton { get; set; }
        [Inject]
        protected ServicioTransient Transient { get; set; }
        [Inject]
        protected IJSRuntime JS { get; set; }
        protected async Task IncrementCount()
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
