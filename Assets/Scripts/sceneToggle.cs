using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneToggle : MonoBehaviour {


    private int sceneBuildIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("1"))
        {
            sceneBuildIndex = 0;
            SceneManager.LoadScene(sceneBuildIndex);
        }
        else if (Input.GetKeyDown("2"))
        {
            sceneBuildIndex = 1;
            SceneManager.LoadScene(sceneBuildIndex);
        }
        else if (Input.GetKeyDown("3"))
        {
            sceneBuildIndex = 2;
            SceneManager.LoadScene(sceneBuildIndex);
        }
        else if (Input.GetKeyDown("4"))
        {
            sceneBuildIndex = 3;
            SceneManager.LoadScene(sceneBuildIndex);
        }
        else if (Input.GetKeyDown("5"))
        {
            sceneBuildIndex = 4;
            SceneManager.LoadScene(sceneBuildIndex);
        }
        else if (Input.GetKeyDown("6"))
        {
            sceneBuildIndex = 5;
            SceneManager.LoadScene(sceneBuildIndex);
        }
    }
}
