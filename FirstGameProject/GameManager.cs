using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGameProject
{
    class GameManager : IGameOptions
    {
        public void Buy(Game game)
        {
            Console.WriteLine(game.Name + " kutuphaneye eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " kutuphaneden kaldirildi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " guncelleniyor..");
        }
    }
}
