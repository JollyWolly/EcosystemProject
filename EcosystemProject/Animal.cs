using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
    public class Animal : Entity
    {
        // Reproduction Public
        public bool isHorny { get; set; }
        // Reproduction Protected
        protected int matureAge;
        protected int reproCoolDownTime;
        protected int reproCoolDown;

        // Food Public
        public bool isHungry { get; set; }
        public bool isFull { get; set; }
        // Food Protected
        protected string food;  // name of food animal eats
        protected int foodCap;  // how full an animal can be
        protected int hunger;   // how hungry an animal is, full at 
        protected int hungerBar; // how high hunger has to be inorder to be hungry

        // movement
        protected int movement;

        // Default constructor
        public Animal(string name, Coord coord)
        {
        }

        // Constructor
        public Animal(AnimalType a, Coord coord)
        {
            // Base class stuff
            this.name = a.name;
            this.coord = coord;
            // Food
            this.food = a.food;
            this.hunger = a.hunger;
            this.foodCap = a.foodCap;
            this.hungerBar = Convert.ToInt32(foodCap * 0.6);
            this.isFull = false;
            // reproduction
            this.matureAge = a.matureAge;
            this.expirationAge = a.maxAge;
            this.reproCoolDownTime = a.reproCoolDownTime;
            reproCoolDown = matureAge;
            isHorny = false;
            // world interation
            this.movement = a.movement;
        }

        //
        public override void grow()
        {
            // increase age
            age++;

            // food stuff
            hunger--;
            isHungry = (hunger < hungerBar);
            isFull = (hunger >= foodCap);

            // update reproduction ability
            reproCoolDown--;
            isHorny = (reproCoolDown < 1) && (!isHungry);

        }

        public bool isMature()
        {
            return age >= matureAge;
        }

        public string foodName()
        {
            return food;
        }

        //
        public int getMovement()
        {
            return movement;
        }

        // 0 default behavior
        // 1 search for food
        // 2 search for mate
        // 3 should be dead
        public int getBehavior()
        {
            // should it be alive
            if (hunger <= 0 || expired())
                return 3;
            if (isHorny)
                return 2;
            if (isHungry)
                return 1;
            return 0;
        }

       

        public void reproduce()
        {
            isHorny = false;
            hunger -= foodCap / 2;
            reproCoolDown = reproCoolDownTime;
        }

        //
        public void eat(int fill)
        {
            hunger += fill;
            isHungry = (hunger < hungerBar);
            isFull = (hunger >= foodCap);
        }

        public void move(int newX, int newY)
        {
           coord.x = newX;
           coord.y = newY;
           
        }

        // move but takes a coord instead
        public void move(Coord c)
        {
            move(c.x, c.y);
        }



        /**
         * Created for my sanity
         * AnimalType contains all of the variables an animal needs that I dont want to
         * type in over and over again
         */
        public class AnimalType : EntityType
        {
            // name
            public string name { get; }
            // food
            public string food { get; }
            public int hunger { get; }
            public int foodCap { get; }
            // reproduction
            public int matureAge { get; }
            public int maxAge { get; }
            public int reproCoolDownTime { get; }
            // world interaction
            public int movement { get; }

            
            public AnimalType(
                string name,
                string food, int hunger, int foodCap,
                int matureAge, int maxAge, int reproCoolDownTime,
                int movement
                )
            {
                // name
                this.name = name;
                // food
                this.food = food;
                this.hunger = hunger;
                this.foodCap = foodCap;
                this.matureAge = matureAge;
                this.maxAge = maxAge;
                this.reproCoolDownTime = reproCoolDownTime;
                // world interaction
                this.movement = movement;
            }
        } // AnimalType end
    }
}
