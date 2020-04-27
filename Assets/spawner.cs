using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
public GameObject enemy;              
    public float spawnTimeDelay = 3f;
    public float spawnTimeInGame = 2f;
    public Vector3 spawnLocation = new Vector3(0,2,0);

void Spawn () {
        GameObject SpawnLocation = (GameObject)Instantiate (enemy, spawnLocation, Quaternion.identity);
    }
    void Start()
    {
float spawnTimeDelay = Random.Range(0.5f, 1.5f);
float spawnTimeInGame = Random.Range(0.5f, 1.5f);
                InvokeRepeating ("Spawn", spawnTimeDelay, spawnTimeInGame);

//startpos = spawnee.transform.localPosition;
//InvokeRepeating("SpawnObject", spawnTime, spawnDelay);

       //InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        //cubes[0].transform.position = GameObject.Find("spawner").transform.position; // We set a axis, in this case the y axis
        // cubeposition = cubes[0].transform.localPosition;
        // cuberotation = cubes[0].Rotate.localPosition;

        //points = new Transform [new Vector3(0,0,0), new Vector3(0,0,0), new Vector3(0,0,0)];

    }
// public void SpawnObject() {
    
//      GameObject clone = spawnee;
//       Instantiate(clone, startpos, spawnPos.rotation);
//         clone.transform.localPosition = (clone.transform.forward * -1) * 2.5f;
//         if(stopSpawning) {
//             CancelInvoke("SpawnObject");
//         }
//         //yeild return new WaitForSeconds(5);
//     }
    // Update is called once per frame





    
    void Update()
    {
       //Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
//InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    //     spawnee.transform.localPosition = (spawnee.transform.forward * -1) * 2.5f;
    // InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    
        //CreateObject(cubes[0]);
        // if (timer > beat) {
        //   GameObject cube = (GameObject) Instantiate(spawnee, startpos, spawnPos.rotation);

        //     if (!instantiated) {
        //         spawnee.transform.localPosition = (spawnee.transform.forward * -1) * 2.5f;
        //     }
        //      instantiated = true;
        
        //               //  GameObject cube = (GameObject) Instantiate(cubes[Random.Range(0,0)], points[Random.Range(0,2)], Quaternion.identity );

        //    GameObject cube = (GameObject) Instantiate(cubes[0], cubeposition, transform.rotation);
        //                 //GameObject cube = (GameObject) Instantiate(cubes[1], cubes[1].transform.localPosition, Quaternion.identity);

        

        //     //cube.transform.localPosition = Vector3.zero;
        //     cube.transform.localPosition = (cube.transform.forward * -1) * 2.5f;
        //     //.AddForce((transform.forward * -1) * 2.5f);
        //     //cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4));
        //      timer -= beat;

        // }
        //  timer += Time.deltaTime;


    }
}
