// Muchos a muchos: Una categoria puede tener muchas películas, y una película puede pertenecer a más de una categoria
// Clase debil, tiene los Id de las clase que relaciona, Category y Movie
namespace PeliculaIISemanaIV.Shared.Entity
{
    public class CategoryMovie
    {
        public int MovieId{get;set;}
        public int CategoryId{get;set;}
    }
}