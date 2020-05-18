function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("AprendiendoBlazorWebAssembly.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("conteo desde javascript " + resultado);
        });
}