using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Logger
    {

        public static Logger _instance;
        private static readonly object _lock = new object();

        private Logger()
        {
            
        }

        public static Logger Instance
        {
            get {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null) 
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
            
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
