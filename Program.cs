using System;
using static System.Console;
using static System.Array;
namespace RelativesList
{
    class RelativesList
    {
        static void Main(string[] args)
        {
            WriteLine("Enter number of relatives");
            int num = int.Parse(ReadLine());
            Relative[] relArr = new Relative[num];

            int x;
            for (x = 0; x < relArr.Length; x++)
            {
                WriteLine("Relative {0};", x+1);
                relArr[x] = new Relative();
                WriteLine("Relative's Name: ");
                relArr[x].Name = ReadLine();
                WriteLine("Relationship to you:");
                relArr[x].Relationship = ReadLine();
                WriteLine("Birth Day: ");
                relArr[x].Day = int.Parse(ReadLine());
                WriteLine("Birth Month: ");
                relArr[x].Month = int.Parse(ReadLine());
                WriteLine("Birth Year: ");
                relArr[x].Year = int.Parse(ReadLine());
            }
            Array.Sort(relArr);
            WriteLine("Sorted Relative's List: ");
            for (x = 0; x < relArr.Length; x++)
            {
                WriteLine("{0,-25}{1,-25}{2}/{3}/{4}", relArr[x].Name, relArr[x].Relationship, relArr[x].Day, relArr[x].Month, relArr[x].Year);
            }
        }
    
    }
    class Relative : IComparable
    {
        public string Name { set; get; }
        public string Relationship { set; get; }
        public int Month { set; get; }
        public int Day { set; get; }
        public int Year { set; get; }

        int IComparable.CompareTo(object obj)
        {
            int retVal;
            Relative temp = (Relative)obj;
            retVal = this.Name.CompareTo(temp.Name);
            return retVal;

        }
    }

   
}
