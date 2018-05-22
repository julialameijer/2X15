using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gameManager;

    private gameSystem gsScript;

    // Use this for initialization
    void Start () {
        gsScript = GameObject.FindObjectOfType<gameSystem>();
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
        if (col.gameObject.CompareTag("Uitleggen")){    
            print(col.gameObject.tag);

        }
        else if (col.gameObject.CompareTag("Uitbeelden")){
           // print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Opdracht"))
        {
            //print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Neurien"))
        {
           // print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Zoeken"))
        {
           // print(col.gameObject.tag);
        }

    }

}
