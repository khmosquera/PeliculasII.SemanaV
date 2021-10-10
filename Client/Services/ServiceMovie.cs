using System;
using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PeliculaIISemanaIV.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){
new Movie(){Id =1,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie1.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =2,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie2.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =3,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie3.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =4,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie4.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =5,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie5.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =6,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie6.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =7,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie7.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =8,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie8.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =9,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie9.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
new Movie(){Id =10,Name="Movie", Sipnosis="Trama de la película", Poster="/Images/PeliculasII/movie10.jpg", Premier= new
DateTime(2021, 10,10), Trailer="Actriz1"},
            };
            
        }    
        
    }
}