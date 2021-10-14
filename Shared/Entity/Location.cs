using System;
using System.ComponentModel.DataAnnotations;

namespace PeliculaIISemanaIV.Shared.Entity
{
    public class Location
    {
        
        [Required(ErrorMessage ="El campo{0} es requerido")]
        public string Country {get;set;}
        [Required(ErrorMessage ="El campo{0} es requerido")]
        public string City {get;set;}
        [Required(ErrorMessage ="El campo{0} es requerido")]
        public string Year {get;set;}
        [Required(ErrorMessage ="El campo{0} es requerido")]
        public ProductionType ProductionType {get;set;}
        [Required(ErrorMessage ="El campo{0} es requerido")]
        public Industry Industry {get;set;}
        public string Photo {get;set;}
        
    }
    public enum ProductionType {
        ProdNational = 1,
        ProdForeigner = 2
    }
    public enum Industry
    {
        Cinema = 1,
        TV = 2,
        Streaming = 3
    } 
    
}