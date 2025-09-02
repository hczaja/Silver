using Core.Events;
using Core.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Core.UI;

public class PlayerStatsBar : IPanel
{
    private RectangleShape shape;

    public PlayerStatsBar(ISettings settings)
    {
        shape = new RectangleShape(
            new Vector2f(512f, 64f));
        shape.Position = new Vector2f(128f, 128f);
        shape.FillColor = Color.White;
    }

    public void DrawBy(RenderTarget render)
    {
        render.Draw(shape);
    }

    public void Handle(MouseEvent @event)
    {

    }
}
