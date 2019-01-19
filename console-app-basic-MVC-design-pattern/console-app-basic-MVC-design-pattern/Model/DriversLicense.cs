using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    enum Nationality
    {
        HU , GE , EN
    }

    class DriversLicense
    {
        public DateTime Release { get; set; }
        public string Id { get; set; }
        public Nationality Nationality { get; set; }


        public DriversLicense()
        {

        }

        public override string ToString()
        {
            return this.Id + "-" + this.Nationality;
        }
    }
}
