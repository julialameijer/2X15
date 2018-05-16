using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
     
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        RaycastHit hit;
        float distance = DistanceViewer.getDistance();
        Vector3 Mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, (distance - 0.4f)));
    

       if (Input.GetMouseButton(0))
        {
          this.transform.position = Mousepos;
        }
    }


    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.CompareTag("Uitleggen"))
    //    {
    //        print("heloo");
    //    }
    //    //other.getComponent<Collider>();
    //    //print(other.tag);
    //}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Uitleggen")){
            print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Uitbeelden")){
            print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Opdracht"))
        {
            print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Neurien"))
        {
            print(col.gameObject.tag);
        }
        else if (col.gameObject.CompareTag("Zoeken"))
        {
            print(col.gameObject.tag);
        }

    }

}
