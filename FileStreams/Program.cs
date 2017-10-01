using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileStreams
{
    class IInterface
    {
        void Method1()
        {

        }
    }

    class InputValue
    {
        static public long EnterIntegerFixed(string inputRequest, int length) // Enter fixed number of integers and confirm only integers entered
        {
            long intOut = -1;
            string inString = "";
            bool tryParse = false;

            while (!tryParse || (inString.Length != length))
            {
                Console.Write(inputRequest);
                inString = Console.ReadLine();
                tryParse = Int64.TryParse(inString, out intOut);
                // Console.WriteLine("tryParse = " + tryParse);
                // Console.WriteLine("inString.Length = " + inString.Length);

                if (!tryParse && (inString.Length != length))
                {
                    Console.WriteLine(" length was wrong and incorrect use of non integers - please try again");
                }

                if (!tryParse && (inString.Length == length))
                {
                    Console.WriteLine("Input contained non integers - please try again. " + inputRequest);
                }
                if (tryParse && inString.Length != length)
                {
                    Console.WriteLine("Input was of the wrong length - please try again. " + inputRequest);
                }


            }
            Console.WriteLine("Thanks.");
            return intOut;
        }

        static public long EnterInteger(string inputRequest) // Enter undefined number of integers and confirm only integers entered
        {
            long intOut = -1;
            string inString = "";
            bool tryParse = false;

            while (!tryParse)
            {
                Console.Write(inputRequest);
                inString = Console.ReadLine();
                tryParse = Int64.TryParse(inString, out intOut);

                if (!tryParse)
                {
                    Console.WriteLine("Try again. " + inputRequest);
                }
                else
                {
                    Console.WriteLine("Thanks.");
                }

            }

            return intOut;
        }

    }

    class Program
    {

        static void WriteFile (string filetowrite, int inLength)
        {
            try
            {
                StreamWriter writer = new StreamWriter("newfile.txt");

                using (writer)
                {
                    for (int i = 1; i <= inLength; i++)
                    {
                        writer.WriteLine(i);
                    }
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file could not be found AA");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory doesn't exist AA");
            }
            catch (IOException)
            {
                Console.WriteLine("File IO error AA");
            }
        }

        static void ReadFile(string filetoread)
        {

            try
            {
                StreamReader reader = new StreamReader(filetoread);
                using (reader)
                {
                    int linenum = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                        linenum++;

                    }
                }



            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find file AA");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("could not find directory AA");
            }
            catch (IOException)
            {
                Console.WriteLine("IO Exception AA");
            }
        }

        static string LocateTextInFile(string filetoread)
        {
            string returntext = null;




            return returntext;
        }

        static string GDPRUsingRegex(string inString)
        {
            inString = Regex.Replace(inString, "(08)[0-9]{8}", "$1********");

            return inString;
        }



        static void Main()
        {

            /* string fileloc = @".\newfile.txt";
            int Length = 0;

            Console.WriteLine("Enter a number: ");

            bool intParse = false;

            while (!intParse)
            {

                string input = Console.ReadLine();
                intParse = Int32.TryParse(input, out int inLength);
                if (!intParse)
                {
                    Console.WriteLine("Try again");
                }
                else
                {
                    Console.WriteLine("inLength = " + inLength);
                    Length = inLength;
                }

            }


            int value;
            Console.WriteLine("Input an integer for the hell of it");

            
            string inputvalue = "";
            while (inputvalue == "")
            {
                try
                {
                    inputvalue = Console.ReadLine();
                    value = int.Parse(inputvalue);
                }
                catch
                {
                    throw new Exception("D'oh!");
                }
            }


            //WriteFile(fileloc, Length);
            //ReadFile(fileloc);
                */

            InputValue.EnterIntegerFixed("Enter an 11 digit phone number without spaces: ", 11);
        }



    }
}
