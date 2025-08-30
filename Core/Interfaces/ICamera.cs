using Core.Events;
using SFML.Graphics;

namespace Core.Interfaces;

public interface ICamera : IEventHandler<MouseEvent>
{
    public void Update();

    public View View { get; }
}
