using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PeliculaIISemanaIV.Client.Services
{
    public interface IServiceActor
    {
         List<Actor> GetActors();
    }
}
