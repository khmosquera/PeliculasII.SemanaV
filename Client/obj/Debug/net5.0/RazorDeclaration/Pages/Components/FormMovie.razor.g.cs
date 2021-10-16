// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PeliculaIISemanaIV.Client.Pages.Components
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
#nullable restore
#line 1 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Components\FormMovie.razor"
using PeliculaIISemanaIV.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Components\FormMovie.razor"
using PeliculaIISemanaIV.Client.Model;

#line default
#line hidden
#nullable disable
    public partial class FormMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Components\FormMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    [Parameter] public List<Category> CategoriasSeleccionadas { get; set; } = new List<Category>();
    [Parameter] public List<Category> CategoriasNoSeleccionadas { get; set; } = new List<Category>();

    private string posterTemporal;
    private List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();

    private List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();

    private void ImageSelected(string imageB64)
    {
        Movie.Poster = imageB64;
    }

    protected override void OnInitialized()
    {
        Seleccionados = CategoriasSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        NoSeleccionados = CategoriasNoSeleccionadas.Select(x => new SelectorMultipleModel(x.Id.ToString(), x.Name)).ToList();
        if (!string.IsNullOrWhiteSpace(Movie.Poster))
        {
            posterTemporal = Movie.Poster;
            Movie.Poster = null;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
