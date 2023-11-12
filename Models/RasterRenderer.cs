using BridgePattern.Interfaces;

namespace BridgePattern.Models;

/// <summary>
/// Concrete Implementor: RasterRenderer
/// </summary>
public class RasterRenderer : IRenderer
{
    public void RenderCircle(int radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} using raster rendering.");
    }

    public void RenderSquare(int side)
    {
        Console.WriteLine($"Drawing a square with side {side} using raster rendering.");
    }
}