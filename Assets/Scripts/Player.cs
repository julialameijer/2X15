using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gameManager;
    public Transform currentTile;
    private gameSystem gsScript;
    private diceChecker dc;
    private tileScript ts;

    // Use this for initialization
    void Start () {
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        dc = GameObject.FindObjectOfType<diceChecker>();
        int points = dc.thrownPoints;
        print(points);
    }

    // Update is called once per frame
    void Update() {
        float distance = DistanceViewer.getDistance(gsScript.getCurrentCamera());
        Vector3 Mousepos = gsScript.getCurrentCamera().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (distance - 0.4f)));
        

       if (Input.GetMouseButton(0))
        {
          this.transform.position = Mousepos;
        }   
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Uitleggen") || col.gameObject.CompareTag("Uitbeelden") || col.gameObject.CompareTag("Opdracht") || col.gameObject.CompareTag("Neurien") || col.gameObject.CompareTag("Zoeken"))
        {

            currentTile.transform.position = col.gameObject.transform.position;
        }
    }



}
