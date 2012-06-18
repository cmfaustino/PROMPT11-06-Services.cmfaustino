using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; // adicionado

namespace ChatPartilhaWCF
{
    [ServiceContract]
    public interface IChatClientContract
    {
        [OperationContract(IsOneWay = true)]
        string ServerIdentification();
    }
}
