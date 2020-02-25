using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager
{
    private Dictionary<string, IObservable> _eventTable;

    public EventManager() {
        _eventTable = new Dictionary<string, IObservable>();
    }

    public IObservable GetEvent(string eventKey) {
        return _eventTable[eventKey];
    }

    public void Register(string eventKey, IObservable eventObj) {
        _eventTable.Add(eventKey, eventObj);
    }

    public void Remove(string eventKey) {
        _eventTable.Remove(eventKey);
    }
}
