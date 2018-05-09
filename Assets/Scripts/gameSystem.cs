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
    public Transform StartTile;
    


    void Start () {
        
        MapGenererator();
	}
    void MapGenererator()
    {
        string holderName = "Map";
        Transform mapHolder = new GameObject(holderName).transform;
        mapHolder.parent = transform;
        Vector3 position = new Vector3(-Mapsize / 2 + 0.5f + 1, 0, -Mapsize / 2 + 0.5f + 0);
        Transform newTile = Instantiate(StartTile, position, Quaternion.Euler(Vector3.right * 90)) as Transform;
        newTile.localScale = Vector3.one * (1 - outlineSize);
        newTile.parent = mapHolder;
        


        for (int x = 1; x < Mapsize; x++)
        {
            for (int y = 1; y < Mapsize; y++)
            {
                int randomnum = Random.Range(0, 5);
                position = new Vector3(-Mapsize / 2 + 0.5f + x, 0, -Mapsize / 2 + 0.5f + y);
                newTile = Instantiate(tiles[randomnum], position, Quaternion.Euler(Vector3.right * 90)) as Transform;
                newTile.localScale = Vector3.one * (1 - outlineSize );
                newTile.parent = mapHolder;
                print(randomnum);
            }
        }
    }
}
