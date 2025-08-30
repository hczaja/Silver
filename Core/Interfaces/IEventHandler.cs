namespace Core.Interfaces;

public interface IEventHandler<T>
{
    public void Handle(T @event);
}
