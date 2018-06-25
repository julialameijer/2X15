using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour {
    public Text buttonText;
    public bool buttonPressed = false;
    public Button MyButton;
    // Use this for initialization
    void Start() {
        buttonText.text = "HEllo";
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void IsClicked()
    {
        buttonPressed = true;
        if (buttonPressed)
        {
            GetComponent<Image>().color = Color.green;
            buttonPressed = false;
            
        }
        else if(buttonPressed)
        {
            GetComponent<Image>().color = Color.red;
        }
        
        
    }
}
