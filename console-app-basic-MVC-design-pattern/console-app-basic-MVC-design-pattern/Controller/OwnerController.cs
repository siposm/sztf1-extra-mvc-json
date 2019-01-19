using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class OwnerController
    {
        // 6|Szabó Szonja@2000.10.09.|PN789|HU

        public string Id { get; set; }
        public string Name { get; set; }
        public DriversLicense DriversLicense { get; set; }

        public OwnerController()
        {
        }

        public void SetOwnerName(string newName, Repository repo)
        {
            Name = newName;
            repo.SetOwnerName(newName);  // change it in DB also
        }
    }
}
