using SFML.Window;

namespace Core.Interfaces;

public interface IKeyboardHandler
{
    void KeyPressed(object? sender, KeyEventArgs e);
    void KeyReleased(object? sender, KeyEventArgs e);
}
