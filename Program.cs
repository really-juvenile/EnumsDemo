using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnumsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enums are unchangeable / read only variables (griup of constants)

            Months var = Months.jan;
            Console.WriteLine(var);
            int month = (int)Months.apr; //explicit conversion neccesary to get value fromitem
            int june = (int)Months.jun;
            Console.WriteLine(month);
            Console.WriteLine(june);


        }

        enum Months
        {
            //default value as 1
            jan,
            feb,
            mar, apr, may,
           jun = 81 //also we can set value
        }




        
    }
}
