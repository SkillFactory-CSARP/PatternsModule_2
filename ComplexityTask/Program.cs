using System;
using System.Linq;
using System.Text;

namespace ComplexityTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine(Validate(0, null));
        }

        /// <summary>
        /// Проверяет, содержит ли числовой ввод положительные числа
        /// </summary>
        public static bool Validate( int? myNumber = null, int [] myNumbers = null )
        {
            if (myNumbers != null)
            {
                foreach (var elem in myNumbers)
                {
                    if (elem > 0)
                        return true;
                }
            }
            else if (myNumber != null)
            {
                if(myNumber > 0)
                    return true;
            }

            return false;
        }


        /// <summary>
        ///  Проверяем число
        /// </summary>
        public static bool ValidateNumber(int num)
        {
            if (num > 0)
                return true;

            return false;
        }
        
        /// <summary>
        /// Проверяем массив
        /// </summary>
        public static bool ValidateArray(int [] nums)
        {
            if (nums.Any(n => n > 0))
                return true;

            return false;
        }
        
    }
}