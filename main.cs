using System;

namespace Grading_app
{
    class Program
    {
        static void Main(string[] args)
        {

            int grade;


            Console.WriteLine("Please Enter your Score");
            grade = int.Parse(Console.ReadLine());




            if (grade == 100)
            {

                Console.WriteLine("Your grade is an:  A+");
            }


            else if (grade >= 80)
            {

                Console.WriteLine(" Your grade is an: B");
            }

            else if (grade >= 70)
            {
                Console.WriteLine(" Your grade is an: C");
            }

            else if (grade >= 60)
            {
                Console.WriteLine(" Your grade is an: D");
            }

            else

            {
                Console.WriteLine("  Sorry You Failed");
            }



                }
            }
           
        }
    

