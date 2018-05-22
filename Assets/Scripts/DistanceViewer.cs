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

    public static float getDistance(Camera c)
    {
        RaycastHit hit;
        float distance = 0;
            if (Physics.Raycast(c.transform.position, Vector3.down, out hit))
            {
                
                distance = c.transform.position.y - hit.transform.position.y;
            }
        return distance;
    }
}
