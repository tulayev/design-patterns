namespace BridgePattern
{
    internal class Circle : Shape
    {
        private float _radius;

        public Circle(IRenderer renderer, float raduis) : base(renderer) 
        {
            _radius = raduis;
        }

        public override void Draw()
        {
            Renderer.RenderCircle(_radius);
        }

        public override void Resize(float factor)
        {
            _radius *= factor;
        }
    }
}
