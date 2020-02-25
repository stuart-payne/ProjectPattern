using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, IObserver
{
    // Start is called before the first frame update
    static public GameManager instance;
    public EventManager Events = new EventManager();
    private PauseEvent _pauseEvent;

    void Awake() {
        if(!instance){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this);
        }
    }

    void Start() {
        _pauseEvent = (PauseEvent)Events.GetEvent("Pause");
        _pauseEvent.Subscribe(this);
    }

    void PauseSwitch(bool isPaused) {
        if(isPaused)
            Time.timeScale = 0.0f;
        else
            Time.timeScale = 1.0f;
    }

    public void Receive(IObservable subject) {
        if(subject == _pauseEvent) {
            PauseSwitch(_pauseEvent.IsPaused);
        }
    }
}
