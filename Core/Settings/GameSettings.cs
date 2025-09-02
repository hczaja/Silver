using Core.Interfaces;

namespace Core.Settings;

public class GameSettings : ISettings
{
    public uint WindowWidth { get; init; }

    public uint WindowHeight { get; init; }
}
