using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGameProject
{
    class DiscountManager : IDiscountService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " oyununa indirim kodu uygulandi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " oyunundaki indirim kodu kaldirildi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " oyunundaki indirim kodu kontrol ediliyor..");
        }
    }
}
