using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMaker
{
    public abstract class Ticket
    {
        Image mImage;

        int mXMove;
        int mYMove;

        int mTicketNum;

        /// <summary>
        /// Naklonuje obrázek a vytvoří z něj ticket
        /// </summary>
        /// <param name="aImage">OBrázek (pozadí)</param>
        /// <param name="aXMove">X posuunu čísla na lístku</param>
        /// <param name="aYMove">Y posuunu čísla na lístku</param>
        /// <param name="aTicketNum">Číslo lístku</param>
        public Ticket(Image aImage, int aXMove, int aYMove, int aTicketNum)
        {
            mImage = (System.Drawing.Image) aImage.Clone();

            mXMove = aXMove;
            mYMove = aYMove;

            mTicketNum = aTicketNum;
        }


        public abstract Image RenderNumber(Font aFont);
        

    }
}
