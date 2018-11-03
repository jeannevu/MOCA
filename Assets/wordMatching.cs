using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wordMatching : MonoBehaviour {

    public GameObject text1, text2, text3;
    public int count;
    public int score;

	// Use this for initialization
	void Start () {
        text1.SetActive(true);
        text2.SetActive(true);
        text3.SetActive(true);
    }

    // Update is called once per frame
    void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if(count == 0 && other.name == "fruit")
        {
            count++;
        }
        else if(count == 1 && other.name == "riding")
        {
            count++;
        }
        else if(count == 2 && other.name == "tool")
        {
            count++;
        }
        else
        {
            score = 0;
            SceneManager.LoadScene(3);
        }
    }
}
