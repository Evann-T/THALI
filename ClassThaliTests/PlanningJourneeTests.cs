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
    public class PlanningJourneeTests
    {

        [TestMethod()]
        public void CalculerRecetteJourTest()
        {
            PlanningJournee P = new PlanningJournee(DateTime.Parse("01:00"));

            MiniExcursion ME = new MiniExcursion(51914, "V", 50, 4.99);
            MiniExcursion ME2 = new MiniExcursion(51914, "V", 5, 10000);

            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("10:00"));
            MiniExcursionPlanifiee MEP2 = new MiniExcursionPlanifiee("ABCD", ME2, DateTime.Parse("10:00"));
            MEP.SetNombreInscrits(20);
            MEP2.SetNombreInscrits(10);
            Assert.AreEqual(0, P.CalculerRecetteJour());

            P.SetLesMEP(MEP);
            P.SetLesMEP(MEP2);

            Assert.AreEqual(50 * 4.99 + 50000, P.CalculerRecetteJour(), "Le recette du jour est de ca");

        }
    }
}