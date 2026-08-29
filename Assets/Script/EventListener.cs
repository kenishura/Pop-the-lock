using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent[] Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        foreach(var e in Event)
        {
            e.Register(this);
        }
    }

    private void OnDisable()
    {
        foreach (var e in Event)
        {
            e.Unregister(this);
        }
    }

    public void OnEventRaised() { Response.Invoke(); }

}
