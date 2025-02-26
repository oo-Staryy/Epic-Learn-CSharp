using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Entities
{
    public class Patient
    {
        public string Name { get; set; }
        public Disease TargetDisease { get; set; }
        public Patient(string name, Disease targetDisease)
        {
            Name = name;
            TargetDisease = targetDisease;
        }
    }
}
