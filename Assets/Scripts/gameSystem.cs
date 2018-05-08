using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameSystem : MonoBehaviour {
    //The gamesystem class does count the points of the teams, and builds the grid for the board. 
    // Use this for initialization
    public int Mapsize;
    public float outlineSize;
    //public Transform TilePrefab;
    public Transform[] tiles;
    


    void Start () {
        
        MapGenererator();
	}
    void MapGenererator()
    {
        
        string holderName = "Map";
        if (transform.Find(holderName))
        {
            DestroyImmediate(transform.Find(holderName).gameObject);
        }
        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;

        for (int x = 0; x < Mapsize; x++)
        {
            for (int y = 0; y < Mapsize; y++)
            {
                int randomnum = Random.Range(0, 5);
                Vector3 position = new Vector3(-Mapsize / 2 + 0.5f + x, 0, -Mapsize / 2 + 0.5f + y);
                Transform newTile = Instantiate(tiles[randomnum], position, Quaternion.Euler(Vector3.right * 90)) as Transform;
                newTile.localScale = Vector3.one * (1 - outlineSize );
                newTile.parent = mapHolder;
                print(randomnum);
            }
        }
    }
}
