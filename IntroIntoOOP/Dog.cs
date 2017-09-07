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

        public Dog(int hairLength, int heighth, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.heighth = heighth;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }
        public int HairLength { get; set; }
        public int Heighth { get; set; }
        public int RunningSpeed { get; set; }
        public int Weight { get; set; }
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
        public void Cuddle()
        {
            Console.WriteLine("Please pet my head.");
        }
    }
}
