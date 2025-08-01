using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.AdapterDesignPattern
{
    public class NfcReader
    {
        public void Scan()
        {
            Console.WriteLine("Reading Nfc Tag");
        }
    }
}
