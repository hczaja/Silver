namespace Core.Events;

public record SetUpCameraEvent
{
    public EventHandler<UpdateViewEventArgs> CameraEventHandler { get; set; }

    public SetUpCameraEvent(EventHandler<UpdateViewEventArgs> cameraEventHandler)
    {
        CameraEventHandler = cameraEventHandler;
    }
}
