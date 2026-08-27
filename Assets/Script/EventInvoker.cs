using UnityEngine;

public class EventInvoker : MonoBehaviour
{
    public GameEvent onGameLoadEvent;

    public void RaiseLoadGameEvent()
    {
        onGameLoadEvent.Raise();
    }

}
