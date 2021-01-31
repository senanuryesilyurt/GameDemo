using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {GamerId=1, GamerName="Sena", GamerLastname="yesilyurt", TC="00000000000", YearOfBirth=1999 };

            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);

            Console.WriteLine("***************************************************************");

            Game game = new Game() { GameId=1, GameName="xyz", GamePrice=500};

            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Update(game);
            gameManager.Delete(game);

            Console.WriteLine("***************************************************************");

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game,gamer);

            Console.WriteLine("***************************************************************");

            Campaign campaign = new Campaign() { CampaignId = 1, CampaignName = "sana özel" ,CampaignDiscountAmount = 15 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(game, gamer, campaign);
            campaignManager.Delete(game, gamer, campaign);
            campaignManager.Update(game, gamer, campaign);
        }
    }
}
