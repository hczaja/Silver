using Core.Interfaces;
using SFML.Graphics;

namespace Core.Camera;

public class CameraComponent : ICamera
{
    public View View { get; }

    public CameraComponent(ISettings settings)
    {
        View = new View(
            new FloatRect(
                0,
                0,
                settings.WindowWidth,
                settings.WindowHeight
            ));
    }
}
