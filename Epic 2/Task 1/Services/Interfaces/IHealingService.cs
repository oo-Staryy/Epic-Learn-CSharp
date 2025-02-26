using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;
using Task_1.Enums.Diseases;

namespace Task_1.Services.Interfaces
{
    public interface IHealingService
    {
        void Heal(Patient patient, TreatmentMethods method);
    }
}
