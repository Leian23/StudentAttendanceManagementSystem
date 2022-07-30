using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    public class GetViewData
    {

        public static List<string> GetData()
        {
            List<string> dataList = new List<string>();

            Console.WriteLine("\nPlease input your name initials: ");
            Console.WriteLine("e.g Juan B Dela Cruz = JBDC");
            Functions.input = Console.ReadLine();

            if (Functions.input.Length != 0)
            {

                if (Functions.input == "LCA" || Functions.input == "lca")
                {
                    Functions.Name = "Ayeras, Leandro C";

                }
                else if (Functions.input == "JLBB" || Functions.input == "jlbb")
                {
                    Functions.Name = "Buhain, Jan Lorenz B";

                }
                else if (Functions.input == "ACPG" || Functions.input == "acpg")
                {
                    Functions.Name = "Garcia, Anne Crisel P";
                }
                else if (Functions.input == "BAA" || Functions.input == "baa")
                {
                    Functions.Name = "Arzola, Benedict A";
                }
                else if (Functions.input == "JAC" || Functions.input == "jac")
                {
                    Functions.Name = "Canilao, Jeffrey A";
                }
                else
                {
                    Functions.Name = $"'{Functions.input}' unrecognized";
                    Console.WriteLine("Initials are not enrolled but your attempt to log is still added in the textfile");
                }
            }
            else
            {
                Functions.Name = "";
                ViewFile();
            }


            dataList.Add(Functions.Name);


            return dataList;

        }

        public static void DisplayData()
        {
            List<string> dataContent = FileStream.ReadFile();

            foreach (var data in dataContent)
            {
                Console.WriteLine(data);
            }
        }

       
        public static void Read()
        {
            try
            {
                Console.WriteLine("Displaying your inputs in console....\n");
                DisplayData();
                Console.WriteLine("\nSuccesfully displayed");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ViewFile()
        {
            string read;
            Console.WriteLine("View File in Console?");
            Console.WriteLine("Please type Yes or No");
            read = Console.ReadLine();

            if (read.Equals("Yes") || read.Equals("yes") || read.Equals("YES"))
            {
                Read();
            }

            else
            {
                Console.WriteLine("Okay... Thank you!");
            }

        }




    }

}




