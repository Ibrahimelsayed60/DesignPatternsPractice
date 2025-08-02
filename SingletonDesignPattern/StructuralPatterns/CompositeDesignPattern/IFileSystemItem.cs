using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.CompositeDesignPattern
{
    public interface IFileSystemItem
    {
        void Display(string indent);
    }
}
