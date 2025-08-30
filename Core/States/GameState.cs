using Core.Boards;
using Core.Camera;
using Core.Events;
using Core.Fields;
using Core.Interfaces;
using SFML.Graphics;

namespace Core.States;

public class GameState : IGameState
{
    public readonly ISettings _settings;
    public readonly ILogger _logger;
    public readonly ICamera _camera;

    public Board Board { get; }
    public EventHandler<UpdateViewEventArgs> ViewHandler { get; private set; }

    public GameState(
        ISettings settings,
        ILogger logger)
    {
        _settings = settings;
        _logger = logger;

        _camera = new CameraComponent(settings);

        Board = new Board(
            new FieldFactory(logger),
            BoardSize.Small);
    }

    public void DrawBy(RenderTarget target) => Board.DrawBy(target);

    public void Update()
    {

    }

    public void Handle(KeyboardEvent @event)
    {
    }

    public void Handle(MouseEvent @event)
    {
    }

    public void Handle(SetUpCameraEvent @event)
    {
        ViewHandler = @event.CameraEventHandler;
    }

    public void Handle(CameraMovedEvent @event)
    {
        ViewHandler.Invoke(this, new UpdateViewEventArgs() { View = _camera.View });
    }
}
