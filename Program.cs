using BridgePattern.Models;

namespace BridgePattern;

static class Program
{
    public static void Main(string[] args)
    {
        // Drawing a circle using vector rendering
        Shape circle = new Circle(new VectorRenderer(), 5);
        circle.Draw();

        // Drawing a square using raster rendering
        Shape square = new Square(new RasterRenderer(), 4);
        square.Draw();
    }
}