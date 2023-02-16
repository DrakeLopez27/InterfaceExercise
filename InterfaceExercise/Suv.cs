using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public Suv()
        {

        }

        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "Denali";
        public string Make { get; set; } = "GMC";
        public int SeatCount { get; set; } = 8;
        public bool HasChangedGears { get; set; }
        public string CompanyName { get; set; } = "GMC";
        public string Motto { get; set; } = "Everybody In";
        public bool HasSunroof { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;
        }

        public void Drive()
        {
            if (HasSunroof == true)
            {
                Console.WriteLine($"{GetType().Name} has a sunroof, and is now driving forward...");
                HasSunroof = false;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not have a sunroof, and is now driving forward...");
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
    }
}
