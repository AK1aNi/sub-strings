using System.Diagnostics.Tracing;

namespace sub_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Mr Milton is the best";

            //Console.WriteLine(words[8]); // square bracket only slice 1 character
            //Console.WriteLine(words.Substring(13)); // if you only give one index it will continue on until the end
            //Console.WriteLine(words.Substring(3, 18)); // how it works
            
            // exp in use
            string [] firstname = {"Jane", "Bob", "Jeff", "Daisy", "Dave"};
            string [] lastname = { "Doe", "Smith", "Stone", "Shepherd", "White"};
            int yearstarted = 2025;
            string username; 
            for (int i = 0; i < firstname.Length; i++)
            {
                username = Convert.ToString(yearstarted).Substring(2) + firstname[i].Substring(0, 1) + lastname[i];
                Console.WriteLine(username);
            }

            //
           





        }
    }
}
