using System;

namespace Lab_2._4
{
    interface IInsertingSymbol
    {
        int Length { get; }
        void Insert(char symbol, int position);
    }

    class UpperCaseString : IInsertingSymbol
    {
        private string value;

        public UpperCaseString(string value)
        {
            this.value = value.ToUpper();
        }

        public int Length
        {
            get { return value.Length; }
        }

        public void Insert(char symbol, int position)
        {
            if (position < 0 || position > value.Length)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            value = value.Insert(position, char.ToUpper(symbol).ToString());
        }

        public void Print()
        {
            Console.WriteLine(value);
        }
    }

    class LowerCaseString : IInsertingSymbol
    {
        private string value;

        public LowerCaseString(string value)
        {
            this.value = value.ToLower();
        }

        public int Length
        {
            get { return value.Length; }
        }

        public void Insert(char symbol, int position)
        {
            if (position < 0 || position > value.Length)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            value = value.Insert(position, char.ToLower(symbol).ToString());
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
                Console.Write("Enter an uppercase string: ");
                string upperInput = Console.ReadLine();
                UpperCaseString upper = new UpperCaseString(upperInput);
                Console.WriteLine("Length: {0}", upper.Length);

                Console.Write("Enter a character to insert: ");
                char upperChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Enter the position to insert the character: ");
                int upperPos = int.Parse(Console.ReadLine());
                upper.Insert(upperChar, upperPos);
                upper.Print();

                Console.WriteLine();

                Console.Write("Enter a lowercase string: ");
                string lowerInput = Console.ReadLine();
                LowerCaseString lower = new LowerCaseString(lowerInput);
                Console.WriteLine("Length: {0}", lower.Length);

                Console.Write("Enter a character to insert: ");
                char lowerChar = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Enter the position to insert the character: ");
                int lowerPos = int.Parse(Console.ReadLine());
                lower.Insert(lowerChar, lowerPos);
                lower.Print();
                Console.WriteLine("repeat?(1 = yes,0 = no)");
                Repline = int.Parse(Console.ReadLine());
            } while (Repline == 1 & Repline != 0);
            Console.ReadKey();
        }
    }
}
