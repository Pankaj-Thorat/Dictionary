using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            //create
            dict.Add("Pankaj", 92);
            dict.Add("Naman", 91);
            dict.Add("Akshay", 95);

            //read
            Console.WriteLine("students Marks -");

            foreach(KeyValuePair<string, int> kvp in dict) 
            {
                Console.WriteLine("Student: "+ kvp.Key+"\tMarks:"+kvp.Value);
            }

            //update

            dict["Pankaj"] = 98;
            dict["Akshay"] = 80;
            Console.WriteLine("\nStudents after modification of Marks -");

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Student: " + kvp.Key + "\tMarks:" + kvp.Value);
            }

            //delete
            dict.Remove("Naman");

            Console.WriteLine("\nStudents after removing 1 student -");
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine("Student: " + kvp.Key + "\tMarks:" + kvp.Value);
            }


        }
    }

}
