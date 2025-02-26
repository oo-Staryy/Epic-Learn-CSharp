using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;
using Task_1.Enums.Diseases;
using Task_1.Services.Interfaces;

namespace Task_1.Services.Implementations
{
    public abstract class BaseHealingService : IHealingHandler, IHealingService
    {
        public virtual bool CanHeal(Disease disease, TreatmentMethods method)
        {
            switch (method)
            {
                case TreatmentMethods.Therapy:
                    throw new NotImplementedException();

                case TreatmentMethods.Pills:
                    throw new NotImplementedException();

                case TreatmentMethods.Syrup:
                    throw new NotImplementedException();
            }

            throw new NotImplementedException();
        }

        public void Heal(Patient patient, TreatmentMethods method)
        {
            Console.WriteLine($"Start healing");

            if (!CanHeal(patient.TargetDisease, method))
            {
                Console.WriteLine("Healing failed");
                return;
            }

            Console.WriteLine($"Healing {patient.TargetDisease.Name} successful!!!");
            Console.WriteLine($"Healed by method: {method}\n");
        }
    }
}
