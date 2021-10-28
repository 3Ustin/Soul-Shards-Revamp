using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour {

    // public Tilemap tilemap;
    // public Vector3Int startPos;
    // public Transform transform;

    // [SerializeField]
    public Transform transform;
    public Tilemap tilemap;

    
    // Start is called before the first frame update
    void Start() {
        // tilemap = GetComponent<Tilemap>();
        // tilemap.SetTile(startPos, );
    }

    // Update is called once per frame
    void Update() {
        // UpdateMovement();
    }

    // void UpdateMovement() {
    //     // Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    //     // direction.Normalize();

    // }
}
