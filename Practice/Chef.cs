using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chicken makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish()// change functionality in another class
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
