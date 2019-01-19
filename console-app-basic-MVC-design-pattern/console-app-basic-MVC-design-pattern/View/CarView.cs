using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class CarView
    {
        BusinessLogic bl;

        public CarView(BusinessLogic bl)
        {
            this.bl = bl;
        }

        public void ListData()
        {
            List<Car> cars = bl.GetCarsList();

            Console.WriteLine(); 
            Console.WriteLine("=====================");
            Console.WriteLine("LISTING FULL DATABASE");
            Console.WriteLine("=====================");
            Console.WriteLine();

            foreach (Car car in cars)
            {

                string mechanics = "";
                for (int i = 0; i < car.Mechanics.Count; i++)
                {
                    mechanics += car.Mechanics[i].Name + ", ";
                }
                mechanics = mechanics.Remove(mechanics.Length - 2, 2);

                Console.WriteLine(

                    ">> VID:\t\t{0}\n" +
                    ">> DEPL:\t{1}\n" +
                    ">> OWNER:\t{2} ({3})\n" + 
                    ">> MECHANIC(s): {4}\n" +
                    "--------------------------------------------------------" 
                    ,
                    car.VehicleID,
                    car.FirstDeployment,
                    car.Owner.Name,
                    car.Owner.DriversLicense,
                    mechanics
                    
                    );
            }
        }
    }
}
