using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceChecker : MonoBehaviour
{
    private rollingDice rd;
    public string points; 
    public static int thrownPoints = 0;
    public Collider col;    
    
    // Use this for initialization
    void Start()
    {
        Collider col = GetComponent<Collider>();
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
                print(thrownPoints + "dicescript");
                
            }
        }
    }
}