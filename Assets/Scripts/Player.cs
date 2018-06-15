using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gameManager;
    public Transform currentTile;
    private gameSystem gsScript;
    //private diceChecker dc;
    private tileScript ts;
    public static int points;

    // Use this for initialization
    void Start () {
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        points = diceChecker.thrownPoints;
        print(points + " player");
    }

    // Update is called once per frame
    void Update() {
        float distance = DistanceViewer.getDistance(gsScript.getCurrentCamera());
        Vector3 Mousepos = gsScript.getCurrentCamera().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (distance - 0.4f)));
       if (Input.GetMouseButton(0))
        {
            if (gsScript.cameras[0].enabled)
            {
                this.transform.position = Mousepos;
            }
         
        }   
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Uitleggen") || col.gameObject.CompareTag("Uitbeelden") || col.gameObject.CompareTag("Opdracht") || col.gameObject.CompareTag("Neurien") || col.gameObject.CompareTag("Zoeken"))
        {
            print(col.gameObject.tag);
            //this.currentTile = col.gameObject.transform;
            
        }
    }



}
