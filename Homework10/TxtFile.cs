using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Homework10
{
    internal class TxtFile(int FileMaxStorage) : FileWorker(FileMaxStorage)
    {
        public override string FileExtention => ".txt";
      
        public override void Read() => Console.WriteLine($"I can read from {FileExtention} file with max storage {FileMaxStorage}");
       
        public override void Write() => Console.WriteLine($"I can read from  {FileExtention} file with max storage {FileMaxStorage}");

        public override void Edit() => Console.WriteLine($"I can read from  {FileExtention} file with max storage {FileMaxStorage}");

        public override void Delete() => Console.WriteLine($"I can read from  {FileExtention} file with max storage {FileMaxStorage}");
    }
}
