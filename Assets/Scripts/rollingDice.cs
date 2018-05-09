using System.Collections;
using UnityEngine;

public class rollingDice : MonoBehaviour {
    public float forceStrenght;
    public float torqueStrenght;
    public float Dicetimer = 2f;
    bool isRolling = false;
    public ForceMode forcemode;
    public Rigidbody rb;
    SphereCollider sc;
    BoxCollider bc;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sc = GetComponent<SphereCollider>();
        bc = GetComponent<BoxCollider>();
        sc.enabled = false;
        bc.enabled = true;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dicetimer = 2f;
            isRolling = true;
            sc.enabled = true;
            bc.enabled = false;
            Vector3 randomUnit = Random.onUnitSphere;
            rb.AddForce(randomUnit * forceStrenght, forcemode);
            rb.AddTorque(randomUnit * torqueStrenght, forcemode);
            print(randomUnit);
        }
        if (Dicetimer > 0 && isRolling == true)
        {
            Dicetimer -= Time.deltaTime;
            
        }
        else
        {
            isRolling = false;
            sc.enabled = false;
            bc.enabled = true;
        }
    }
}


    