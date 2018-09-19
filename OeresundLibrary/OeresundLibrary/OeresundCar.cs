using System;
using TicketLibrary;

namespace OeresundLibrary
{
    public class OeresundCar : Car
    {
        public override double Price()
        {
            return 410;
        }

        public override string Vehicle()
        {
            return "Øresund Bil";
        }

        public override double DiscountPrice()
        {
            return 161;
        }
    }
}
