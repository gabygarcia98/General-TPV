using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD
{
    public partial class TicketLin
    {
        /*public TicketLin(bool _del)
        {
            del = _del;
        }*/

        public decimal Total { 
            get { return (decimal)(preu * quantitat); } 
            
        }

    }
}
