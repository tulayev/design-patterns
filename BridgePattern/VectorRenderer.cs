namespace BridgePattern
{
    internal class VectorRenderer : IRenderer
    {
        public void RenderCircle(float raduis)
        {
            Console.WriteLine($"Drawing a circle with raduis {raduis}");
        }
    }
}
