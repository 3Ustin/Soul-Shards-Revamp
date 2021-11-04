using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    public GameObject parent;
    public GameObject cylinder;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            Vector3 Z = new Vector3(0,0,1);
            Vector3 mousePos = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            int layerMask = 1 << 8;
            if (Physics.Raycast(ray, out hit , Mathf.Infinity, layerMask)){
                Vector3 cylinderRay = hit.point;
                createCylinder(cylinderRay);
            }
            else{
                Debug.Log("NO OBJECT");
            }
        }
    }

    void createCylinder(Vector3 cylinderRay){
        GameObject cylinderClone = Instantiate(cylinder, cylinderRay, Quaternion.identity,parent.transform);
        Vector3 v = new Vector3(1,0,0);
        cylinderClone.transform.SetPositionAndRotation(cylinderClone.transform.position,Quaternion.AngleAxis(90, v));
    }
}
