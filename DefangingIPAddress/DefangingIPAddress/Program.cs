using System;

namespace DefangingIPAddress
{
    //    Given a valid(IPv4) IP address, return a defanged version of that IP address.

    //A defanged IP address replaces every period "." with "[.]".



    //Example 1:

    //Input: address = "1.1.1.1"
    //Output: "1[.]1[.]1[.]1"
    //Example 2:

    //Input: address = "255.100.50.0"
    //Output: "255[.]100[.]50[.]0"


    //Constraints:

    //The given address is a valid IPv4 address.

    class Program
    {
        public static string DefangIPaddr(string address)
        {
            //var splittedList = address.Split('.');
            //address = "";
            //var count = 0;
            //foreach (var item in splittedList)
            //{
            //    address += item;
            //    if (count == splittedList.Length - 1)
            //        break;
            //    address += "[.]";
            //    count++;
            //}
            //return address;
            return address.Replace(".","[.]");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
        }
    }
}
