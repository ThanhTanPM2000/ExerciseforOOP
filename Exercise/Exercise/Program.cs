using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            //Console.WriteLine(ahTeck);  // Test toString()
            //ahTeck.SetEmail("paulTan@nowhere.com");  // Test setter
            //Console.WriteLine("name is: " + ahTeck.GetName());     // Test getter
            //Console.WriteLine("eamil is: " + ahTeck.getEmail());   // Test getter
            //Console.WriteLine("gender is: " + ahTeck.GetGender()); // Test gExerciseOOP_MyPolynomial.pngetter

            //===========================================================================
            // Declare and allocate an array of Authors
            Author[] authors = new Author[2];
            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            // Declare and allocate a Book instance
            Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy);  // toString()

            Console.WriteLine(javaDummy.getAuthorNames());
            Console.ReadLine();
        }
    }
}
