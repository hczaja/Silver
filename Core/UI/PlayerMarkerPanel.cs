using Core.Events;
using Core.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Core.UI;

public class PlayerMarkerPanel : IPanel
{
    private readonly ISettings _settings;

    private RectangleShape shape;

    public PlayerMarkerPanel(ISettings settings)
    {
        _settings = settings;

        shape = new RectangleShape()
        {
            Position = Position,
            Size = Size,
            FillColor = Color.White,
            OutlineColor = Color.Red,
            OutlineThickness = 1
        };
    }

    public Vector2f Position => new Vector2f(_settings.HorizontalOffset, 0f);
    
    public Vector2f Size => new Vector2f(_settings.MinimumWidthUnit, _settings.MinimumHeightUnit * 2f);

    public void DrawBy(RenderTarget render)
    {
        render.Draw(shape);
    }

    public void Handle(MouseEvent @event)
    {
        throw new NotImplementedException();
    }
}
