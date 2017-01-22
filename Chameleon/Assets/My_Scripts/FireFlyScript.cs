using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class FireFlyScript : MonoBehaviour
{



    void OnStart(){
        

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);


    }

    private void OnTriggerEnter2D(Collider2D FireFly)
        {

            if (FireFly.tag == "Player")
            {

                print("Triggered by Player!");

                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                audio.Play(44100);

                // Kills the game object

				Destroy (gameObject, 0.15f);

            }


        }

    
    
}
