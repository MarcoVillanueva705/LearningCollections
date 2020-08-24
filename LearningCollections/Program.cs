using System;
using System.Collections.Generic;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while(adding)
            {
                Console.Write("Student Name...");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade...");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.Write("Add another student? y/n");

                if(Console.ReadLine() != "y")
                {
                    adding = false;
                }

                for(int i = 0; i < studentNames.Count; i++)
                {
                    //Name is obj arg 0 as string(studentNames), and Grade is obj arg 1 as int(studentGrades)
                    //args arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
                }
            }
        }
    }
}
