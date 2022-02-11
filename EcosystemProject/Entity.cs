using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
    public class Entity
    {
        protected static int DEFAULT_EXPIRATION_AGE = 100;

        public string name { get; set; }
        public Coord coord { get; set; }
        public int expirationAge { get; set; }

        protected int age = 0;


        public Entity() { }

        // constructor
        public Entity(string name, Coord coord)
        {
            this.name = name;
            this.coord = coord;
            expirationAge = DEFAULT_EXPIRATION_AGE;
        }

        // has the entity lived past its expiration age
        public bool expired()
        {
            return (age > expirationAge);
        }

        virtual public void grow()
        {
            age++;
        }

        ~Entity() { }

        public class EntityType
        {
            public EntityType()
            {

            }
        }
    }
}
