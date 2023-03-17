using Caffetteria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffetteria.Interfaces
{
    public interface IPrintMessage
    {
        public void printLastMessage(ICoffee coffee);
    }
}
