using static SFML.Window.Mouse;

namespace Core.Events;

public record MouseEvent
{
    public MouseEventType Type { get; init; }
    public float X { get; init; }
    public float Y { get; init; }
    public Button Button { get; init; }

    public MouseEvent(MouseEventType t, float x, float y, Button b)
        => (Type, X, Y, Button) = (t, x, y, b);
}
