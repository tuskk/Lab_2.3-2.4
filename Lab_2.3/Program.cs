using System;

namespace Lab_2._3
{
    class Strings
    {
        public virtual int Length()
        {
            return 0;
        }

        public virtual void Replace()
        {
            Console.WriteLine("Base class Replace method");
        }
    }

    class Characters : Strings
    {
        private string value;

        public Characters(string value)
        {
            this.value = value;
        }

        public override int Length()
        {
            return value.Length;
        }

        public override void Replace()
        {
            value = value.Replace("#", "!!");
        }

        public void Print()
        {
            Console.WriteLine(value);
        }
    }

    class Digits : Strings
    {
        private string value;

        public Digits(string value)
        {
            this.value = value;
        }

        public override int Length()
        {
            return value.Length;
        }

        public override void Replace()
        {
            value = value.Replace("3", "11");
        }

        public void Print()
        {
            Console.WriteLine(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int Repline;
            do
            {
                Console.WriteLine("Enter a string:");
                string input1 = Console.ReadLine();
                Characters characters = new Characters(input1);

                Console.WriteLine("Enter another string:");
                string input2 = Console.ReadLine();
                Digits digits = new Digits(input2);

                Console.WriteLine("Length of characters: {0}", characters.Length());
                Console.WriteLine("Length of digits: {0}", digits.Length());

                Console.WriteLine("Replacing characters...");
                characters.Replace();
                Console.WriteLine("Characters after replacement:");
                characters.Print();

                Console.WriteLine("Replacing digits...");
                digits.Replace();
                Console.WriteLine("Digits after replacement:");
                digits.Print();
                Console.WriteLine("repeat?(1 = yes,0 = no)");
                Repline = int.Parse(Console.ReadLine());
            } while (Repline == 1 & Repline != 0);
            Console.ReadKey();
        }
    }
}
