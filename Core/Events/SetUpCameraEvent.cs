namespace Core.Events;

public class SetUpCameraEvent
{
    public EventHandler<UpdateViewEventArgs> CameraEventHandler { get; set; }

    public SetUpCameraEvent(EventHandler<UpdateViewEventArgs> cameraEventHandler)
    {
        CameraEventHandler = cameraEventHandler;
    }
}
