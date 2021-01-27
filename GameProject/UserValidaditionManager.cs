using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidaditionManager : Interface1
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirtYear == 1985 && gamer.FirstName =="engin" && gamer.Lastname == "Demiroğ" && gamer.IdentityNumber==12345 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
