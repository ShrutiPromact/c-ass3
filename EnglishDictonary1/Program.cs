using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictonary1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList word = new ArrayList()
            {
                "Boat",
                "house",
                "cat",
                "river",
                "cupboard"
            };
            foreach(string item in word)
            {
                Console.WriteLine(item + "s");
            }
            Console.WriteLine();
            //var resultlist = word.ToList();

            word.RemoveAt(1);
            word.Insert(1,"Home");
            Console.WriteLine("2nd Element " + word[1]);
            Console.WriteLine();

            word.Add("Shruti");
            Console.WriteLine("length of list is =" + word.Count);
            Console.WriteLine();


            var seven = word.FindAll(t => t.Length == 7);
            Console.WriteLine("The words  with 7 characters are:");
            foreach (string v in seven)
                Console.WriteLine(v);


            Console.WriteLine("3rd possition element is = "+ word[2]);
            Console.WriteLine();

           
            word.Sort();
            Console.WriteLine("After Sort:");
            foreach (string item in word)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            word.Reverse();
            Console.WriteLine("After Reverse:");
            foreach (string item in word)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        

            Console.ReadKey();
        }
    }
}
