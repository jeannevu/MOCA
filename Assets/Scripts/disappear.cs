using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour {

    public float startTime;
    public GameObject instructions;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(startTime);

        //make instructions disappear after 7 seconds.
        float endTime = Time.time;
        Debug.Log(endTime);
        if (endTime >= startTime + 7.0f)
        {
            instructions.SetActive(false);
        }
    }
}