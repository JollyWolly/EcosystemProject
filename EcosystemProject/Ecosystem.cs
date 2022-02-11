using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemProject
{
    public class Ecosystem
    {

        // grid info
        int width;
        int height;
        char[,] txtGrid;
        bool[,] hasEntity;
        bool[,] hasPlant;
        bool[,] hasAnimal;
        private List<Plant> plants;
        private List<Animal> animals;
        private int[,] plntGrid; // -1 means there is no plant
        private int[,] anmlGrid;  // -1 means there is no animal


        // age
        public int day;

        // random
        Random random = new Random();

        /* GRASS INFO */
        // Grass PlantType Info
        Plant.PlantType grass;
        string GRASS_NAME = "grass";
        int SEED_COOLDOWN = 5;
        int GRASS_MAXAGE  = 15;
        // Misc.
        int SEED_CHANCE = 30; // percent chance that grass will reproduce
        public int grassCount;
        /* GRASS INFO END */

        Dictionary<string, Animal.AnimalType> anmlDict;

        /* SHEEP INFO */
        // Sheep AnimalType Info
        Animal.AnimalType sheepType;
        string SHEEP_NAME = "sheep";
        int SHEEP_INITIALHUNGER = 15;
        int SHEEP_FOODCAP = 30;
        int SHEEP_ADULTAGE = 10;
        int SHEEP_MAXAGE = 40;
        int SHEEP_COOLDOWN = 8;
        int SHEEP_MOVEMENT = 1;
        // Misc.
        public int sheepCount;
        /* SHEEP INFO END */


        /* WOLF INFO */
        //
        Animal.AnimalType wolfType;
        string WOLF_NAME = "wolf";
        int WOLF_INITIALHUNGER = 20;
        int WOLF_FOODCAP = 30;
            // Reproduction
        int WOLF_COOLDOWN = 10;
        int WOLF_ADULTAGE = 20;
        int WOLF_MAXAGE = 40;
        int WOLF_MOVEMENT = 1;
        // Misc.
        public int wolfCount;


        int PLANT_HARDINESS = 6;
        int ANIMAL_HARDINESS = 40;
        bool ANTI_EXTINCTION;

        // constructor
        public Ecosystem(int height, int width, bool antiExtinction, int grassRate, int sheepRate, int wolfRate)
        {
            this.height = height;
            this.width = width;
            ANTI_EXTINCTION = antiExtinction;

            grass = new Plant.PlantType(GRASS_NAME, SEED_COOLDOWN, GRASS_MAXAGE);
            sheepType = new Animal.AnimalType(SHEEP_NAME, 
                                            GRASS_NAME, SHEEP_INITIALHUNGER, SHEEP_FOODCAP, 
                                            SHEEP_ADULTAGE, SHEEP_MAXAGE, SHEEP_COOLDOWN, 
                                            SHEEP_MOVEMENT);
            wolfType = new Animal.AnimalType(WOLF_NAME,
                                            SHEEP_NAME, WOLF_INITIALHUNGER, WOLF_FOODCAP,
                                            WOLF_ADULTAGE, WOLF_MAXAGE, WOLF_COOLDOWN,
                                            WOLF_MOVEMENT);

            anmlDict = new Dictionary<string, Animal.AnimalType>();
            anmlDict.Add(SHEEP_NAME, sheepType);
            anmlDict.Add(WOLF_NAME, wolfType);

            plants = new List<Plant>();
            animals = new List<Animal>();

            // initialize grid
            txtGrid = new char[width, height];
            plntGrid = new int[width, height];
            anmlGrid = new int[width, height];
            hasEntity = new bool[width, height];
            hasPlant = new bool[width, height];
            hasAnimal = new bool[width, height];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    plntGrid[x, y] = -1;
                    anmlGrid[x, y] = -1;
                    if (random.Next(0, 201) < grassRate)
                        createGrass(x, y);
                    if (random.Next(0, 201) < sheepRate)
                        createAnimal(sheepType, x, y);
                    if (random.Next(0, 201) < wolfRate)
                        createAnimal(wolfType, x, y);
                }
            }
            updateTxtGrid();
        }

        // passes a day of time in the simulation
        // causes entities to carry out their behaviors
        public void update()
        {
            

            // update plants
            Stack<Plant> plantStack = new Stack<Plant>();
            foreach (Plant p in plants)
            {
                plantStack.Push(p);
            }
            foreach (Plant p in plantStack)
            {
                p.grow();
                if (!p.expired())
                {
                    if (random.Next(0, 100) < SEED_CHANCE)
                        seedNewGrass(p);
                }
                else
                {
                    killPlant(p);
                }
            }


            // update animals
            Stack<Animal> anmlStack = new Stack<Animal>();
            foreach (Animal a in animals)
            {
                anmlStack.Push(a);
            }
            foreach (Animal a in anmlStack)
            {
                a.grow();
                int b = a.getBehavior();
                switch (b)
                {
                    case 0: defaultBehavior(a);
                        break;
                    case 1: hungryBehavior(a);
                        break;
                    case 2: matingBehavior(a);
                        break;
                    case 3: killAnimal(a);
                        break;
                    default:
                        break;
                }
            }

            // Extinction prevention, if turned on
            if (ANTI_EXTINCTION)
            {
                if (grassCount == 0)
                {
                    if (random.Next(0, 100) < 30)
                    {
                        createGrass(random.Next(0, width), random.Next(0, height));
                    }
                }
                if (sheepCount == 0)
                {
                    if (random.Next(0, 100) < 30)
                    {
                        int x = random.Next(2, width - 2);
                        int y = random.Next(2, height - 2);

                        createAnimal(sheepType, x, y);
                        createAnimal(sheepType, x + 2, y + 2);
                    }
                }
                if (wolfCount == 0)
                {
                    if (random.Next(0, 100) < 30)
                    {
                        int x = random.Next(2, width - 2);
                        int y = random.Next(2, height - 2);

                        createAnimal(wolfType, x, y);
                        createAnimal(wolfType, x + 2, y + 2);
                    }
                }
            }

            // increase day
            day++;
        }

        // updates txtGrid to represent the current ecosystem
        private void updateTxtGrid()
        {

            Coord c;
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    c = new Coord(i, j);
                    // default
                    txtGrid[i, j] = '.';
                    // adds grass
                    if (hasPlant[i, j])
                        txtGrid[i, j] = '"';
                    // add animal
                    if (anmlGrid[i, j] > -1)
                    {
                        Animal a = animals[anmlGrid[i, j]];
                        if (a.name == SHEEP_NAME)
                        {
                            if (a.isMature())
                                txtGrid[i, j] = '@';
                            else
                                txtGrid[i, j] = 'a';
                        }
                        else if (a.name == WOLF_NAME)
                        {
                            if (a.isMature())
                                txtGrid[i, j] = '¥';
                            else
                                txtGrid[i, j] = 'v';
                        }
                    }
                }
            }
        }

        // returns a the txtGrid in the form of a string
        public string getTxtGrid()
        {
            updateTxtGrid();
            string worldGrid = "";

            // draw grid
            for (int j=0; j<height; j++)
            {
                for (int i=0; i<width; i++)
                {
                    worldGrid += txtGrid[i, j];
                }
                worldGrid += "\r\n";
            }
            return worldGrid;
        }

        private void updatePlntGrid()
        {
            foreach (Plant p in plants)
            {
                plntGrid[p.coord.x, p.coord.y] = plants.IndexOf(p);
            }
        }

        private void updateAnmlGrid()
        {
            foreach (Animal a in animals)
            {
                anmlGrid[a.coord.x, a.coord.y] = animals.IndexOf(a);
            }
        }

        /**
         * Grass Behaviors
         */
        // behavior for grass repoduction
        private void seedNewGrass(Plant p)
        {
            // plant seeding
            if (p.seed())
            {
                int rng = 3;
                int iX = p.coord.x;
                int iY = p.coord.y;

                // generate new plant's coord
                int nX = random.Next(iX - rng, iX + rng);
                int nY = random.Next(iY - rng, iY + rng);

                // is new plant's coord in bounds?
                bool xInBounds = (nX >= 0 && nX < width);
                bool yInBounds = (nY >= 0 && nY < height);
                if (xInBounds && yInBounds)
                {
                    createGrass(nX, nY);
                }
            }
        }

        // create new grass
        // returns true if successful
        public bool createGrass(int x, int y)
        {
            // if a plant already exists there, dont create a new plant
            if (!hasPlant[x, y])
            {
                hasEntity[x, y] = true;
                hasPlant[x, y] = true;
                Plant p = new Plant(grass, Coord.coordAt(x, y) );
                plants.Add(p);
                plntGrid[x, y] = plants.IndexOf(p);
                grassCount++;
                return true;
            }
            return false;
        }

        // removes grass
        // returns true is successful
        bool killPlant(Plant p)
        {
            // make sure a plant exists there first
            if (plants.Contains(p) )
            {
                // remove the grass
                hasPlant[p.coord.x, p.coord.y] = false;
                plntGrid[p.coord.x, p.coord.y] = -1;
                plants.Remove(p);
                grassCount--;
                updatePlntGrid();
                return true;
            }
            return false;
        }
        // END GRASS BEHAVIORS

        private void defaultBehavior(Animal a)
        {
            Coord temp = new Coord();
            if (a.isFull && !neighborsEntity(a, a.foodName(), temp) )
            {
                eatFoodAt(a, temp);
            }
            else
            {
                int mv = a.getMovement();
                temp = new Coord(random.Next(-mv, mv + 1), random.Next(-mv, mv + 1));
                moveAnmlByVector(a, temp);
            }
        }

        private void hungryBehavior(Animal a)
        {
            Coord foodCrd = new Coord();
            if (neighborsEntity(a, a.foodName(), foodCrd) )
            {
                foodCrd = findEntityWithin(a, a.foodName(), 1);
                eatFoodAt(a, foodCrd);
            }
            else
            {
                moveToNearestEntity(a, a.foodName());
            }
        }

        // Mating Behavior
        private void matingBehavior(Animal a)
        {
            Coord mateCrd = new Coord();
            if (neighborsEntity(a, a.name))
            {
                bool babyCreated = false;
                int x = a.coord.x+random.Next(-1, 2);
                int y = a.coord.y+random.Next(-1, 2);
                if (Coord.coordAt(x, y).isWithin(0, width - 1, 0, height - 1))
                {
                    if (a.name == SHEEP_NAME)
                        babyCreated = createAnimal(sheepType, x, y);
                    if (a.name == WOLF_NAME)
                        babyCreated = createAnimal(wolfType, x, y);
                }
                
                if (babyCreated)
                    a.reproduce();
            }
            else
            {
                if (animals.Count(o => o.name == a.name) == 1)
                    defaultBehavior(a);
                else
                    moveToNearestEntity(a, a.name);
            }
        }

        public void eatFoodAt(Animal a, Coord c)
        {
            if (hasPlant[c.x, c.y])
                if (plants[plntGrid[c.x, c.y]].name == a.foodName())
                {
                    killPlant(plants[plntGrid[c.x, c.y]]);
                    a.eat(PLANT_HARDINESS);
                    return;
                }
            if (hasAnimal[c.x, c.y])
                if (animals[anmlGrid[c.x, c.y]].name == a.foodName())
                {
                    killAnimal(animals[anmlGrid[c.x, c.y]]);
                    a.eat(ANIMAL_HARDINESS);
                    return;
                }
        }

        public bool createAnimal(Animal.AnimalType animalType, int x, int y)
        {
            // if an animal exists
            if (!hasAnimal[x, y])
            {
                hasEntity[x, y] = true;
                hasAnimal[x, y] = true;
                Animal a = new Animal(animalType, Coord.coordAt(x, y));
                animals.Add(a);
                anmlGrid[x, y] = animals.IndexOf(a);

                if (a.name == SHEEP_NAME)
                    sheepCount++;
                if (a.name == WOLF_NAME)
                    wolfCount++;

                return true;
            }
            return false;
        }

        bool killAnimal(Animal a)
        {
            if (animals.Contains(a))
            {
                hasAnimal[a.coord.x, a.coord.y] = false;
                anmlGrid[a.coord.x, a.coord.y] = -1;
                animals.Remove(a);
                if (a.name == SHEEP_NAME)
                    sheepCount--;
                if (a.name == WOLF_NAME)
                    wolfCount--;
                updateAnmlGrid();
                return true;
            }
            return false;
        }

        void moveAnmlToward(Animal a, Coord loc)
        {
            Coord vToLoc = loc - a.coord;
            double vLength = vToLoc.getDistance(Coord.coordAt(0, 0));
            Coord mvmntVector = (vToLoc / vLength) * a.getMovement();
            moveAnmlByVector(a, mvmntVector);
        }

        bool moveAnmlByVector(Animal a, Coord v)
        {
            Coord oldLoc = a.coord;
            Coord newLoc = oldLoc+v;
            if (newLoc.isWithin(0, width-1, 0, height-1) )
            {
                if (!hasAnimal[newLoc.x, newLoc.y])
                {
                    // changing coord moved to in hasAnimal and anmlGrid
                    hasAnimal[newLoc.x, newLoc.y] = true;
                    anmlGrid[newLoc.x, newLoc.y] = animals.IndexOf(a);
                    // removing animal from old coord in hasAnimal and anmlGird
                    hasAnimal[oldLoc.x, oldLoc.y] = false;
                    anmlGrid[oldLoc.x, oldLoc.y] = -1;
                    a.move(newLoc);
                    return true;
                }
            }
            return false;
        }

        bool neighborsEntity(Animal a, string name)
        {
            return neighborsEntity(a, name, Coord.coordAt(0, 0));
        }

        bool neighborsEntity(Animal a, string name, Coord o)
        {
            o = findEntityWithin(a, name, 1);
            if (o == null)
                return false;
            return true;
        }

        Coord findEntityWithin(Animal a, string name, int range)
        {
            for (int i=a.coord.x-range; i<=a.coord.x+range; i++)
            {
                for (int j = a.coord.y - range; j <= a.coord.y + range; j++)
                {
                    if (i != a.coord.x && j != a.coord.y)
                    {
                        if (Coord.coordAt(i, j).isWithin(0, width - 1, 0, height - 1))
                        {
                            if (hasPlant[i, j])
                            {
                                if (plants[plntGrid[i, j]].name == name)
                                    return plants[plntGrid[i, j]].coord;
                            }
                            if (anmlGrid[i, j] > -1)
                            {
                                if (animals[anmlGrid[i, j]].name == name)
                                    return animals[anmlGrid[i, j]].coord;
                            }
                        }
                    }
                }
            }
            return null;
        }

        void moveToNearestEntity(Animal a, string eName)
        {
            if (entityExists(eName) )
            {
                Coord eLoc = findNearestEntity(a, eName);
                moveAnmlToward(a, eLoc);
            }
        }

        Coord findNearestEntity(Animal a, string eName)
        {
            List<Coord> eCoords = new List<Coord>();
            foreach (Plant p in plants)
            {
                if (p.name == eName)
                {
                    eCoords.Add(p.coord);
                }
            }
            foreach (Animal b in animals)
            {
                if (b.name == eName && b.coord != a.coord)
                {
                    eCoords.Add(b.coord);
                }
            }

            if (eCoords.Count > 0)
            {
                KDTree kTree = new KDTree();
                kTree.AddList(eCoords, 0);
                return kTree.findNearestNeighbor(a.coord);
            }
            else
                return null;
        }
        
        bool entityExists(string n)
        {
            foreach (Plant p in plants)
            {
                if (p.name == n)
                    return true;
            }
            foreach (Animal a in animals)
            {
                if (a.name == n)
                    return true;
            }
            return false;
        }
    }
}
