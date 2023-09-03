using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReference_TypeParameters
{
    public class MethodParameters
    {
        public static void ChangeName(ref Person person)
        {
            person.Name = "Unknown";
            person = new Person("Bob");
        }
        public static void ChangeHeight(Rectangle rectangle)
        {
            rectangle.Height = 500;
            Console.WriteLine($"rectangle height is : {rectangle.Height}");
        }
    }
}
