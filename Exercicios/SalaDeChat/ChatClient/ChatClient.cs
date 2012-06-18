using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.ServiceModel; // adicionado
using ChatPartilhaWCF;

namespace ChatClient
{
    internal class ChatClient : IChatClientContract
    {
        private readonly ChatUser _chatUser = new ChatUser();

        public ChatClient(string nome)
        {
            _chatUser.Nome = nome;
        }

        public string ServerIdentification()
        {
            return _chatUser.Nome;
        }
    }
}
