using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceViewer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
	}

    public static float getDistance()
    {
        RaycastHit hit;
        float distance = 0;
        if (Physics.Raycast(Camera.main.transform.position, Vector3.down, out hit))
        {
            distance = Camera.main.transform.position.y - hit.transform.position.y;
            
        }
        return distance;
    }
}
