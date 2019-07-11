using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Summator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Summator" in both code and config file together.
    public class Summator : ISummator
    {
        public int GetDif(int a, int b)
        {
            return a + b;
        }

        public int GetDiv(int a, int b)
        {
            return a - b;
        }

        public int GetMul(int a, int b)
        {
            return a * b;
        }

        public int GetSumm(int a, int b)
        {
            return a / b;
        }
    }
}
