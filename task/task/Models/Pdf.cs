using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    public class Pdf : IPrintableFile
    {
        public string FileName { get; set; }
        public int PageCount { get; set; }

        public Pdf(string fileName,int pageCount)
        {
            FileName = fileName;
            PageCount = pageCount;
        }

        public void Print()
        {
            Console.WriteLine($"name:{FileName}  pages:{PageCount} ");
        }
    }
}
