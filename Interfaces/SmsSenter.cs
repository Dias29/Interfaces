using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SmsSenter : ISender
    {
        public string PreapreMessage(string message)
        {
            throw new NotImplementedException();
        }

        public string PrepareMessage (string message)
        {
            return message.Trim();
        }

        public void SendMessage (string message)
        {
            //отпарвка сообщ
        }
    }
}
