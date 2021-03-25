using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    // Start is called before the first frame update
    void OnTriggerEnter2D ()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }

}
