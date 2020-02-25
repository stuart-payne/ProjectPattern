using System.Collections.Generic;

public class Event : IObservable {
    
    List<IObserver> _observers;
    
    public Event() {
        _observers = new List<IObserver>();
    }
    
    public void Subscribe(IObserver observer) {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer) {
        _observers.Remove(observer);
    }

    public void Notify() {
        foreach(IObserver observer in _observers) {
            observer.Receive(this);
        }
    }
}
