#pragma checksum "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e4fad46df375c5e42a0cf772d492abc9ad9adc2"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
#nullable restore
#line 3 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
  if (Movies == null)
     {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label><small class=\"text-muted\">No se encontraron registros</small></label>");
#nullable restore
#line 6 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
} else{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
     foreach ( var item_movie in Movies)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group align-items-start mb-3");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col md-3");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 13 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
                               item_movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "alt");
            __builder.AddAttribute(12, "height", "400px");
            __builder.AddAttribute(13, "width", "300px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col md-9");
            __builder.OpenElement(17, "h6");
            __builder.AddAttribute(18, "class", "text-left");
            __builder.OpenElement(19, "small");
            __builder.AddAttribute(20, "class", "text-muted");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
                                                                         item_movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "blockquote");
            __builder.AddAttribute(24, "class", "blockquote text-left");
            __builder.OpenElement(25, "small");
            __builder.AddContent(26, 
#nullable restore
#line 17 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
                                                                         item_movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
         
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
      
    public List<Movie> Movies{get{return GetMovies();}}
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\Home.razor"
                                                      
    private List<Movie> GetMovies(){
        return new List<Movie>(){
            new Movie(){Id=1, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie1.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=2, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie2.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=3, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie3.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=4, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie4.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=5, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie5.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=6, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie6.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=7, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie7.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=8, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie8.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=9, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie9.jpg", Premier=new DateTime(2021,10,01)},
            new Movie(){Id=10, Name=" PelículaI ", Sinopsis="Trama de la movie ...", Poster="/Images/PeliculasII/movie10.jpg", Premier=new DateTime(2021,10,01)},
            }; 
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
