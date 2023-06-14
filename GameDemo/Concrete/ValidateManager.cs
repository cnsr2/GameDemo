using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Manager
{
    public class ValidateManager : IValidateService
    {
        public bool GamerValidate(Gamer gamer)
        {
            if (gamer.FirstName == "Emre Can" && gamer.LastName == "Sarı" && gamer.Id == 1 && gamer.IdentityNumber == "12345" && gamer.BirthYear == 2001)
            {
                Console.WriteLine("Doğrulama Başarılı");
                return true;
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız.");
                return false;
            }

        }
    }
}
