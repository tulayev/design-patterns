namespace BridgePattern
{
    internal abstract class Shape
    {
        protected readonly IRenderer Renderer;

        protected Shape(IRenderer renderer) 
        {
            Renderer = renderer ?? throw new ArgumentNullException(paramName: nameof(renderer));
        }

        public abstract void Draw();
        public abstract void Resize(float factor);
    }
}
