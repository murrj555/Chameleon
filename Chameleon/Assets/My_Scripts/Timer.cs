using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	// display time
	public Text timerText;

	//var that starts counting time
	public float startTime;

	private bool finnished = false;

	

	void Start() {



		//sets start time to real second time, and not frame time
    	startTime = Time.time;
    


    }

    void Update() {
    	if (finnished){
    		return;
    	}

    	float t = Time.time - startTime;

    	string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f2");

        timerText.text = "SCORE TIME: " + minutes + ":" + seconds;


        
    }

    void GameOverText(){

    	finnished = true;
    	timerText.color = Color.yellow;

    }



}