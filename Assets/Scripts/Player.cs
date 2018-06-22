using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gameManager;
    public Transform currentTile;
    Transform[] listOfChildren;
    private gameSystem gsScript;
    //private diceChecker dc;
    public Transform tileToSet;
    private tileScript ts;
    public static int points;
    public static bool diceIsDone;
     
    // Use this for initialization
    void Start () {
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        points = diceChecker.thrownPoints;
        diceIsDone = rollingDice.isFinished;
        
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
        if (diceIsDone)
        {
            setSteps();
            diceIsDone = false;
        }
    
    }
    public void setSteps()
    {
        if(currentTile == null)
        {
            Transform[] listOfChildren = gsScript.mapHolder.GetComponentsInChildren<Transform>();
            this.currentTile = listOfChildren[1];
        }
        //iets met punten en hoeveel ze in de lijstje naar beneden moeten en welke tile dat dan is en daar moet de player dan heen groetjes. 
        int thisIndex = this.currentTile.transform.GetSiblingIndex();
        int nextIndex = this.currentTile.transform.GetSiblingIndex() + points + 1;
        listOfChildren = this.currentTile.parent.GetComponentsInChildren<Transform>();
        tileToSet = listOfChildren[nextIndex];
        this.transform.position = tileToSet.position;
        if(tileToSet.tag == ("Uitleggen") || tileToSet.tag == ("Uitbeelden") || tileToSet.tag == ("Opdracht") || tileToSet.tag == ("Neurien") || tileToSet.tag == ("Zoeken"))
        {
            print(tileToSet.tag);    
        }
    }   
}
