using System;
using System.Runtime.CompilerServices;
using static System.Console;

namespace MarshallsRevenue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Jake Magri | SID: 801193292

            WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM"); // company motto
            WriteLine("M  Make your vision your view.  M");
            WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");

            string interiorMurals_string = "";
            int interiorMurals = 0;

            Write("Enter number of interior murals scheduled >> ");
            interiorMurals_string = ReadLine();
            interiorMurals = Convert.ToInt32(interiorMurals_string); // requests user for input and converts string to integer to be used in function

            double interiorMurals_price = 500;

            string currency_Format_interM_price = "C2";

            string interiorMurals_Format_currency_price = interiorMurals_price.ToString(currency_Format_interM_price); // converting interiorMurals_price to currency format

            double interiorMurals_er = interiorMurals_price * interiorMurals; // total price function interiorMurals

            string currency_Format_interM = "C2";

            string interiorMurals_Format_currency_total = interiorMurals_er.ToString(currency_Format_interM); // converting interiorMurals total price to currency format


            string exteriorMurals_string = "";
            int exteriorMurals = 0;

            Write("Enter number of exterior murals scheduled >> ");
            exteriorMurals_string = ReadLine();
            exteriorMurals = Convert.ToInt32(exteriorMurals_string); // requests user for input and converts string to integer to be used in function 

            double exteriorMurals_price = 750;

            string currency_Format_exterM_price = "C2";

            string exteriorMurals_Format_currency_price = exteriorMurals_price.ToString(currency_Format_exterM_price); // converting exteriorMurals_price to currency format

            double exteriorMurals_er = exteriorMurals_price * exteriorMurals; // total price function for exteriorMurals

            string currency_Format_exterM = "C2";

            string exteriorMurals_Format_currency_total = exteriorMurals_er.ToString(currency_Format_exterM); // converting exteriorMurals total price to currency format


            WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", interiorMurals, interiorMurals_Format_currency_price, interiorMurals_Format_currency_total);
            WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", exteriorMurals, exteriorMurals_Format_currency_price, exteriorMurals_Format_currency_total);

            double totalRevenue = interiorMurals_er + exteriorMurals_er; // total revenue function

            string currency_Format_tR = "C2";

            string totalRevenue_Format_currency = totalRevenue.ToString(currency_Format_tR); // converting totalRevenue to currency format

            WriteLine("Total revenue expected is {0}", totalRevenue_Format_currency);

            bool is_iM_more;

            is_iM_more = interiorMurals > exteriorMurals;

            WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", is_iM_more); // return ture/False based on criteria

        }
    }
}



// string.Format("{0:n}", variable
// faster way to change format
//try int.PryParse and research outside of class
