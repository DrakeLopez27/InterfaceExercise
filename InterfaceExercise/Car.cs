using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {

        }

        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Mustang";
        public string Make { get; set; } = "Ford";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built FORD Tough";
        public bool HasChangedGears { get; set; }
        

        public void Drive()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($" {GetType().Name} now driving forward...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't drive until you change gears");
            }


        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now parked...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until you change gears");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
             Console.WriteLine($"{GetType().Name} is now in reverse...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until you change gears");
            }

        }
    
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        
    }
}
