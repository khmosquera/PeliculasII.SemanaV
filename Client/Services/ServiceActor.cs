using PeliculaIISemanaIV.Shared.Entity;
using System.Collections.Generic;
using System;

namespace PeliculaIISemanaIV.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List <Actor> GetActors(){
            return new List<Actor>{
                new Actor(){Id =1, Name = "Actor Cobbie S", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img1.jpg", KnowCredits=7, Biography="Biografía...", Nominations = 7},
                new Actor(){Id =2, Name = "Actor Jnnifer A", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img2.jpg", KnowCredits=15, Biography="Biografía...", Nominations = 5},
                new Actor(){Id =3, Name = "Actor Jhon T", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img3.webp", KnowCredits=3, Biography="Biografía...", Nominations = 2},
                new Actor(){Id =4, Name = "Actor Lindsay", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img4.webp", KnowCredits=9, Biography="Biografía...", Nominations = 1},
                new Actor(){Id =5, Name = "Actor Phoebe", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/aimg5.webp", KnowCredits=1, Biography="Biografía...", Nominations = 6},
                new Actor(){Id =6, Name = "Actor Joe", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img6.webp", KnowCredits=8, Biography="Biografía...", Nominations = 4},
                new Actor(){Id =7, Name = "Actor Taylor", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img7.jpg", KnowCredits=8, Biography="Biografía...", Nominations = 2},
                new Actor(){Id =8, Name = "Actor Meggan", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img8.jpg", KnowCredits=5, Biography="Biografía...", Nominations = 3},
                new Actor(){Id =9, Name = "Actor Sara M", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img9.webp", KnowCredits=16, Biography="Biografía...", Nominations = 7},
                new Actor(){Id =10, Name = "Actor Stefany", BirthDate= new DateTime(1994, 05, 30), Photo ="/Images/Actors/img10.webp", KnowCredits=13, Biography="Biografía...", Nominations = 1}
            };
        }
    }
}