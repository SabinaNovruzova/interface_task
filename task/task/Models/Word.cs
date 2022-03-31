using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    public class Word : IPrintableFile
    {
        public string FileName { get; set; }
        public int WordCount { get; set; }
        public Word(string fileName,int wordCount)
        {
            FileName = fileName;
            WordCount = wordCount;
        }

        public void Print()
        {
            Console.WriteLine($"name:{FileName}  counts:{WordCount} "); 
        }
    }
}
