using Core.Events;
using Core.Interfaces;
using SFML.Graphics;

namespace Engine;

internal class GameWindow
{
    private readonly GameCore _core;
    private readonly RenderWindow _window;
    private readonly ILogger _logger;

    public GameWindow(GameCore core)
    {
        _core = core;
        _logger = _core.Logger;

        _window = new RenderWindow(
            core.ExternalSettings.Standard.Mode,
            core.ExternalSettings.Title);

        _window.SetKeyRepeatEnabled(enable: core.ExternalSettings.EnableKeyRepeat);

        _window.Closed += (_, _) => Close();

        _window.KeyPressed += _core.KeyPressed;
        _window.KeyReleased += _core.KeyReleased;
        _window.MouseButtonPressed += _core.MouseButtonPressed;
        _window.MouseButtonReleased += _core.MouseButtonReleased;
        _window.MouseMoved += _core.MouseMoved;

        // Setup camera
        _core.UpdateViewEventHandler += (_, args) => UpdateView(args.View);
        _core.State.Handle(new SetUpCameraEvent(_core.UpdateViewEventHandler));
    }

    private void UpdateView(View view) => _window.SetView(view);

    public void Clear() => _window.Clear();

    public void DispatchEvents() => _window.DispatchEvents();

    public void Display() => _window.Display();

    public void Draw() => _core.Render(_window);

    public bool IsOpen() => _window.IsOpen;

    public void Update() => _core.Update();

    private void Close() => _window.Close();
}
