using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsExamples
{
    internal class Client
    {
        protected int ClientID;
        protected string ClientName;

        public Client() { }
        public  Client(int ClientID, string ClientName)
        {
            this.ClientID = ClientID;
            this.ClientName = ClientName;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        
    }
}
