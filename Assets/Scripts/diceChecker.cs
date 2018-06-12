using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceChecker : MonoBehaviour
{
    private rollingDice rd;
    public string points; 
    public int thrownPoints = 0;
    
    // Use this for initialization
    void Start()
    {
        points = this.tag;
        rd = GameObject.FindObjectOfType<rollingDice>();
    }

    // Update is called once per frame
    void Update()
    {
    }
     void OnTriggerEnter(Collider col)
    {
        if(rd.Dicetimer <= 0)
        {
            if (col.gameObject.CompareTag("Floor"))
            {
                thrownPoints = int.Parse(points);
                print(thrownPoints);
            }
        }
    }
}