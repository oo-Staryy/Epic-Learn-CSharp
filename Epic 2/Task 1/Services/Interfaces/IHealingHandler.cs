using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Entities;
using Task_1.Enums.Diseases;

namespace Task_1.Services.Interfaces
{
    public interface IHealingHandler
    {
        bool CanHeal(Disease disease, TreatmentMethods method);
    }
}
