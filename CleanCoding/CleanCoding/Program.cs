using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCoding.ValidDomain.LSP;
using Rectangle = CleanCoding.InvalidDomain.LSP.Rectangle;
using Square = CleanCoding.InvalidDomain.LSP.Square;

namespace CleanCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Violation of LSP
            Rectangle rect = new Rectangle
            {
                Height = 10,
                Width = 20
            };
            Console.WriteLine(rect.Area);
            //prints 200
            rect = new Square
            {
                Height = 10,
                Width = 20
            };
            Console.WriteLine(rect.Area);
            //prints 400


            //Correct way to implement LSP
            IShape correctRect = new ValidDomain.LSP.Rectangle()
            {
                Height = 10,
                Width = 20
            };
            Console.WriteLine(correctRect.Area);
            //200

            IShape correctSquare = new ValidDomain.LSP.Square()
            {
                SideLength = 10
            };
            Console.WriteLine(correctSquare.Area);
            //100
        }
    }
}
