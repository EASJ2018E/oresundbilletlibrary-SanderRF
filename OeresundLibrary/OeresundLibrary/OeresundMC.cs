using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace OeresundLibrary
{
    public class OeresundMC : MC
    {
        public override double Price()
        {
            return 210;
        }

        public override string Vehicle()
        {
            return "Øresund MC";
        }

        public override double DiscountPrice()
        {
            return 73;
        }
    }
}
