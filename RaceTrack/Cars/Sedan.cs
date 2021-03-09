using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Sedan : RaceCar
    {

        public Sedan(){
            Name = "Sedan";

            TopSpeed = 80;
        }

        public override void StartEngine() {
            Console.WriteLine($"The {Name} is looking sharp as ever");
        }

        public override void Brake() {
            Console.WriteLine($"The {Name} immediately stopped disobeying physics");

            base.Brake();
        }

        // extra credit NOT WORKING---
        public override void StopEngine() {
            Console.WriteLine($"{Name}'s engine has stopped");
            base.Brake();
        }
        // ---
        

    }

}
