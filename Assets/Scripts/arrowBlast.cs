using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowBlast : MonoBehaviour {

    public int count;
    public int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (count == 0 && other.name == "1")
        {
            Destroy(other);
            count++;
        }
    }
}
