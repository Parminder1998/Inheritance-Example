using System;

namespace Inheritance_Example
{
    class Program
    { 
        //Base class

        public class vehicle
        {

            public string name { get; set; }

            public vehicle()
            {
                Console.WriteLine("I am in the Constructor Vehicle"); 
            }

            public void set_Vname(string v_name)
            {
                name = v_name;
            }
        }

        //Derived class
        public class Truck : vehicle
        {
            public Truck()
            {
                Console.WriteLine("I am in the Derived Truck");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Truck truck_obj = new Truck();
            truck_obj.name = "Mercedes";
            truck_obj.set_Vname("toyota");
            
        }
    }
}
