using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using static AprendiendoBlazorWebAssembly.Client.Shared.MainLayout;

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
        //[CascadingParameter]
        //protected AppState appState { get; set; }
        //[CascadingParameter(Name ="Size")]
        //protected string Size { get; set; }

        [JSInvokable]
        public async Task IncrementCount() //debe ser publico
        {
            currentCount++;
            Singleton.Valor = currentCount;
            Transient.Valor = currentCount;
            currentCountStatic++;
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }
        protected async Task IncrementCountJavascript()
        {
            //si quisiera pasarele un objeto
            //var pelicula = new AprendiendoBlazorWebAssembly.Shared.Entidades.Pelicula();
            //await JS.InvokeVoidAsync("pruebaPuntoNetInstancia",DotNetObjectReference.Create(pelicula));
            await JS.InvokeVoidAsync("pruebaPuntoNetInstancia", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
