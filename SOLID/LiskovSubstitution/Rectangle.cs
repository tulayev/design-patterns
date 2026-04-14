namespace SOLID.LiskovSubstitution
{
    internal class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }

    internal class Square : Rectangle
    {
        public override int Width 
        { 
            set => base.Width = base.Height = value; 
        }

        public override int Height 
        { 
            set => base.Width = base.Height = value; 
        }
    }
}
