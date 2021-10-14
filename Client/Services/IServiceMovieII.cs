using System;
using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;
namespace PeliculaIISemanaIV.Client.Services
{
    public interface IServiceMovieII
    {
         List<Movie> GetMovies();
    }
}
