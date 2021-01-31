using System;
using System.Text;

namespace SpaghettiTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            // Печатаем баннер нужного размера на материале
            var printer = new Printer();
            printer.Start(120, "Canvas");
        }
    }
    
    public class Printer
    {
        /// <summary>
        ///  Запуск принтера
        /// </summary>
        public void Start( int size, string material )
        {
            //  печать информации о материале
            PrintInfo( material);

            // печать на разных носителях в зависимости от размера
            PrintSize(size);
        }
        
        static void PrintInfo( string material )
        {
            Console.WriteLine($"Awesome Print on {material}!");
        }

        static void PrintSize( int size)
        {
            string sizeCode;
            string sizeName;

            if (size < 10)
            {
                sizeCode = "M"; 
                sizeName = "small";
            }
               
            else if (size < 90)
            {
                sizeCode = "L"; 
                sizeName = "medium";
            }

            else
            {
                sizeCode = "XL"; 
                sizeName = "large";
            }
            
            Console.WriteLine($"Size {sizeCode}");
            Console.WriteLine($"printing on {sizeName} canvas");
        }
    }
}