using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileScript : MonoBehaviour {
    Vector2 tileID = new Vector2(0, 0);
    private gameSystem gsScript;
    // Use this for initialization
    void Start () {
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        tileID = gsScript.getTileID(this.transform.position.x, this.transform.position.z);
        print(tileID + " " + this.tag);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
