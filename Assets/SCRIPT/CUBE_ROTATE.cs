using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE_ROTATE : MonoBehaviour
{
    public GameObject CubeObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CubeObject.transform.Rotate(Vector3.forward * (Time.deltaTime * 10));
        
    }
}
