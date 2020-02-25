using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour, IPlayable
{
    // Start is called before the first frame update
    public float speed;
    void Start() {
        speed = 3.0f;
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void Jump() {

    }

    public void FirePrimary() {

    }

    public void FireSecondary() {

    }

    public void Move(float x, float y, float deltaTime) {
        var dir = new Vector2(x, y).normalized;
        gameObject.transform.Translate(dir * deltaTime * speed);
    }
}
