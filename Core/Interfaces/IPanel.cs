using Core.Events;

namespace Core.Interfaces
{
    public interface IPanel : IDrawable, IEventHandler<MouseEvent>
    {
    }
}
