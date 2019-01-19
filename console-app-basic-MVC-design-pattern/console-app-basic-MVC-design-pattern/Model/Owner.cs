using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class Owner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DriversLicense DriversLicense { get; set; }

        public Owner()
        {

        }
    }
}
