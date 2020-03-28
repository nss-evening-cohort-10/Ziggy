using System;

namespace Ziggy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quantum Leap initiative!");

            Console.WriteLine("1. Take your next leap");
            //menu to select a specific leaper?

            /*
             * Take your next leap
             *
             * Location: Memphis, TN
             * Date:     July 3, 1954
             * Leaper:   Sam Beckett
             * Host:     Elvis Presley
            */

            var elvis = new Host();

            var elvisFirstSingle = new HistoricalEvent();


            var budget = new Budget();

            // sam to leap into elvis on the date of his first single
            //var leap = new Leap
            //{
            //    Event = home,
            //    Host = elvis,
            //    Leaper = sam
            //};

            // sam is only leaper
            var sam = new Leaper();
            sam.CurrentDate = DateTime.Today.AddDays(100);

            elvis.CurrentLeaper = sam;
            budget.AuthorizeLeap(sam, elvisFirstSingle.DateInHistory);

        }
    }
}
