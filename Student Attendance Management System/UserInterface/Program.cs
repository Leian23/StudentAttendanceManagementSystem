using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{
    public class Program
    {

        public static void Main(string[] args)
        {

            string selection = DisplayMenu();

            switch (selection)
            {
                case "1":

                    do
                    {

                        List<string> dataInput = GetViewData.GetData();
                        List<string> dateTime = Functions.Datetime();
                        List<string> status = Functions.Validator();
                        List<string> StudentNum = Functions.StudentNum();
                        FileStream.AppendFile(dataInput, dateTime, status, StudentNum);

                    }
                    while (Functions.Name.Length != 0);

                    break;

                case "2":
                    try
                    {
                        Console.WriteLine("Displaying your inputs in console....\n");
                        GetViewData.DisplayData();
                        Console.WriteLine("\nSuccesfully displayed");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }

        }

        internal static string DisplayMenu()
        {
            string code;
            Console.WriteLine("\t\t\t\t\tStudent Attendance Management System\n");
            Console.WriteLine($"Date and Time today: {DateTime.Now.ToString()}\n");
            Console.WriteLine("Input '1' to logged for attendance");
            Console.WriteLine("Input '2' to display text in console\n");
            Console.WriteLine("Code: ");
            code = Console.ReadLine();
            return code;

        }


    }



}