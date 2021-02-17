using System;
using System.Collections.Generic;
using System.Text;

namespace FirstGameProject
{
    interface IGameOptions
    {
        void Buy(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
