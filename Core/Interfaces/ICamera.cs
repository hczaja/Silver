using Core.Events;
using SFML.Graphics;
using SFML.System;

namespace Core.Interfaces;

public interface ICamera : IEventHandler<MouseEvent>
{
    public void Update();

    public Vector2f CameraOffset { get; }
    public View View { get; }
}
