using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PeliculaIISemanaIV.Client.Services
{
    public interface IServiceLocation
    {
        List<Location> GetLocations();
    }
}