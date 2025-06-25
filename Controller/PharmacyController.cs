using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineLocator.Model;

namespace MedicineLocator.Controller
{
    public class PharmacyController
    {
        Pharmacys pharmacys = new Pharmacys();
        public void AddPharmacy(Pharmacy pharmacy)
        {
            pharmacys.AddPharmacy(pharmacy);
        }
        public void UpdatePharmacy(Pharmacy pharmacy)
        {
            pharmacys.UpdatePharmacy(pharmacy);
        }
        public void RemovePharmacy(string pharmacyId)
        {
            pharmacys.RemovePharmacy(pharmacyId);
        }
        public List<Pharmacy> GetAllPharmacy()
        {
            List<Pharmacy> p = pharmacys.GetAllPharmacy();
            return p;
        }
        public List<Pharmacy>GetPharmacy(string adminId)
        {
            List<Pharmacy> lp = pharmacys.GetPharmacy(adminId);
            return lp;
        }
        public string GetPharmacyIdByManagerId(string managerId)
        {
            string id=pharmacys.GetPharmacyIdByManagerId(managerId);
            return id;
        }
        public Pharmacy SearchPharmacy(string pharmacyId)
        {
            Pharmacy p =pharmacys.SearchPharmacy(pharmacyId);
            return p;
        }

    }
}
