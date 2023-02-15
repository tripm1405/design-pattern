using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByCotton
{
    internal sealed class Logger
    {
        private static Logger _instance;

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void write(Exception message)
        {
            using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\logger\\error.txt"))
            {
                writer.WriteLine(message);
            }
        }
    }
}
