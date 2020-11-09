using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{

    //Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
    public class Car : Vehicle
    {

        public Car()
        {

        }

        //Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
        public bool HasTrunk { get; set; } = true;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive");
        }
    }
    
}
