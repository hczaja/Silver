using Core.Events;
using SFML.System;

namespace Core.Interfaces
{
    public interface IPanel : IDrawable, IEventHandler<MouseEvent>
    {
        public Vector2f Position { get; }
        public Vector2f Size { get; }
    }
}
