using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public class ValidationManager:IValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.GamerId==1 && gamer.GamerName=="Sena" && gamer.GamerLastname=="yesilyurt" && 
                gamer.TC=="00000000000" && gamer.YearOfBirth==1999) { return true; }
            else { return false; }
        }
    }
}
