using SFML.Graphics;
using Silver.Settings;

namespace Silver;

internal class GameWindow : IDisposable
{
    private readonly RenderWindow _window;

    public GameWindow()
    {
        _window = new RenderWindow(
            VideoStandard.WXGA.Mode,
            GameSettings.Title);

        _window.SetKeyRepeatEnabled(enable: GameSettings.EnableKeyRepeat);

        _window.Closed += (_, _) => Close();
    }

    public void Clear() => _window.Clear();

    public void DispatchEvents() => _window.DispatchEvents();

    public void Display() => _window.Display();

    public void Draw() { } // _core.Render(_window);

    public bool IsOpen() => _window.IsOpen;

    public void Update() { } // => _core.Update();


    public void Dispose()
    {
        Close();
    }

    private void Close()
    {
        _window.Close();
        _window.Dispose();
    }
}
