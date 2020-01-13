namespace CleanCoding.ValidDomain.LSP
{
    internal class Rectangle :IShape
    {
        internal virtual int Width { get; set; }
        internal virtual int Height { get; set; }
        public int Area => Width * Height;
    }
}
