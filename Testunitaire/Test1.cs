using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjetMMoMrBraux;
using System.Collections.Generic;

namespace ProjetMMoMrBraux.Testunitaire
{

    [TestClass]
    public class Testsac
    {
        static Sac sac = new Sac();
        [TestMethod]
        public void ajouterItem()
        {
            //ajouter un objet ajoute 
            Objets objet = new Objets("Grosse Epée", 35);
            sac.ajouterItem(objet);
            int nombreItemSac = sac.nombreItemDansSac();
            Assert.IsTrue(nombreItemSac == 1);
            Assert.IsFalse(nombreItemSac != 1);
            Assert.IsNull(nombreItemSac == 0);

        }
        [TestMethod]
        public void retirerItem()
        {
            //retirer un objet retire 
            Objets objet = new Objets("Grosse Epée", 35);
            sac.retirerItem(objet);
            int nombreItemSac = sac.nombreItemDansSac();
            Assert.IsTrue(nombreItemSac == 0);
        }
    }
}
