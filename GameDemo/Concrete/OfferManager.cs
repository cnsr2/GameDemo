﻿using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void AddOffer(Offer offer, Game game)
        {
            Console.WriteLine(offer.OfferName +"Kampanyası "+ game.GameName + " Adlı Oyuna Uygulandı"); 
        }

        public void RemoveOffer(Offer offer, Game game)
        {
            Console.WriteLine(offer.OfferName + "Kampanyası " + game.GameName + " Adlı Oyundan Kaldırıldı");
        }

        public void UpdateOffer(Offer offer, Game game)
        {
            Console.WriteLine(offer.OfferName + "Kampanyası " + game.GameName + " Adlı Oyun İçin Güncellendi");
        }
    }
}
