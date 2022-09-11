using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Can make Pasta");
        }

        public override void MakeSpecialDish()// change functionality in another class
        {
            Console.WriteLine("The Chef makes Pizza");
        }
    }
}
