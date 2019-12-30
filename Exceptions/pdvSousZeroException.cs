using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class pdvSousZeroException : Exception
    {
        public pdvSousZeroException() { }
        public pdvSousZeroException(string message) : base(message) 
        { 

        }
        public pdvSousZeroException(string message, Exception inner) : base(message, inner) 
        { 
        
        }
        
    }
}
