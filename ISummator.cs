using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Summator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISummator" in both code and config file together.
    [ServiceContract]
    public interface ISummator
    {
        [OperationContract]
        int GetSumm(int a, int b);
        [OperationContract]
        int GetDif(int a, int b);
        [OperationContract]
        int GetMul(int a, int b);
        [OperationContract]
        int GetDiv(int a, int b);
    }
}
