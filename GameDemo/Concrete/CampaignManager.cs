using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CampaignManager: ICampaignService
    {
        public void Add(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerName +" adlı oyuncu "+ game.GameName +" oyuna  "+campaign.CampaignName+ " isimli kampanyayı uyguladı.");
        }

        public void Delete(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerName + " adlı oyuncu " + game.GameName + " oyuna ait "+ campaign.CampaignName + " isimli kampanyayı kaldırdı.");
        }

        public void Update(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerName + " adlı oyuncu " + game.GameName + " oyuna ait "+ campaign.CampaignName + " isimli kampanyayı güncelledi.");
        }
    }
}
