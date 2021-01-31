using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Game game, Gamer gamer, Campaign campaign);
        void Delete(Game game, Gamer gamer, Campaign campaign);
        void Update(Game game, Gamer gamer, Campaign campaign);
        
    }
}
