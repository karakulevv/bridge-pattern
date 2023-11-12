using BridgePattern.Interfaces;

namespace BridgePattern.Models;

/// <summary>
/// Abstraction: Shape
/// </summary>
public abstract class Shape
{
    protected IRenderer renderer;

    protected Shape(IRenderer renderer)
    {
        this.renderer = renderer;
    }

    public abstract void Draw();
}