using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class rollingDice : MonoBehaviour {
    float forceStrenght = 20;
    float torqueStrenght = 15;
    bool isRolling = false;
    bool isPressed = false;
    public ForceMode forcemode;
    public GameObject floor;
    public Rigidbody rb;
    public float Dicetimer = 0f;
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
        if (!isPressed)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isPressed = true;
                Dicetimer = 2f;

                isRolling = true;
                sc.enabled = true;
                bc.enabled = false;
                Vector3 randomUnit = Random.onUnitSphere;
                rb.AddForce(randomUnit * forceStrenght, forcemode);
                rb.AddTorque(randomUnit * torqueStrenght, forcemode);
            }
            
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
            if (isPressed && Dicetimer <= 0)
            {
                SceneManager.LoadScene(2);
            }
            
        }

    }

    
}



    