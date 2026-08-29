using UnityEngine;

public class EventInvoker : MonoBehaviour
{
    public GameEvent[] gameEvents;

    public void RaiseGameEvent(int i)
    {
        gameEvents[i].Raise();
    }

}
