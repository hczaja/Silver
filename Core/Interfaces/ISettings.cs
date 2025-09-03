using System.Formats.Asn1;

namespace Core.Interfaces;

public interface ISettings
{
    uint WindowWidth { get; }
    uint WindowHeight { get; }

    uint MinimumWidthUnit { get; }
    uint MinimumHeightUnit { get; }

    uint HorizontalOffset { get; }
}
