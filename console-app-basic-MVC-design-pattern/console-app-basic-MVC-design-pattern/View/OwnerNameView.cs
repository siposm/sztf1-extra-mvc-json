using System;
using System.Collections.Generic;

namespace console_app_basic_MVC_design_pattern
{
    class OwnerNameView
    {
        BusinessLogic bl;

        public OwnerNameView(BusinessLogic bl)
        {
            this.bl = bl;
        }

        public void ListOwnerNames()
        {
            List<Owner> owners = bl.GetOwnersList();

            Console.WriteLine(); 
            Console.WriteLine("=====================");
            Console.WriteLine("LISTING OWNERS' NAMES");
            Console.WriteLine("=====================");
            Console.WriteLine();

            foreach (Owner owner in owners)
            {
                Console.WriteLine(

                    ">> OWNER NAME:\t\t{0}\n" +
                    "--------------------------------------------------------"
                    ,
                    owner.Name

                    );

            }
        }

        public void ListOwnerNamesFirstThree()
        {
            List<Owner> owners = bl.GetOwnersListFirstThree();

            Console.WriteLine();
            Console.WriteLine("=====================");
            Console.WriteLine("LISTING OWNERS' NAMES");
            Console.WriteLine("=====================");
            Console.WriteLine();

            foreach (Owner owner in owners)
            {
                Console.WriteLine(

                    ">> OWNER NAME:\t\t{0}\n" +
                    "--------------------------------------------------------"
                    ,
                    owner.Name

                    );

            }
        }
    }
}
