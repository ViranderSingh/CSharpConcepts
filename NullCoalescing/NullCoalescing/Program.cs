using System;

namespace NullCoalescing
{
    class Program
    {
        static void Main()
        {
            
            int? TicketsOnSale = null;

            //Without using Null Coalescing Operator
            //int AvailableTickets;

            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale;    //Casting Nullable to Non-Nullable
            //}

            //Using Null Coalescing Operator
            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);
        }
    }
}
