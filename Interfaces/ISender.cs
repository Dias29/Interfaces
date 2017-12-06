using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISender:IPreparer
    {
        int Count { get; set; }
        void SendMessage(string message);
    }
}
