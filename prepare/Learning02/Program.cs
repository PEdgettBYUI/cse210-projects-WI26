using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!\n");

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Menu Demonstration
        bool stop = false;
        while (!stop)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Add a Job");
            Console.WriteLine("2. Display a Resume");
            Console.WriteLine("3. Quit");

            Console.Write("> ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                    Job job1 = new Job();
                    job1._jobTitle = "Software Engineer";
                    job1._company = "Microsoft";
                    job1._startYear = 2019;
                    job1._endYear = 2022;
                    myResume._experience.Add(job1);
            }
            else if (response == "2") 
            {
                myResume.DisplayFullResume();
            }
            else if (response == "3")
            {
                break;
                //stop = true;
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

        }

        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        // Job job2 = new Job();
        // job2._company = "Apple";
        // job2._jobTitle = "Manager";
        // job2._startYear = 2022;
        // job2._endYear = 2023;


        // // Console.WriteLine(job1._company);
        // // Console.WriteLine(job2._company);
        // job1.Display();
        // job2.Display();

        // Resume myResume = new Resume();
        // myResume._name = "Allison Rose";
        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // Console.WriteLine();

        // myResume.Display();


        // Console.WriteLine();
    }
}