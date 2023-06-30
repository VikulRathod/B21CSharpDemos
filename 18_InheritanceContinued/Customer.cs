using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InheritanceContinued
{
    public class Customer
    {
        public int TicketAmount = 100;
        public string CinemaHallName = "City Pride";

        public int GetTicketAmount()
        {
            return TicketAmount;
        }
        public void AllShows()
        {
            Console.WriteLine("** ALL TODAYS SHOWS **");
        }

        public void PrintTicket()
        {
            Console.WriteLine($"** Ticket Printed " +
                $"{CinemaHallName} : {TicketAmount}**");
        }
    }

    public class SilverCustomer : Customer
    {
        public SilverCustomer()
        {
            TicketAmount = 100;
        }

        //public int TicketAmount = 100;
        //public string CinemaHallName = "City Pride";
        // public string CustomerType;

        //public int GetTicketAmount()
        //{
        //    return TicketAmount;
        //}

        //public int GetTicketAmount(string customerType)
        //{
        //    if (customerType == "gold")
        //    {
        //        CustomerType = "GOLD";
        //        TicketAmount += 100;
        //    }
        //    else
        //    {
        //        CustomerType = "SILVER";
        //    }
        //    return TicketAmount;
        //}

        //public void AllShows()
        //{
        //    Console.WriteLine("** ALL TODAYS SHOWS **");
        //}

        public void PrintTicket()
        {
            Console.WriteLine($"** Ticket Printed " +
                $"{CinemaHallName} : {TicketAmount} : SILVER TICKET**");
        }
    }

    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {
            TicketAmount = 200;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"** Ticket Printed " +
                $"{CinemaHallName} : {TicketAmount} : GOLD TICKET **");
        }
    }

    public class PlatinumCustomer : Customer
    {
        public PlatinumCustomer()
        {
            TicketAmount = 450;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket Printed: {CinemaHallName} : {TicketAmount} : PLATINUM TICKET");
        }
    }
}
