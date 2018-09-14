using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            string newDoc = null;
            string contents = null;
            string docName = null;
            string text = ".txt";
            int count = 0;

            Console.WriteLine("Document\n");
            Console.WriteLine("What would you like to name the document?");
            newDoc = Console.ReadLine();

            if (newDoc.Contains(".txt"))
            {
                docName = newDoc;
            }
            else
                docName = newDoc + text;

                try
                {
                    using (StreamWriter sw = new StreamWriter(docName)) //'Using' closes the file stream when it's done, don't need to have a close at the end
                    {
                        Console.WriteLine("What will be the contents of the file?");
                        contents = Console.ReadLine();
                        sw.WriteLine(contents);
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("The file could not be read: ");
                    Console.WriteLine(error.Message);
                }

                //Not sure how to implement for if an exception does occur, nor do I know what exception might occur
                count = contents.Length;
                Console.WriteLine("\n{0} saved successfully, document contains {1} characters.", docName, count);

                /* This just outputs the contents of the file           
                Console.WriteLine("\nThe contentst of the file are: ");
                string line = "";
                using (StreamReader sr = new StreamReader(docName))
                {
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                */

            Console.ReadLine();
        }
    }
}
