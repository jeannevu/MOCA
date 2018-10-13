using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {

    private LineRenderer lineRenderer;
    private float counter;
    private float distance;

    public Transform origin; //origin of line
    public Transform destination;

    public float lineDrawSpeed = 6f;

    public GameObject controllerLeft;
    public GameObject controllerRight;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetWidth(.45f, .45f); //._f [starting width], ._f [ending width]

        distance = Vector3.Distance(origin.position, destination.position);
		
	}
	
	// Update is called once per frame
	void Update () {
        if(counter<distance)
        {
            counter += .1f / lineDrawSpeed;
            float x = Mathf.Lerp(0, distance, counter);
            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;

            //Get unit vector of desired direction, multiply by desired length and add starting position
            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
            lineRenderer.SetPosition(1, pointAlongLine); 

        }
	}
}
