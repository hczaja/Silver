using static SFML.Window.Keyboard;

namespace Core.Events;

public record KeyboardEvent
{
    public KeyboardEventType Type { get; init; }
    public Key Key { get; init; }

    public KeyboardEvent(KeyboardEventType t, Key k)
        => (Type, Key) = (t, k);
}
