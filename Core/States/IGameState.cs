using Core.Events;
using Core.Interfaces;

namespace Core.States;

public interface IGameState : 
    IEventHandler<KeyboardEvent>, 
    IEventHandler<MouseEvent>,
    IEventHandler<SetUpCameraEvent>,
    IEventHandler<MoveCameraEvent>,
    IDrawable, 
    IUpdatetable
{ }
