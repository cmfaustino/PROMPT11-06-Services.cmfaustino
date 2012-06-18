using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel; // adicionado
using ChatPartilhaWCF;

namespace ChatServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class ChatServer : IChatServerContract
    {
        private readonly Dictionary<string,IChatClientContract> _listaDeClientes = new Dictionary<string, IChatClientContract>();

        private bool IsValidClient(out IChatClientContract cb, out string cbid)
        {
            var ctx = OperationContext.Current;
            cb = ctx.GetCallbackChannel<IChatClientContract>();
            cbid = cb.ServerIdentification();
            return (_listaDeClientes.ContainsKey(cbid));
        }

        public void ClientEnter()
        {
            IChatClientContract cb;
            string cbid;
            if (IsValidClient(out cb, out cbid)) return;
            _listaDeClientes.Add(cbid, cb);
            Console.WriteLine("{0} entrou na sala de chat.", cbid);
        }

        public void ClientMessage(string mensagem)
        {
            IChatClientContract cb;
            string cbid;
            if (!IsValidClient(out cb, out cbid)) return;
            throw new NotImplementedException();
        }

        public void ClientExit()
        {
            IChatClientContract cb;
            string cbid;
            if (!IsValidClient(out cb, out cbid)) return;
            _listaDeClientes.Remove(cbid);
            Console.WriteLine("{0} saiu da sala de chat.", cbid);
        }
    }
}
