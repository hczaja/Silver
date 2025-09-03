using Core.Events;
using Core.Interfaces;
using SFML.Graphics;

namespace Core.UI;

public class UIContainer : IDrawable, IEventHandler<MouseEvent>
{
    private readonly ILogger _logger;
    private readonly ISettings _settings;

    public View View { get; }

    private PlayerMarkerPanel playerMarkerPanel;
    private PlayerStatsBar playerStatsBar;
    // PlayerMarkerPanel
    // TaskQueuePanel
    // ConsolePanel
    // ResourcesBar
    // Stats
    // Options
    // Selection
    // Details

    public UIContainer(ILogger logger, ISettings settings)
    {
        _logger = logger;
        _settings = settings;

        playerMarkerPanel = new PlayerMarkerPanel(settings);
        playerStatsBar = new PlayerStatsBar(settings, playerMarkerPanel);

        View = new View(
            new FloatRect(
                0f,
                0f,
                settings.WindowWidth,
                settings.WindowHeight
            ));
    }

    public void DrawBy(RenderTarget render)
    {
        playerMarkerPanel.DrawBy(render);
        playerStatsBar.DrawBy(render);
    }

    public void Handle(MouseEvent @event)
    {
        
    }
}

