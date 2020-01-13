using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.InvalidDomain.LSP
{
    internal class Rectangle
    {
        internal virtual int Width { get; set; }
        internal virtual int Height { get; set; }
        internal int Area => Width * Height;
    }
}
