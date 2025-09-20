using Core.Events;
using Core.Interfaces;
using SFML.Graphics;
using SFML.System;

namespace Core.UI;

public class TaskQueuePanel
{
    private readonly ISettings _settings;

    private RectangleShape shape;

    public TaskQueuePanel(ISettings settings, IPanel referencePanel)
    {
        _settings = settings;

        Position = referencePanel.Position + new Vector2f(0f, referencePanel.Size.Y + settings.VerticalOffset * 2);

        shape = new RectangleShape()
        {
            Position = Position,
            Size = Size,
            FillColor = Color.White,
            OutlineColor = Color.Red,
            OutlineThickness = 1
        };
    }

    public Vector2f Position { get; }

    public Vector2f Size => new Vector2f(_settings.MinimumWidthUnit, _settings.MinimumHeightUnit * 8f);

    public void DrawBy(RenderTarget render)
    {
        render.Draw(shape);
    }

    public void Handle(MouseEvent @event)
    {
        throw new NotImplementedException();
    }

}
