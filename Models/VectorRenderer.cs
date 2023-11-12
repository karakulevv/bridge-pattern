using BridgePattern.Interfaces;

namespace BridgePattern.Models;

/// <summary>
/// Concrete Implementor: VectorRenderer
/// </summary>
public class VectorRenderer : IRenderer
{
    public void RenderCircle(int radius)
    {
        Console.WriteLine($"Drawing a circle of radius {radius} using vector rendering.");
    }

    public void RenderSquare(int side)
    {
        Console.WriteLine($"Drawing a square with side {side} using vector rendering.");
    }
}