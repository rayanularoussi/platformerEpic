using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoLogic : MonoBehaviour
{
    public GameObject package;
    public float deploymentHeight =7.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(package.transform.position, Vector3.down, deploymentHeight))
        {
            Debug.DrawRay(package.transform.position, Vector3.down * deploymentHeight, Color.red);
        }
        else
        {
            Debug.DrawRay(package.transform.position, Vector3.down * deploymentHeight, Color.cyan);
        }
    }
}
