using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    interface  IAttaquantMagie
    {
        void attaqueSpecialeMagie(Personnage p);
        string getSort();
        int gethpv();

    }
}
