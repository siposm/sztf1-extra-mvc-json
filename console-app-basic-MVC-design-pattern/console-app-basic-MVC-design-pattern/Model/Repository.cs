using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace console_app_basic_MVC_design_pattern
{
    class Repository
    {

        private string ownerDB = "ownerDB.txt";
        private string mechanicDB = "mechanicDB.txt";
        private string carDB = "carDB.txt";

        public List<Car> ReadDB()
        {
            List<Car> cars = new List<Car>();

            StreamReader sr = new StreamReader(carDB);

            while (!sr.EndOfStream)
            {
                // VID | deployment date | owner_id @ mechanic(s)_id(s)
                string line = sr.ReadLine();
                string[] carData = line.Split('@')[0].Split('|');
                string[] mechanicsData = line.Split('@')[1].Split(',');


                // find owner
                Owner owner = FindOwner(carData[2]);

                // find mechanics
                List<Mechanic> mechanics = FindMechanics(mechanicsData);

                cars.Add(new Car()
                {
                    VehicleID = carData[0],
                    FirstDeployment = DateTime.Parse(carData[1]),
                    Owner = owner,
                    Mechanics = mechanics
                });
            }

            return cars;
        }
        
        public bool WriteDB()
        {
            // writing the database accordingly to the modifications...
            return true; // or false, depending on the outcome of the method
        }


        public List<Owner> GetOwnersNames()
        {
            StreamReader sr = new StreamReader(ownerDB);
            List<Owner> owners = new List<Owner>();

            while (!sr.EndOfStream)
            {
                // 4|Nagy Norbert@2000.10.09.|GA234|GE
                string data = sr.ReadLine().Split('@')[0];

                owners.Add(new Owner()
                {
                    Name = data.Split('|')[1],
                    Id = data.Split('|')[0]
                });
            }

            return owners;
        }

        public List<Mechanic> GetMechanicsNames()
        {
            StreamReader sr = new StreamReader(ownerDB);
            List<Mechanic> mechanics = new List<Mechanic>();

            while (!sr.EndOfStream)
            {
                // 203 | Fáradt Ferenc
                string[] data = sr.ReadLine().Split('|');

                mechanics.Add(new Mechanic()
                {
                    Name = data[1]
                });
            }

            return mechanics;
        }

        private Owner FindOwner(string id)
        {
            StreamReader sr = new StreamReader(ownerDB);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                if (line.Contains(id))
                {
                    // 6|Szabó Szonja@2000.10.09.|PN789|HU
                    string[] data = line.Split('@')[0].Split('|');
                    string[] license = line.Split('@')[1].Split('|');

                    return new Owner()
                    {
                        Name = data[1],
                        Id = id,
                        DriversLicense = new DriversLicense()
                        {
                            Id = license[1],
                            Release = DateTime.Parse(license[0]),
                            Nationality = (Nationality)Enum.Parse(typeof(Nationality), license[2])
                        }
                    };
                }

            }

            return null;
        }

        private List<Mechanic> FindMechanics(string[] id)
        {
            StreamReader sr = new StreamReader(mechanicDB);
            List<Mechanic> mechanics = new List<Mechanic>();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string _id = line.Split('|')[0];

                for (int i = 0; i < id.Length; i++)
                {
                    if(id[i] == _id)
                    {
                        mechanics.Add(new Mechanic()
                        {
                            Id = line.Split('|')[0],
                            Name = line.Split('|')[1]
                        });
                    }
                }
            }

            return mechanics;
        }

        public void SetOwnerName(string newName)
        {
            // open file
            // find relevant line
            // overwrite it
            // save it
        }
    }
}
