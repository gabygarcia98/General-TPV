using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD
{
    public partial class Ticket
    {


        /*public Ticket(bool _del)
        {
            del = _del;
        }*/

        public string txtNumTicket 
        {
            get 
            {
                return "Num ticket: " + numeroticket;

            
            }
        }

        public decimal totalTicket
        {
            get
            {
                decimal suma = 0;
                suma = (from y in this.TicketLin where y.del == false select y.Total).Sum();
            
                return suma;
                
            }
        }


    }
}
