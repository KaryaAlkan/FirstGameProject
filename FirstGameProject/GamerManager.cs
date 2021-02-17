using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGameProject
{
    class GamerManager : IGamerOptions
    {
 
        public void SignIn(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " olarak giris yapildi.");
        }

        public void SignUp(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " olarak kayit olundu.");
        }
    }
}
