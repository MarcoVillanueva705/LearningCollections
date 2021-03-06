﻿using System;
using System.Collections.Generic;

namespace LearningCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            //boolean that means in this while loop, all code will
            //continue to happen in it until reaching a false condition
            var adding = true;

            while(adding)
            {
                Console.Write("Student Name...");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade...");
                //handling an exception
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.Write("Add another student? y/n");

                if(Console.ReadLine() != "y")
                {
                    //break out of while loop because we flip the
                    //boolean and adding arg to false once "y" typed
                    adding = false;
                }

                for(int i = 0; i < studentNames.Count; i++)
                {
                    //Name is obj arg 0 as string(studentNames), and Grade is obj arg 1 as int(studentGrades)
                    //parameters arr[i] lists the data from the loop
                    Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
                }
            }
        }
    }
}
