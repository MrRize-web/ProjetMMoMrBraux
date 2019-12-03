using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
   interface IAttaquantArme : IAttaquant
    {      
       int AttaqueArme(Arme arme);

    }
}
