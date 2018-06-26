using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject gameManager;
    public Transform currentTile;
    Transform[] listOfChildren;
    private gameSystem gsScript;
    private cardScript cs;
    //private diceChecker dc;
    public Transform tileToSet;
    private tileScript ts;
    public static int points;
    public static bool diceIsDone;

    void Start()
    {
        cs = GameObject.FindObjectOfType<cardScript>();
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        points = diceChecker.thrownPoints;
        diceIsDone = rollingDice.isFinished;

    }

    // Update is called once per frame
    void Update()
    {
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
        if (currentTile == null)
        {
            Transform[] listOfChildren = gsScript.mapHolder.GetComponentsInChildren<Transform>();
            this.currentTile = listOfChildren[1];
        }
        
        int thisIndex = this.currentTile.transform.GetSiblingIndex();
        int nextIndex = this.currentTile.transform.GetSiblingIndex() + points + 1;
        listOfChildren = this.currentTile.parent.GetComponentsInChildren<Transform>();
        tileToSet = listOfChildren[nextIndex];
        this.transform.position = tileToSet.position;
    }

}