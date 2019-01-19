using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_basic_MVC_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic controller = new BusinessLogic();
            controller.LoadDB();

            CarView carView = new CarView(controller);
            carView.ListData();

            OwnerNameView ownerNameView = new OwnerNameView(controller);
            ownerNameView.ListOwnerNames();

            ownerNameView.ListOwnerNamesFirstThree();
        }
    }
}
