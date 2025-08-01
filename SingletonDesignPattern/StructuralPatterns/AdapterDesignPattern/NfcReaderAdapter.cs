using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern.StructuralPatterns.AdapterDesignPattern
{
    public class NfcReaderAdapter : ICardReader
    {
        private readonly NfcReader _nfcReader;

        public NfcReaderAdapter(NfcReader nfcReader)
        {
            _nfcReader = nfcReader;
        }

        public void ReadCard()
        {
            _nfcReader.Scan();
        }
    }
}
