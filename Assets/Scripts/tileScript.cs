using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileScript : MonoBehaviour {
    Vector2 tileID = new Vector2(0, 0);
    public List<Vector2> TileIDStorage;
    private gameSystem gsScript;
    // Use this for initialization
    void Start () {
        
        gsScript = GameObject.FindObjectOfType<gameSystem>();
        tileID = getTileID(this.transform.position.x, this.transform.position.z);
        //print(tileID + " " + this.tag);
        TileIDStorage.Add(this.tileID);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    public void checkTile(Player player)
    {
        if(this.transform.position == player.transform.position)
        {

        }
        
    }

    public Vector2 getTileID(float i, float j)
    {
        Vector2 TileID = new Vector2(i, j);
        return TileID;
    }
}
