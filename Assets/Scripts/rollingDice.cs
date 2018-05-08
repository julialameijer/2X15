using System.Collections;
using UnityEngine;

public class rollingDice : MonoBehaviour {
    public float forceStrenght;
    public float torqueStrenght;
    public ForceMode forcemode;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Random.onUnitSphere * forceStrenght, forcemode);
            rb.AddTorque(Random.onUnitSphere * torqueStrenght, forcemode);
        }
	}
}
    