using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;


public class DrawLine : MonoBehaviour {

    private LineRenderer lineRenderer;
    private float counter;
    private float distance;
    public float startTime;

    public Vector3 origin; //origin of line
    public Vector3 destination;

    public int count;

    public float lineDrawSpeed = 6f;

    public GameObject controllerLeft;
    public GameObject controllerRight;



    // Use this for initialization
    void Start () {

        /*
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, origin.position);
        lineRenderer.SetWidth(.45f, .45f); //._f [starting width], ._f [ending width]

        distance = Vector3.Distance(origin.position, destination.position);
		*/
	}
	
	// Update is called once per frame
	void Update () {

        if(count == 0 && origin !=null)
        {
            count++;
        }
  
        /*
        if (press button)
        {
            Vector3 origin = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            startTime = Time.time;
        }

        float currTime = Time.time;
        if(currTime >= startTime + 5.0f)
        {
            Vector3 destination = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            Vector3 origin = destination;
        }
        else if(let go of button)
        {
            Vector3 destination = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }*/

        /*
        if (counter<distance)
        {
            counter += .1f / lineDrawSpeed;
            float x = Mathf.Lerp(0, distance, counter);
            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;

            //Get unit vector of desired direction, multiply by desired length and add starting position
            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;
            lineRenderer.SetPosition(1, pointAlongLine); 

        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Origin")
        {
            origin = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
