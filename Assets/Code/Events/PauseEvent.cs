public class PauseEvent : Event {
    public PauseEvent(bool init) : base(){
        _isPaused = init;
    }
    private bool _isPaused;
    public void Pause() {
        if(IsPaused) {
            IsPaused = false;
        } else {
            IsPaused = true;
        }
    }

    public bool IsPaused {
        get { return _isPaused; }
        set {
            if(_isPaused != value) {
                _isPaused = value;
                Notify();
            }
        }
    }
}