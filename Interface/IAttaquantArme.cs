﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
   interface IAttaquantArme
    {
        void attaqueSpecialeArme(Personnage p);
        string getArme();
        int gethpv();
    }
}
