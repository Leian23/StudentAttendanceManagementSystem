using System;
using System.Collections.Generic;
using System.IO;

namespace CSharpExercises
{

    public class Functions
    {
        public static string Name;
        public static string input;


        public static List<string> Datetime()
        {
            List<string> TimeData = new List<string>();


            string date = ($"{DateTime.Now.ToString()}");

            TimeData.Add(date);

            return TimeData;

        }


        public static List<string> Validator()
        {
            List<string> Validate = new List<string>();

            string validation;


            if (Name.Equals("Ayeras, Leandro C") || (Name.Equals("Buhain, Jan Lorenz B") || (Name.Equals("Garcia, Anne Crisel P") ||
               (Name.Equals("Arzola, Benedict A") || (Name.Equals("Canilao, Jeffrey A"))))))

            {
                validation = "Present";
            }

            else if (Name == $"'{input}' unrecognized")
            {
                validation = "-------";
            }

            else
            {
                validation = "Absent";

            }

            Validate.Add(validation);
            return Validate;
        }




        public static List<string> StudentNum()
        {
            List<string> Student = new List<string>();
            string student_num, Input;



            if (Name.Equals("Ayeras, Leandro C") || Name.Equals("Buhain, Jan Lorenz B") || Name.Equals("Garcia, Anne Crisel P") ||
                (Name.Equals("Arzola, Benedict A") || Name.Equals("Canilao, Jeffrey A")))
            {
                Console.WriteLine("Would you like to display your student number?");
                Console.WriteLine("Please type Yes or No");
                Input = Console.ReadLine();

                if (Input == "yes" || Input == "Yes" || Input == "YES")
                {
                    if (Name.StartsWith("Ayeras"))
                    {
                        student_num = "2020-00089-BN-0";
                        Student.Add(student_num);
                    }
                    else if (Name.StartsWith("Buhain"))
                    {
                        student_num = "2020-00097-BN-0";
                        Student.Add(student_num);
                    }
                    else if (Name.StartsWith("Garcia"))
                    {
                        student_num = "2020-00008-BN-0";
                        Student.Add(student_num);
                    }
                    else if (Name.StartsWith("Arzola"))
                    {
                        student_num = "2020-00091-BN-0";
                        Student.Add(student_num);
                    }
                    else if (Name.StartsWith("Canilao"))
                    {
                        student_num = "2020-00090-BN-0";
                        Student.Add(student_num);
                    }


                }

                else if (Input == "No" || Input == "no" || Input == "NO")
                {
                    student_num = "Hidden";
                    Student.Add(student_num);
                }


            }

            else
            {
                student_num = "-------";
                Student.Add(student_num);
            }


            return Student;
        }


    }

}