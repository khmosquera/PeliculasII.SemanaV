using System.Collections.Generic;
// Muchos a muchos: Una categoria puede tener muchas películas, y una película puede pertenecer a más de una categoria
// Clase debil, tiene los Id de las clase que relaciona, Category y Movie


using System.ComponentModel.DataAnnotations;


namespace PeliculaIISemanaIV.Shared.Entity
{
    public class Category
    {
        public int Id {get;set;}
        /*Validamos que el campo nombre es requerido*/
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name {get;set;}
        public List<CategoryMovie> CategoriesMovie {get;set;}
    }
}