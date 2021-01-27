using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //microservice
    class GamerManager : IGamerService
    {
        Interface1 _ınterface1;

        public GamerManager(Interface1 ınterface1)
        {
            _ınterface1 = ınterface1;
        }

        public void Add(Gamer gamer)
        {
            if (_ınterface1.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu!!");

            }
            else
            {
                Console.WriteLine("Kayıt başarısız!!");

            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi!!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi!!");
        }
    }
}
