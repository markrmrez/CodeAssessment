using CodingAssessment.Lib.Implementations;
using CodingAssessment.Lib.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;

namespace CodingAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI for the services needed.
            //Please provide inputFilePath and outputFilePath 
            //on the declaration for FileManager below. 
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ISortLogic<string>,BubbleSort>()
                .AddSingleton<IFileManager>(new FileManager(
                        inputFilePath: @"C:\Users\mrkrm\source\git-repo\CodeAssessment\CodingAssessment\Files\unsorted-names-list.txt", 
                        outputFilePath: @"C:\Users\mrkrm\source\git-repo\CodeAssessment\CodingAssessment\Files\sorted-names-list.txt"))
                .BuildServiceProvider();

            var fileTool   = serviceProvider.GetService<IFileManager>();
            var sortTool   = serviceProvider.GetService<ISortLogic<string>>();
            
            try
            {
                //Read data from the input file
                var rawData = fileTool.Open();

                //Sort the data using Bubble sort
                var sortedList = sortTool.Sort(rawData);

                //Display sorted data on the console
                foreach (string s in sortedList)
                    Console.WriteLine(s);

                //Save the file
                fileTool.Save(sortedList);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error Occured.");
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}


