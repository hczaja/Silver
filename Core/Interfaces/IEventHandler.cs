namespace Core.Interfaces;

public interface IEventHandler<T>
{
    public void Handler(T @event);
}
