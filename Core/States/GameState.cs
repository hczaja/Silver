using Core.Boards;
using Core.Camera;
using Core.Events;
using Core.Fields;
using Core.Interfaces;
using Core.Tools;
using Core.UI;
using SFML.Graphics;

namespace Core.States;

public class GameState : IGameState
{
    public readonly ISettings _settings;
    public readonly ILogger _logger;

    public readonly ICamera _camera;

    public Board Board { get; }
    public UIContainer UI { get; }

    public EventHandler<UpdateViewEventArgs> ViewHandler { get; private set; }

    public GameState(
        ISettings settings,
        ILogger logger)
    {
        _settings = settings;
        _logger = logger;

        _camera = new CameraComponent(logger, settings);

        Board = new Board(
            new FieldFactory(logger),
            BoardSize.Small,
            _camera,
            _logger);

        UI = new UIContainer(
            _logger,
            _settings);
    }

    public void DrawBy(RenderTarget render)
    {
        render.SetView(_camera.View);
        Board.DrawBy(render);

        render.SetView(UI.View);
        UI.DrawBy(render);
    }

    public void Update()
    {
        _camera.Update();
    }

    public void Handle(KeyboardEvent @event)
    {
        _logger.LogTrace($"{nameof(KeyboardEvent)}: {@event}.");
    }

    public void Handle(MouseEvent @event)
    {
        _logger.LogTrace($"{nameof(MouseEvent)}: {@event}.");

        _camera.Handle(@event);

        Board.Handle(@event);
        UI.Handle(@event);
    }
}
