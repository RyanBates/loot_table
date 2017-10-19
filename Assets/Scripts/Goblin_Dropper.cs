using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Dropper : MonoBehaviour
{
    [Range(0, 1)]
    public float Chance;

    bool Random;

    public GameObject Sphere;
    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject Capsule;

    public List<GameObject> dropTable;

    float currnetTime, previousTime, deltaTime;

    
    void Start ()
    {
        Instantiate(Sphere, transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z), Quaternion.identity);
        dropTable.Add(Sphere);

        Instantiate(Cube, transform.position = new Vector3(transform.position.x + 5, transform.position.y, transform.position.z), Quaternion.identity);
        dropTable.Add(Cube);

        Instantiate(Cylinder, transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z), Quaternion.identity);
        dropTable.Add(Cylinder);

        Instantiate(Capsule, transform.position = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z), Quaternion.identity);
        dropTable.Add(Capsule);

    }
    
    void Update ()
    {
            currnetTime = Time.time;
            previousTime = currnetTime - .0161f;
            deltaTime += currnetTime - previousTime;

    }
}
