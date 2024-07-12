using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_practist
{
    public class symtom
    {
        int side_value = 0;
        int square_area = 0;

        public void Input()
        {
            Console.WriteLine("Enter value of the side: ");
            side_value = Convert.ToInt32(Console.ReadLine());
        }

        public void Eqat()
        {
            square_area = side_value*side_value;
        }
        public void Output()
        {
            Console.WriteLine(square_area);
        }
    }
}
