using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu eklendi ");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu silindi");
        }
        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Oyunu güncellendi");
        }
    }
}
