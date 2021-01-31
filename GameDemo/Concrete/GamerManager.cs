using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GamerManager:IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService gamervalidationService)
        {
            _validationService = gamervalidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_validationService.Validation(gamer) == true) { Console.WriteLine("Giris Basarili "); }
            else { Console.WriteLine("Giris Basarisiz"); }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " kisisinin hesabı silindi");
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerName + " kisisinin hesabı güncellendi");
        }
    }
}
