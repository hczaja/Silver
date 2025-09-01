using Core.Events;
using Core.Extensions;
using Core.Interfaces;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace Core.Camera;

public class CameraComponent : ICamera
{
    private readonly IEventHandler<MoveCameraEvent> _cameraHolder;
    private readonly ILogger _logger;
    private readonly ISettings _settings;

    public Vector2f CameraOffset { get; private set; }
    public Vector2f MousePosition { get; private set; }
    public View View { get; }

    private bool isDragging = false;
    private float cameraSpeed = 8f;

    public CameraComponent(ILogger logger, ISettings settings, IEventHandler<MoveCameraEvent> cameraHolder)
    {
        _logger = logger;
        _settings = settings;

        _cameraHolder = cameraHolder;

        View = new View(
            new FloatRect(
                0,
                0,
                settings.WindowWidth,
                settings.WindowHeight
            ));
    }

    public void Update()
    {
        if (isDragging)
        {
            Vector2f moveOffset = GetMoveOffset(MousePosition);
            CameraOffset += moveOffset;

            _logger.LogInfo($"Moving the camera by {moveOffset}.");
            View.Move(moveOffset);

            _cameraHolder.Handle(new MoveCameraEvent());
        }
    }

    public void StartDragging()
    {
        isDragging = true;
    }

    public void StopDragging()
    {
        isDragging = false;
    }

    public void Handle(MouseEvent @event)
    {
        if (!isDragging)
        {
            if (@event.Button == Mouse.Button.Right
                && @event.Type == MouseEventType.ButtonPressed)
            {
                _logger.LogInfo("Dragging the camera.");

                MousePosition = new Vector2f(@event.X, @event.Y);
                StartDragging();
            }

            return;
        }

        if (@event.Button == Mouse.Button.Right
            && @event.Type == MouseEventType.ButtonReleased)
        {
            _logger.LogInfo("Dropping the camera.");

            StopDragging();
        }

        MousePosition = new Vector2f(@event.X, @event.Y);
    }

    private Vector2f GetMoveOffset(Vector2f mousePosition)
    {
        Vector2f center = new Vector2f(_settings.WindowWidth / 2f, _settings.WindowHeight / 2f);
        return (mousePosition - View.Center).Normalized() * cameraSpeed;
    }
}
