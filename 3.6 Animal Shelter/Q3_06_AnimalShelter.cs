using System;
using System.Collections.Generic;
using System.Text;

namespace _3._6_Animal_Shelter
{
    class Q3_06_AnimalShelter
    {
        #region region-> Run Method
        public static void Run()
        {
            ////LD create and populate a stack
            //StackOverride aStack = new StackOverride();

            //aStack.Push(6);
            //aStack.Push(9);
            //aStack.Push(3);
            //aStack.Push(12);
            //Console.WriteLine("Min expected 3 -> " + aStack.getCurrentMin());
            //aStack.Pop();
            //aStack.Pop();
            //Console.WriteLine("Min expected 6 -> " + aStack.getCurrentMin());
            //aStack.Push(4);
            //Console.WriteLine("Min expected 4 -> " + aStack.getCurrentMin());
            //aStack.Push(4);
            //aStack.Push(44);
            //Console.WriteLine("Min expected 4 -> " + aStack.getCurrentMin());

            //Console.ReadLine();
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
                //LD there in an elegant approach using interfaces instead of IF, WILL IMPLEMENT IT
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
                    return lastDog;
                }
                return dequeueCat();
            }



        }

        #endregion

        #region region-> support classes

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
