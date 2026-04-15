namespace BridgePattern
{
    internal class RasterRenderer : IRenderer
    {
        public void RenderCircle(float raduis)
        {
            Console.WriteLine($"Drawing pixels for circle with raduis {raduis}");
        }
    }
}
