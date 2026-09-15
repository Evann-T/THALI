using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void GetCodeTest()
        {
            MiniExcursion ME = new MiniExcursion(51914, "V", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("10:00"));
            Assert.AreEqual("ABCD", MEP.GetCode(), "Le code de la MEP est ABCD");
        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            MiniExcursion ME = new MiniExcursion(51914, "V", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("10:00"));
            Assert.AreEqual(0, MEP.GetNombreInscrits(), "0 inscrits");
            MEP.SetNombreInscrits(12);
            Assert.AreEqual(12, MEP.GetNombreInscrits(), "12 inscrits");
            MEP.SetNombreInscrits(12);
            Assert.AreEqual(24, MEP.GetNombreInscrits(), "24 inscrits");
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion ME = new MiniExcursion(51914, "V", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("10:00"));
            Assert.IsFalse(MEP.EstComplete(), "Pas complet");
            MEP.SetNombreInscrits(32);
            Assert.IsTrue(MEP.EstComplete(), "Complet");
        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            MiniExcursion ME = new MiniExcursion(51914, "V", 32);
            ME.AjouteEtape("Viste", 60);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("10:00"));
            
            Assert.AreEqual(DateTime.Parse("11:00"), MEP.HeureRetourPrevue(),"arrive à 11:00");
        }
    }
}