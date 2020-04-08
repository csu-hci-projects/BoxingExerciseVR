using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   
    public GameObject[] cubes;
    public Vector3 points = new Vector3(-0.21f, -0.29f, -166.28f);
    
     //public Vector3[] points;
    //public Transform[] points; 
    public float beat = 1;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
            //points = new Transform [new Vector3(cubes[0].transform.localPosition),new Vector3(cubes[1].transform.localPosition), new Vector3(cubes[2].transform.localPosition)];

    //points = new Transform [new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0)];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat) {
                      //  GameObject cube = (GameObject) Instantiate(cubes[Random.Range(0,0)], points[Random.Range(0,2)], Quaternion.identity );

           GameObject cube = (GameObject) Instantiate(cubes[0], cubes[0].transform.localPosition, Quaternion.identity);
                        //GameObject cube = (GameObject) Instantiate(cubes[1], cubes[1].transform.localPosition, Quaternion.identity);

           // GameObject cube = (GameObject) Instantiate(cubes[2], cubes[2].transform.localPosition, Quaternion.identity);

            //cube.transform.localPosition = Vector3.zero;
            cube.transform.localPosition = (cube.transform.forward * -1) * 2.5f;
            //.AddForce((transform.forward * -1) * 2.5f);
            //cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
            timer -= beat;

        }
        timer += Time.deltaTime;

        
    }
}
