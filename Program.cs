using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        public int area(int r,float a)
        {
            float circle = r * r * a;
            return (Convert.ToInt32 (circle));
        }
        public int area(int l , int w )
        {
            int rect = l * w ;
            return rect;




        }
    }
    class program1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int s = p.area(4,3.14f);
            Console.WriteLine("the area of circle is : " + s);
            int s1 = p.area(10 , 20);
            Console.WriteLine("the area of rectangle is  : " + s1);




        }
    }
}


