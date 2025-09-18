using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public abstract class FileWorker
    {
        public int FileMaxStorage { get;  set; }
        public FileWorker(int FileMaxStorage)
        {
            this.FileMaxStorage = FileMaxStorage;
        }
        public abstract string FileExtention { get; }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();



    }
}
