using SFML.Window;

namespace Silver.Settings;

internal class VideoStandard
{
    public VideoMode Mode { get; }

    private VideoStandard(VideoMode mode) => Mode = mode;

    public static VideoStandard DesktopMode = new(VideoMode.DesktopMode);
    public static VideoStandard WXGA = new(new VideoMode(1280, 720));
    public static VideoStandard FHD = new(new VideoMode(1920, 1200));
}
