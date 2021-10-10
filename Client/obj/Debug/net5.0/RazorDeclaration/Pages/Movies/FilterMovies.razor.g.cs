// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PeliculaIISemanaIV.Client.Pages.Movies
{
    #line hidden
    using System;
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
#line 2 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\FilterMovies.razor"
using PeliculaIISemanaIV.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/filter")]
    public partial class FilterMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\FilterMovies.razor"
      
    private List<Movie> Movies;
    private List<Category> categories = new List<Category>();
    string movie_name ="";
    string categorySelected ="";
    private bool futurosEstrenos = false;

    private bool enCartelera = false;
    private bool mejorCalificada = false;

    protected override void OnInitialized(){
        Movies = movie.GetMovies();
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "c:\PeliculasII\PeliculaIISemanaIV\PeliculaIISemanaIV\Client\Pages\Movies\FilterMovies.razor"
        
    private void ShowMovies(){
        Movies = movie.GetMovies().Where(x=>x.Name.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Película: {movie_name}, categoria seleccionada {categorySelected}");
        Console.WriteLine($"PróximosEstrenos: {futurosEstrenos}, en cartelera {enCartelera} mejor calificada {mejorCalificada}");
}

private void ClearInputs (){
    Movies = movie.GetMovies();
    movie_name = "";
    categorySelected = "0";
    futurosEstrenos = false;

    enCartelera = false;
    mejorCalificada = false;

}
    private void MovieSearch(KeyboardEventArgs e){
        if (e.Key == "Enter")
        {
            ShowMovies();  
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
