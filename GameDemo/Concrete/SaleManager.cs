using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName +" adlı oyuncunun " +game.GameName+ " adlı oyunu satıldı.");
        }
    }
}
