using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineLocator.Model;
 

namespace MedicineLocator.Controller
{
    public class MedicineController
    {
        Medicines medicines = new Medicines();
        public void AddMedicine(Medicine medicine )
        {
            medicines.AddMedicine(medicine);
        }


        public void UpdateMedicine(Medicine medicine)
        {
            medicines.UpdateMedicine(medicine);
        }
        public void RemoveMedicine(string medicineId)
        {
            medicines.RemoveMedicine(medicineId);
        }
        public Medicine SearchMedicine(string medicineId)
        {
            Medicine p= medicines.SearchMedicine(medicineId);
            return p;

        }
        public List<Medicine> GetMedicine(string pharmacyId)
        {
            List<Medicine> medicineList = medicines.GetMedicines(pharmacyId);
            return medicineList;
        }
        public List<Medicine> GetMedicineByNameAndLocation(string name, string location)

        {
            List<Medicine> mlist = medicines.GetMedicineByNameAndLocation(name, location);
            return mlist;
        }

    }
}
