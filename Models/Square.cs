using BridgePattern.Interfaces;

namespace BridgePattern.Models;

/// <summary>
/// Concrete Abstraction: Square
/// </summary>
public class Square : Shape
{
    private int side;

    public Square(IRenderer renderer, int side) : base(renderer)
    {
        this.side = side;
    }

    public override void Draw()
    {
        renderer.RenderSquare(side);
    }
}