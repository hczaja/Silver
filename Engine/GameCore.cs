using Core.Events;
using Core.Interfaces;
using Core.Loggers;
using Core.Settings;
using Core.States;
using Engine.Settings;
using SFML.Graphics;
using SFML.Window;

namespace Engine;

internal class GameCore : IKeyboardHandler, IMouseHandler
{
    public IGameState State { get; private set; }
    public ExternalSettings ExternalSettings { get; private set; }
    public ILogger Logger { get; private set; }

    public EventHandler<UpdateViewEventArgs> UpdateViewEventHandler { get; set; }

    public GameCore()
    {
        ExternalSettings = new ExternalSettings();
        Logger = new ConsoleLogger();

        ISettings gameSettings = new GameSettings()
        {
            WindowHeight = ExternalSettings.Standard.Mode.Height,
            WindowWidth = ExternalSettings.Standard.Mode.Width,
        };

        State = new GameState(gameSettings, Logger);
    }

    public void KeyPressed(object? sender, KeyEventArgs e) 
        => State.Handle(new KeyboardEvent(KeyboardEventType.KeyPressed, e.Code));

    public void KeyReleased(object? sender, KeyEventArgs e)
        => State.Handle(new KeyboardEvent(KeyboardEventType.KeyReleased, e.Code));

    public void MouseButtonPressed(object? sender, MouseButtonEventArgs e)
        => State.Handle(new MouseEvent(MouseEventType.ButtonPressed, e.X, e.Y, e.Button));

    public void MouseButtonReleased(object? sender, MouseButtonEventArgs e)
        => State.Handle(new MouseEvent(MouseEventType.ButtonReleased, e.X, e.Y, e.Button));

    public void MouseMoved(object? sender, MouseMoveEventArgs e)
        => State.Handle(new MouseEvent(MouseEventType.MouseMoved, e.X, e.Y, default));

    internal void Render(RenderTarget target) => State.DrawBy(target);

    internal void Update() => State.Update();
}
