using SFML.Graphics;

namespace Core.Events;

public record UpdateViewEventArgs
{
    public View View { get; set; }
}
