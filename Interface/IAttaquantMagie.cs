using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    interface  IAttaquantMagie : IAttaquant
    {
        void AttaqueMagie(Magie magie);

    }
}
