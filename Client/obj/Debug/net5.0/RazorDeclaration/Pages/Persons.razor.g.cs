// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PeliculaIISemanaIV.Client.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\_Imports.razor"
using PeliculaIISemanaIV.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Persons.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Persons.razor"
using PeliculaIISemanaIV.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/person")]
    public partial class Persons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Persons.razor"
      
    public List<Person> Persons;
    protected override void OnInitialized()
    {
        Persons = person.GetPersons();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicePerson person { get; set; }
    }
}
#pragma warning restore 1591
