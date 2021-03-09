using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Hunter : Driver
    {
        public Hunter(RaceCar car) : base(car)
        {
            Name = "Hunter";
            SkillLevel = 100;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}