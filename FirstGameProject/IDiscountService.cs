using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGameProject
{
    interface IDiscountService
    {
        void Add(Game game);

        void Update(Game game);

        void Delete(Game game);
    }
}
