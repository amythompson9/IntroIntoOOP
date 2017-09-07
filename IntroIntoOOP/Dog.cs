using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Dog
    {
        //Create a Dog class
        //The class Dog should have the following fields
        //hairlength
        //heighth
        //runningSpeed
        //weight
        //The class should have the following behaviors
        //Run()
        //Bark()
        //Potty()
        //Cuddle()
        private int hairLength;
        private int heighth;
        private int runningSpeed;
        private int weight;
        //default constructor
        public Dog()
        {
            this.hairLength = 3;
            this.heighth = 3;
            this.runningSpeed = 80;
            this.weight = 220;
        }
        //methodoverloading
        //polymorphism
        public Dog(int weight, int heighth, int runningSpeed, int hairLength)
        {
            this.weight = weight;
            this.heighth = heighth;
            this.runningSpeed = runningSpeed;
            this.hairLength = hairLength;
        }
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public int Heighth
        {
            get { return this.heighth; }
            set { this.heighth = value; }
        }
        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public void Run()
        {
            Console.WriteLine("I have so much energy I can run forever!!");
        }
        public void Bark()
        {
            Console.WriteLine("Someone's at the door and I have to tell everyone about it!!");
        }
        public void Potty()
        {
            Console.WriteLine("I have to go outside.");
        }
        public void Cuddle(string name)
        {
            Console.WriteLine("Please pet my head, {0}", name);
        }
    }
}
