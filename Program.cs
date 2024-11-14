using System;
using System.Text;

namespace StreamReader_Practice_2_3_1_Rewrite
{
    public class FileStreamStuff
    {
        static public void ReadFile(string path, string result)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(path);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
        }

        static public void WriteFile(string path, string result)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine(result);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
        }


        public class Execute
        {
            public static void Main(string[] args)
            {
                string filePath = "C:\\Users\\13cha\\source\\repos\\StreamReader_Practice_2_3_1_Rewrite\\TextFile1.txt";

                //USER COLLECTION
                string userFirst;
                string userLast;
                string userAddress;
                string hold;
                int i = 0;

                List<Person> people = new List<Person>();

                do
                {
                    Console.WriteLine($"\nEnter person {i + 1}'s first name:");
                    userFirst = Console.ReadLine();
                    Console.WriteLine($"Enter person {i + 1}'s last name:");
                    userLast = Console.ReadLine();
                    Console.WriteLine($"Enter person {i + 1}'s mailing address:");
                    userAddress = Console.ReadLine();

                    people.Add(new Person { FirstName = userFirst, LastName = userLast, Address = userAddress });
                    i++;
                    Console.WriteLine("\nWould you like to add another person?");
                    Console.WriteLine("Type 'y' or 'Y' to add another to the list or anyother key to continue.");
                    hold = Console.ReadLine();
                }
                while (hold == "y" || hold == "Y");

                List<string> output = new List<string>();

                foreach (var person in people)
                {
                    output.Add($"{person.FirstName},{person.LastName},{person.Address}");
                }
                string result = String.Join(" ", output);
                WriteFile(filePath, result);
                                                
                Console.WriteLine("\nAll entries written:");
                Console.WriteLine("\n\nHere is your completed list read from your text file:\n");

                // Read step...

                //List<string> lines = File.ReadAllLines(filePath).ToList();
                                                
                //foreach (var person in people)
                //{
                //    Console.WriteLine($"{person.FirstName}, {person.LastName}, {person.Address}");
                //}

                //Console.WriteLine("\nThis ends assignment rewrite 2.3.1.");

                                
                ReadFile(filePath, result);
            }
        }
    }
}
