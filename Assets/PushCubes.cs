using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCubes : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Cube")){
        rb.AddForce((transform.forward * -1) * thrust);
        }
        if(GameObject.Find("Cube1")){
       //you can't yeild inside an update function
       // yield WaitForSeconds (1);
        rb.AddForce((transform.forward * -1) * thrust);
        }
        if(GameObject.Find("Cube2")){
        //yield WaitForSeconds (0.25);
        rb.AddForce((transform.forward * -1) * thrust);
        }
    }
}
