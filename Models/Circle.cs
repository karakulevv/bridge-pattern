using BridgePattern.Interfaces;

namespace BridgePattern.Models;

/// <summary>
/// Concrete Abstraction: Circle
/// </summary>
public class Circle : Shape
{
    private int radius;

    public Circle(IRenderer renderer, int radius) : base(renderer)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        renderer.RenderCircle(radius);
    }
}