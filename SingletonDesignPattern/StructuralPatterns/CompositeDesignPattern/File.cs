using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.CompositeDesignPattern
{
    public class File : IFileSystemItem
    {
        private string _name;
        public File(string name)
        {
            _name = name;
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent} - File {_name}");
        }
    }
}
