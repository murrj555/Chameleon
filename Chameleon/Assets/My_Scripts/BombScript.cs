using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BombScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                print("Triggered by Player!");
                // Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
                SceneManager.LoadScene ("03_GameOver", LoadSceneMode.Single);
            }
        }
    
}
