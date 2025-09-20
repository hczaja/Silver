using Core.Interfaces;

namespace Core.Settings;

public class GameSettings : ISettings
{
    public uint WindowWidth { get; init; }

    public uint WindowHeight { get; init; }

    public uint MinimumWidthUnit => WindowWidth / 16;

    public uint MinimumHeightUnit => WindowHeight / 16;

    public uint HorizontalOffset => MinimumWidthUnit / 8;

    public uint VerticalOffset => MinimumHeightUnit / 8;
}
