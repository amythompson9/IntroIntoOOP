using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Cat
    {
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry; 

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }
        public int Age
        {
            get { return this.age; }
        }

        public Cat()
        {
            this.name = "Mittens";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat(int age)
        {
            this.age = age;
        }
        public string FurColor { get; set; }
        public int FurLength { get; set; }

        public Cat(string name, string furColor, int furLength, bool isMale, int age, bool isHungry)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            
        }
        public void Eat()
        {
            if(isHungry)
            {
                this.isHungry = false;
                Console.WriteLine("I'm stuffed");
            }
            else if(!isHungry)
            {
                Console.WriteLine("I'm good. No food for me");
            }
        }
        public void Run()
        {
            Console.WriteLine("I am running really fast!!");
            this.isHungry = true;
        }
        public void Sleep()
        {
            Console.WriteLine("I'm taking a nap.");
        }
        public void Scratching()
        {
            Console.WriteLine("Im sharpening my claws on your carpet because I destroy things because I'm a dick cat.");
        }
        public void Talk()
        {
            Console.WriteLine("My name is {0} and yes I can talk.",this.name);
        }
    }
}
