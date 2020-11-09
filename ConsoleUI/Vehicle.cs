using System;


namespace ConsoleUI
{
    // Create an abstract class called Vehicle
    public abstract class Vehicle
    {
        //* The vehicle class shall have three string properties Year (int), Make, and Model
        // Set the defaults to something generic in the Vehicle class
        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        //* Vehicle shall have an abstract method called DriveAbstract with no implementation
        // NO SCOPE
        // ***stubbed-out***
        
        public abstract void DriveAbstract(); //stubbed-out method


        //Vehicle shall have a virtual method called DriveVirtual with a base implementation
        // WTIH SCOPE
         public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }


        // Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
        //VEHICLE WILL SERVE AS THE BASE CLASS



    }
}
