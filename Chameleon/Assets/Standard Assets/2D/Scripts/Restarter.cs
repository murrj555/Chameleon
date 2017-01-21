using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {

    	void Update(){

    		transform.position += Vector3.up * Time.deltaTime;
    	}

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}
