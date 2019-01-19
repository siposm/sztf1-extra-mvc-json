using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class Car
    {
        public string VehicleID { get; set; }
        // public string Brand { get; set; } additional stuff
        public DateTime FirstDeployment { get; set; }
        public Owner Owner { get; set; }
        public List<Mechanic> Mechanics { get; set; }

        public Car()
        {

        }
        public Car(string vehicleID)
        {
            this.VehicleID = vehicleID;
            Mechanics = new List<Mechanic>();
        }
        public Car(string vehicleID, Owner owner)
        {
            this.VehicleID = vehicleID;
            this.Owner = owner;
            Mechanics = new List<Mechanic>();
        }
    }
}
