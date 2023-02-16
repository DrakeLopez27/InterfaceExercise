using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        { 
        }
        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "F-150";
        public string Make { get; set; } = "Ford";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built FORD Tough";
        public bool HasChangedGears { get; set; }
        
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4x4 {GetType().Name} is now driving forward...");
                HasFourWheelDrive = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is now driving forward...");
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
