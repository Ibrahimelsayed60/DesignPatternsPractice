using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.CompositeDesignPattern
{
    public class Folder : IFileSystemItem
    {
        private string _name;
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Display(string indent)
        {
            Console.WriteLine($"{indent} + Folder: {_name}");
            foreach(var item in _items)
            {
                item.Display(indent + " ");
            }
        }
    }
}
