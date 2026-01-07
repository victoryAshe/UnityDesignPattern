using UnityEngine.Events;
using System.Collections.Generic;

public enum RaceEventType 
{
    // Dummy
}

public class RaceEventBus
{
    private static readonly IDictionary<RaceEventType, UnityEvent> Events = 
        new Dictionary<RaceEventType, UnityEvent>();

    public static void Subscribe(RaceEventType eventType, UnityAction listener)
    {
        UnityEvent thisEvent;
        Events.TryGetValue(eventType, out thisEvent);
        if (thisEvent == null) thisEvent = new UnityEvent();

        thisEvent.AddListener(listener);
        Events.Add(eventType, thisEvent);
    }

    public static void UnSubscripbe(RaceEventType eventType, UnityAction listener)
    {
        UnityEvent thisEvent;
        if (Events.TryGetValue(eventType, out thisEvent))
        {
            thisEvent.RemoveListener(listener);
        }
    }

    public static void Publish(RaceEventType eventType)
    {
        UnityEvent thisEvent;
        if (Events.TryGetValue(eventType, out thisEvent))
        {
            thisEvent.Invoke();
        }
    }
}
