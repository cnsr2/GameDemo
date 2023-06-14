using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Manager
{
    public class GamerManager : IGamerService
    {
        IValidateService _validateService;
        public GamerManager(IValidateService validateService)
        {
          _validateService = validateService;
        }
        public void Add(Gamer gamer)
        {
            
            if (_validateService.GamerValidate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "Adlı Kullanıcının Kaydı Yapılmıştır");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.FirstName + " " + "Adlı Kullanıcının Kaydı Silinmiştir");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.FirstName + " " + "Adlı Kullanıcının Kaydı Güncellenmiştir.");
        }

        public void Sale(Gamer gamer, Game game, Offer offer)
        {
            Console.WriteLine(game.GameName +" Adlı Oyun " + gamer.FirstName + " " + gamer.LastName + " " + "Adlı Kullanıcıya Kampanya Dahilinde"+" %"+offer.OfferDiscount +" İndirimle Satılmıştır.");
        }
    }
}
