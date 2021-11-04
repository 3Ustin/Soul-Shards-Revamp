using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class AddTile : MonoBehaviour
{

    public TileBase player;
    public Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GetComponent<Tilemap>();
        Vector3Int tilemapCell = new Vector3Int(0, 4, 0);
        Vector3Int tilemapCell2 = new Vector3Int(0, 7, 0);

        Debug.Log("test! it!");
        Debug.Log(tilemapCell);
        Debug.Log(player);

        // TileBase hey = new TileBase()
        tilemap.GetTile(tilemapCell);


        tilemap.SetTile(tilemapCell2, player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
