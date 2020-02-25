using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputUIElement : MonoBehaviour, IObserver
{
    private Text element; 
    public string InputName;
    // Start is called before the first frame update
    void Start() {
        element = gameObject.GetComponent<Text>();
        element.text = InputName;
        gameObject.SetActive(false);
        GameManager.instance.Events.GetEvent(InputName).Subscribe(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Receive(IObservable subject) {
        gameObject.SetActive(true);
        StartCoroutine(TimeOut());
    }

    IEnumerator TimeOut() {
        yield return new WaitForSeconds(1);
        gameObject.SetActive(false);
    }
}
