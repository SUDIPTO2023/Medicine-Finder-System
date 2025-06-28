using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicineLocator.Model;

namespace MedicineLocator.Controller
{
    public class ManagerController
    {
        Managers managers= new Managers();
        public void AddManager(Manager manager)
        {
            managers.AddManager(manager);
        }
        public  void UpdateManager(Manager manager)
        {
            managers.UpdateManager(manager);
        }
        public void RemoveManager(string managerId)
        {
            managers.RemoveManager(managerId);
        }
        public List<Manager> GetAllManager()
        {
           List<Manager>lm= managers.GetAllManager();
           return lm;
        }
        public List<Manager> GetManagers(string adminId)
        {
            List<Manager> m = managers.GetManager(adminId);
            return m;
        }
        public Manager SearchManager(string  managerId)
        {
            Manager m=managers.SearchManager(managerId);
            return m;
        }
        
    }
    
}
