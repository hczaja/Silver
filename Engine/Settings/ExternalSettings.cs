namespace Engine.Settings;

internal class ExternalSettings
{
    public string Title { get; } = "Silver";

    public bool EnableKeyRepeat { get; } = false;

    public int FPS { get; } = 30;

    public VideoStandard Standard { get; } = VideoStandard.WXGA;
}
