using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class BusinessLogic
    {
        List<Car> cars { get; set; }
        Repository repo;


        // =============================================

        public void LoadDB()
        {
            repo = new Repository();
            cars = repo.ReadDB();    
        }



        // =============================================

        public List<Car> GetCarsList()
        {
            return cars;
        }

        public List<Owner> GetOwnersList()
        {
            return repo.GetOwnersNames();
        }

        public List<Mechanic> GetMechanicsList()
        {
            return repo.GetMechanicsNames();
        }



        // =============================================

        public List<Owner> GetOwnersListFirstThree()
        {
            List<Owner> ownersNames = repo.GetOwnersNames();
            List<Owner> firstThree = new List<Owner>();

            for (int i = 0; i < 3; i++)
            {
                firstThree.Add(ownersNames[i]);
            }

            return firstThree;
        }



        // =============================================

        public void ChangeOwnerName(string newName)
        {
            OwnerController oc = new OwnerController();
            oc.SetOwnerName(newName, repo);
        }


    }
}
