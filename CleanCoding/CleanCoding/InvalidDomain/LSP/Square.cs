using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.InvalidDomain.LSP
{
    internal class Square : Rectangle
    {
        private int _height;
        private int _width;
        internal override int Height
        {
            get => _height;
            set
            {
                _height = value;
                _width = value;
            }
        }
        internal override int Width
        {
            get => _width;
            set
            {
                _width = value;
                _height = value;
            }
        }

    }
}
