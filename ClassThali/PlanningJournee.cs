using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassThali
{
    public class PlanningJournee
    {
        // attributs privés
        private DateTime date;
        private List<MiniExcursionPlanifiee> lesMiniExcursionsPlanifiees;

        /// <summary>
        /// Constructeur de la classe PlanningJournee
        /// </summary>
        /// <param name="uneDate">date du planning</param>
        public PlanningJournee(DateTime uneDate)
        {
            this.date = uneDate;
            this.lesMiniExcursionsPlanifiees = new List<MiniExcursionPlanifiee>();
        }

        public void SetLesMEP(MiniExcursionPlanifiee uneMiniExcursionPlanifiees)
        {
            this.lesMiniExcursionsPlanifiees.Add(uneMiniExcursionPlanifiees);
        }

        public double CalculerRecetteJour()
        {
            double recetteJour = 0;
            foreach (MiniExcursionPlanifiee mep in this.lesMiniExcursionsPlanifiees)
            {
                recetteJour += mep.GetNombreInscrits() * mep.GetLaMiniExcursion().GetMontantParticipation();
            }
        return recetteJour;
        }
    }
}
