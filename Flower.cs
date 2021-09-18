using System;

namespace quizFlower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Rose");
            Console.WriteLine("------------------");

            Console.WriteLine("ID :");
            // :((((((( จะกลับไปตั้งใจเรียนกว่านี้
        }

        //class 1
        class flowerRose
        {
            public int ID;
            public string name;
            public string info;
            public int amount;
            public int height;
            public string circumference;

            public flowerRose(int valueID, string valueName, string valueInfo, int valueAmount, int valueHeight, string valueCircumference)
            {
                ID = valueID;
                name = valueName;
                info = valueInfo;
                amount = valueAmount;
                height = valueHeight;
                circumference = valueCircumference;
            }

            public void outputRose()
            {
                Console.WriteLine("ID : {0}",this.ID);
                Console.WriteLine("Plant name : {0}", this.name);
                Console.WriteLine("Plant Description : {0}",this.info);
                Console.WriteLine("Amount : {0}", this.amount);
                Console.WriteLine("Height : {0}",this.height);
                Console.WriteLine("Circumference : {0}",this.circumference);
            }
        }

        //class 2
        class flowerSunflower
        {
            public int ID;
            public string name;
            public string info;
            public int amount;
            public int height;
            public string circumference;

            public flowerSunflower(int valueID, string valueName, string valueInfo, int valueAmount, int valueHeight, string valueCircumference)
            {
                ID = valueID;
                name = valueName;
                info = valueInfo;
                amount = valueAmount;
                height = valueHeight;
                circumference = valueCircumference;
            }

            public void outputSunflower()
            {
                Console.WriteLine("ID : {0}",this.ID);
                Console.WriteLine("Plant name : {0}",this.name);
                Console.WriteLine("Plant Description : {0}",this.info);
                Console.WriteLine("Amount : {0}", this.amount);
                Console.WriteLine("Height : {0}",this.height);
                Console.WriteLine("Circumference : {0}",this.circumference);
            }
        }
    }
}
