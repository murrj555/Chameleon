using UnityEngine;
using System.Collections;

public class LerpColor : MonoBehaviour {
    public Color lerpedColor = Color.white;
    
    void Update() {
        lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
    }
}