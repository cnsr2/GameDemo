using GameDemo.Entities;
using GameDemo.Manager;

Gamer gamer = new Gamer{ FirstName = "Emre Can", LastName = "Sarı", Id = 1, BirthYear = 2001, IdentityNumber = "12345"};
GamerManager gamerManager = new GamerManager(new ValidateManager());
Game game = new Game { GameName = "CS:GO", Id = 1, GamePrice = 200 };
Offer offer = new Offer { Id = 1 ,OfferDiscount = 30,OfferName="Yaz"};
gamerManager.Add(gamer);
gamerManager.Sale(gamer, game,offer);

