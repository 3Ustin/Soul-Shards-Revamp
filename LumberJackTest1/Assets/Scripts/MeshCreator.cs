using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCreator : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;

    int[] triangles;
    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateMesh();
        UpdateMesh();
    }
    void CreateMesh(){
        // vertices = new Vector3[]
        // {
        //     new Vector3 (0,0,0),
        //     new Vector3 (1,1,0),
        //     new Vector3 (1,2,0)
        // };
        // triangles = new int[]
        // {
        //     0,1,10,1,11,10,1,2,11,2,12,11,2,3,12,3,13,12,3,4,13
        // };






        //Method for Generating vectors
        vertices = new Vector3[100];
        int n = 0;
            for(int x = 0; x < 100; x +=10){
                for(int z = 0; z < 100; z+=10){
                    vertices[n] = new Vector3 (x,0,z);
                    Debug.Log(vertices[n].magnitude);
                    n++;
                }
            }
        //Method for Generating Triangles
        triangles = new int[99];
        n = 0;
        for(int i = 0; n < 20; i+=1)
        {
            triangles[n] = i;
            triangles[n+1] = i+1;
            triangles[n+2] = i+10;
            n+=3;
        }
    }

    // Update is called once per frame
    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
