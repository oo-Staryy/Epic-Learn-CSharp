using Task_1.Entities;
using Task_1.Enums.Diseases;
using Task_1.Services.Implementations;
using Task_1.Services.Interfaces;

#region TEST_DATA
int iterator = 0;
List<Patient> patients = [
    new ("Tom", new Disease("Cough", "", TreatmentMethods.Syrup)),
    new ("Jane", new Disease("Acne", "", TreatmentMethods.None)),
    new ("Antony", new Disease("Cold", "", TreatmentMethods.Pills)),
    new ("Anatoly", new Disease("Laziness", "He is really lazy", TreatmentMethods.Therapy))
    ];
#endregion

IHealingService healingService = new HealingService();

healingService.Heal(patients[iterator++], TreatmentMethods.Syrup);
healingService.Heal(patients[iterator++], TreatmentMethods.None);
healingService.Heal(patients[iterator++], TreatmentMethods.None);
healingService.Heal(patients[iterator++], TreatmentMethods.Therapy);