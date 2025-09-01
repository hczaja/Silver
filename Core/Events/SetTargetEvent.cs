using Core.Interfaces;

namespace Core.Events;

public record SetTargetEvent
{
    public ITargetable Target { get; init; }

    public SetTargetEvent(ITargetable target)
        => Target = target;
}
