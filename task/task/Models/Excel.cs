using System;
using System.Collections.Generic;
using System.Text;

namespace task.Models
{
    public class Excel : IPrintableFile
    {
        public string FileName { get; set; }
        public int ColumnCount { get; set; }
        public int RowCount { get; set; }
        public Excel(string fileName,int columnCount,int rowCount)
        {
            FileName = fileName;
            ColumnCount = columnCount;
            RowCount = rowCount;
        }
        public void Print()
        {
            Console.WriteLine($"name:{FileName}  colums:{ColumnCount}  rows:{RowCount}  ");
        }
    }
}
