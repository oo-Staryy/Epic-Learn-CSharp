using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Enums.Diseases;

namespace Task_1.Entities
{
    public class Disease
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TreatmentMethods TreatmentMethod { get; set; }
        public Disease(string name, string description, TreatmentMethods treatmentMethod)
        {
            Name = name;
            Description = description;
            TreatmentMethod = treatmentMethod;
        }
    }
}
