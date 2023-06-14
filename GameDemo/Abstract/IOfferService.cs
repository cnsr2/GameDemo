using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IOfferService
    {
        void AddOffer(Offer offer,Game game);
        void RemoveOffer(Offer offer,Game game);
        void UpdateOffer(Offer offer, Game game);
    }
}
