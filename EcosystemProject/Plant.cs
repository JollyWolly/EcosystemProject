using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
    class Plant : Entity
    {
        protected bool canSeed;
        protected int coolDownTime;
        protected int seedingCoolDown;
        protected int seedChance = 30;

        public Plant(string name, Coord coord)
        {
            this.name = name;
            this.coord = coord;
            age = 0;
            coolDownTime = 0;
            expirationAge = DEFAULT_EXPIRATION_AGE;
        }

        public Plant(PlantType p, Coord coord)
        {
            this.name = p.name;
            this.coord = coord;
            age = 0;
            this.coolDownTime = p.coolDownTime;
            this.expirationAge = p.maxAge;
        }

        // increases age of plant by one
        // this will decrease the seeding cool down counter and allow it to attempt 
        // to seed again if the seeding cool down is done
        public override void grow()
        {
            age++;
            seedingCoolDown--;
            canSeed = (seedingCoolDown < 1);
        }

        // returns true if it can successfully seed, then it will be put on
        // seeding cool down
        // false otherwise
        public bool seed()
        {
            if (canSeed)
            {
                seedingCoolDown = coolDownTime;
                return true;
            }
            return false;
        }


        //
        public class PlantType : EntityType
        {
            public string name { get; set; }
            public int coolDownTime { get; set; }
            public int maxAge { get; set; }

            public PlantType(string name, int coolDownTime, int maxAge)
            {
                this.name = name;
                this.coolDownTime = coolDownTime;
                this.maxAge = maxAge;
            }
        }
    }
}
