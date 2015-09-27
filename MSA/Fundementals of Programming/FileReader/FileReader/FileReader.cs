using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    class FileReader
    {
        static void Main()
        {
            Console.WriteLine("Hellow Worlds");
            // Crate an instance of StremReader
            StreamReader reader = new StreamReader("Sample.txt");


            using (reader)
            {
                int lineNumber = 0;

                //REad first line from the text file
                string line = reader.ReadLine();

                //Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }

            //Close the resourse after finished using it
            // reader.Close();

            //Write a file
            StreamWriter writer = new StreamWriter("numbers.txt");

            //Ensure the writer will be clossed when no longer used
            using (writer)
            {
                // Loop through the numbers from 1 to 20 and write them 
                for (int i = 0; i < 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }
    }
}
