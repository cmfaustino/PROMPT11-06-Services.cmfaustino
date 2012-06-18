using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; // adicionado

namespace ChatPartilhaWCF
{
    [ServiceContract]
    public interface IChatServerContract
    {
        [OperationContract(IsOneWay = true)]
        void ClientEnter();

        [OperationContract(IsOneWay = true)]
        void ClientMessage(string mensagem);

        [OperationContract(IsOneWay = true)]
        void ClientExit();
    }
}
