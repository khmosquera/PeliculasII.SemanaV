using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;
using System;

namespace PeliculaIISemanaIV.Client.Services
{
    public class ServiceLocation : IServiceLocation
    {
        public List <Location> GetLocations(){
            return new List<Location>{
                new Location(){Country = "Colombia", City = "Bogotá", Year = "1994", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Manizales", Year = "1987", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Medellín", Year = "1996", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Bogotá", Year = "1976", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Bogotá", Year = "1989", ProductionType = ProductionType.ProdNational, Industry =Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Neiva", Year = "1993", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Cartagena", Year = "1984", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Calí", Year = "1987", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,},
                new Location(){Country = "Colombia", City = "Bogotá", Year = "2000", ProductionType = ProductionType.ProdNational, Industry = Industry.Cinema,}
            };
        }
    }
}
