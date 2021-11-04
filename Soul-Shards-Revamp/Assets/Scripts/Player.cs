using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Player : MonoBehaviour {

   // [SerializeField]

    // public Tilemap tilemap;
    public Vector3Int startPos;
    
    public TileBase playerTile;  

    public Tilemap tilemap;
    public Transform transform;
    
    private Vector3Int previous;

    
    // Start is called before the first frame update
    void Start() {
        Vector3Int tilemapCell = tilemap.WorldToCell(transform.position);
        Debug.Log("test! it!");
        Debug.Log(tilemapCell);

        tilemap.SetTile(tilemapCell, playerTile);
    }

    // Update is called once per frame
    void Update() {
        UpdateMovement();
    }

    void UpdateMovement() {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        direction.Normalize();



    }

    void LateUpdate() {
        Vector3Int tilemapCell = tilemap.WorldToCell(transform.position);

        tilemapCell.x += 1;
 
        // if the position has changed
        if(tilemapCell != previous)
        {
            // set the new tile
            tilemap.SetTile(tilemapCell, playerTile);
 
            // erase previous
            tilemap.SetTile(previous, null);
 
            // save the new position for next frame
            previous = tilemapCell;
        }
    }
}
