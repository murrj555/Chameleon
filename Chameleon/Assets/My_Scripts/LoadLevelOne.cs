using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOne : MonoBehaviour {

	 void Update() {
        if (Input.GetKeyDown("space")){

            print("space key was pressed");
             // Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode
        	 SceneManager.LoadScene ("02_LevelOne", LoadSceneMode.Single);

        	
        }
    }
}