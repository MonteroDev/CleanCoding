namespace CleanCoding.ValidDomain.LSP
{
    internal class Square : IShape
    {
        internal int SideLength { get; set; }
        public int Area => SideLength * SideLength;
    }
}
