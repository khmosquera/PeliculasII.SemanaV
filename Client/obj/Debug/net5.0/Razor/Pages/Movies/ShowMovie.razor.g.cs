#pragma checksum "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\ShowMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4515159778b4f9d89310c9b309bb03cbc05b18e5"
// <auto-generated/>
#pragma warning disable 1591
namespace PeliculaIISemanaIV.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/{Id:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/{Id:int}/{Name}")]
    public partial class ShowMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6>Ver información de la película (De una película en específico)</h6>");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\ShowMovie.razor"
                                                               
    [Parameter] public int Id{get;set;}
    [Parameter] public string Name{get;set;}

    protected override void OnInitialized()
        {
            Console.WriteLine($"El id de la película es {Id}");
        }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
