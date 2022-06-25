using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Iznimke
{
    public class NepotpunaPoljaPriUnosu : Exception
    {
        public NepotpunaPoljaPriUnosu(string message) : base(message) { }
    }
}
