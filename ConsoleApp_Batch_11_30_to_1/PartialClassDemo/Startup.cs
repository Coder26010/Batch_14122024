using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Batch_11_30_to_1.PartialClassDemo
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            Reservation reservation = new Reservation();

            reservation.Booking1();
            reservation.Cancel2();
        }
    }
}
