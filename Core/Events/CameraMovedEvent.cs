using SFML.System;

namespace Core.Events;

public class CameraMovedEvent
{
    public Vector2f MoveDirection { get; set; }

    public CameraMovedEvent(Vector2f moveDirection)
    {
        MoveDirection = moveDirection;
    }
}
