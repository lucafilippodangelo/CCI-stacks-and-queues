using System;
using System.Collections.Generic;
using System.Text;

namespace _3._6_Animal_Shelter
{
    //LD Q3_06_AnimalShelter
    class Q3_06_AnimalShelter
    {
        #region region-> Run Method
        public static void Run()
        {
            ManageQueues mqInstance = new ManageQueues();

            //LD create few animals and the enqueue
            AnimalDog dogOne = new AnimalDog("dogOne");
            mqInstance.enqueueAnimal(dogOne);

            AnimalCat catOne = new AnimalCat("catOne");
            mqInstance.enqueueAnimal(catOne);

            AnimalDog dogTwo = new AnimalDog("dogTwo");
            mqInstance.enqueueAnimal(dogTwo);

            AnimalDog dogThree = new AnimalDog("dogThree");
            mqInstance.enqueueAnimal(dogThree);

            AnimalCat catTwo = new AnimalCat("catTwo");
            mqInstance.enqueueAnimal(catTwo);

            AnimalDog dogFour = new AnimalDog("dogFour");
            mqInstance.enqueueAnimal(dogFour);

            AnimalCat catThree = new AnimalCat("catThree");
            mqInstance.enqueueAnimal(catThree);

            //LD dequeue process 

            //LD dequeue dog (dogFour)
            mqInstance.dequeueDog();

            //LD dequeue cat (catThree)
            mqInstance.dequeueCat();

            //LD dequeue oldest (catTwo)
            mqInstance.dequeueOldest();

            //LD dequeue oldest (dogThree)
            mqInstance.dequeueOldest();
        }
        #endregion

        #region region-> Manage Queues

        internal class ManageQueues
        {
            //LD has to have two LIFO structures
            private LinkedList<AnimalCat> CatList = new LinkedList<AnimalCat>();
            private LinkedList<AnimalDog> DogList = new LinkedList<AnimalDog>();

            internal ManageQueues()
            {}

            //LD "Enqueue" method to insert the right animal in the propper queue
            internal void enqueueAnimal(Animal anAnimal)
            {
                //LD depending on the type enqueue in the proper queue.
                if (anAnimal is AnimalCat)
                { CatList.AddLast((AnimalCat)anAnimal); }
                else
                { DogList.AddLast((AnimalDog)anAnimal); }
            }

            //LD "Dequeue Dog" method
            internal AnimalDog dequeueDog()
            {
                AnimalDog lastDog = DogList.Last.Value;
                DogList.RemoveLast();
                return lastDog;
            }

            //LD "Dequeue Cat" method
            internal AnimalCat dequeueCat()
            {
                AnimalCat lastCat = CatList.Last.Value;
                CatList.RemoveLast();
                return lastCat;
            }

            //LD "Dequeue" method that return the oldest between all animals in the shelter
            internal Animal dequeueOldest()
            {
                AnimalDog lastDog = DogList.Last.Value;
                AnimalCat lastCat = CatList.Last.Value;

                if (lastDog.arrivalTime > lastCat.arrivalTime)
                {
                    return dequeueDog();
                }
                return dequeueCat();
            }

        }

        #endregion

        #region region-> support classes

        //LD for each animal we register "name" and "arrivalTime"
        internal abstract class Animal
            {
            internal string uniqueIdName;
            internal DateTime arrivalTime;

            public Animal(string uniqueIdName)
                {
                    this.uniqueIdName = uniqueIdName;
                    this.arrivalTime = System.DateTime.Now;
                }
            }

        internal class AnimalCat : Animal
        {
            internal AnimalCat(string uniqueIdName) : base(uniqueIdName)
            {}
        }

        internal class AnimalDog : Animal
        {
            internal AnimalDog(string uniqueIdName) : base(uniqueIdName)
            { }
        }

        #endregion
    }
}
