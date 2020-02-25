using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    private PauseEvent pauseEvent; 
    private Event firePrimaryEvent, fireSecondaryEvent, jumpEvent;
    public TestPlayer _player;
    void Awake()
    {
        pauseEvent = new PauseEvent(false);
        firePrimaryEvent = new Event();
        fireSecondaryEvent = new Event();
        jumpEvent = new Event();

        GameManager.instance.Events.Register("Pause", pauseEvent);
        GameManager.instance.Events.Register("Jump", jumpEvent);
        GameManager.instance.Events.Register("FirePrimary", firePrimaryEvent);
        GameManager.instance.Events.Register("FireSecondary", fireSecondaryEvent);
        
    }

    void Start() {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            _player.FirePrimary();
            firePrimaryEvent.Notify();
        }

        if(Input.GetButtonDown("Fire2")){
            _player.FireSecondary();
            fireSecondaryEvent.Notify();
        }

        if(Input.GetButtonDown("Jump")){
            _player.Jump();
            jumpEvent.Notify();
        }

        if(Input.GetKeyDown("escape")) {
            pauseEvent.Pause();
        }

        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Debug.Log("Hori:" + xInput.ToString());
        Debug.Log("Vert:" + yInput.ToString());
        _player.Move(xInput, yInput, Time.deltaTime);
    }
}
