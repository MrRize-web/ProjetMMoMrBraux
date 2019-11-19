using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMMoMrBraux
{
    class mesExceptions : Exception
    {
        public mesExceptions() { }
        public mesExceptions(string message) : base(message) 
        { 

        }
        public mesExceptions(string message, Exception inner) : base(message, inner) 
        { 
        
        }
        
    }
}
