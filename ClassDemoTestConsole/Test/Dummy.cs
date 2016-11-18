using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTestConsole.Test
{
    public class Dummy
    {
        private int somenumber;

        public int Somenumber
        {
            get { return somenumber; }
            set
            {
                if (value < 1 || 4 < value)
                {
                    throw new ArgumentException("somenumber must be in range 1-4");
                }
                somenumber = value;
            }
        }
        private string sometext;

        public string Sometext
        {
            get { return sometext; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    {
                    throw new ArgumentException("Sometext must be empty or null");
                }
                sometext = value;
            }
        }
    }
}
