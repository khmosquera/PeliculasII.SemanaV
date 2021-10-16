using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;
using System;

namespace PeliculaIISemanaIV.Client.Services
{
    public class ServiceLocation : IServiceLocation
    {
        public List <Location> GetLocations(){
            return new List<Location>{
                new Location(){Country = "Colombia", City = "Bogotá", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img1.jpg"},
                new Location(){Country = "Colombia", City = "Manizales", Year =new DateTime(2021,10,01), Photo="/Images/Locaciones/img2.jpg"},
                new Location(){Country = "Colombia", City = "Medellín", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img3.jpg"},
                new Location(){Country = "Colombia", City = "Bogotá", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img4.jpg"},
                new Location(){Country = "Colombia", City = "Bogotá", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img5.jpg"},
                new Location(){Country = "Colombia", City = "Neiva", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img6.jpg"},
                new Location(){Country = "Colombia", City = "Cartagena", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img7.jpg"},
                new Location(){Country = "Colombia", City = "Calí", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img8.jpg"},
                new Location(){Country = "Colombia", City = "Bogotá", Year = new DateTime(2021,10,01), Photo="/Images/Locaciones/img9.jpg"}
            };
        }
    }
}
