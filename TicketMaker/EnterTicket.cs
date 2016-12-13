using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMaker
{
    public class EnterTicket : Ticket
    {
        public EnterTicket(Image aImage, int aXMove, int aYMove, int aTicketNum)
            : base(aImage, aXMove, aYMove, aTicketNum)
        {
        }

        public override Image RenderNumber(Font aFont)
        {
            throw new NotImplementedException();
        }
    }
}
